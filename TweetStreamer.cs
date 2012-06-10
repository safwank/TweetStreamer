using System;
using System.Collections.Generic;
using System.Net;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Windows.Forms;

namespace RxWinForms
{
    public partial class TweetStreamer : Form
    {
        private List<Tweet> tweets;
        private readonly IObservable<EventPattern<EventArgs>> stopClicked;
        private readonly DataContractJsonSerializer jsonSerializer;

        public TweetStreamer()
        {
            InitializeComponent();
            jsonSerializer = new DataContractJsonSerializer(typeof (TweetSearchResult));
            stopClicked = Observable.FromEventPattern<EventArgs>(stopButton, "Click");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            tweets = new List<Tweet>();
            tweetSource.DataSource = tweets;

            DisplayProgress("Loading tweets...");
            tweetSource.ResetBindings(false);
            
            GetTweetsOn(keyword.Text, 0).ToObservable(Scheduler.ThreadPool)
                .Buffer(TimeSpan.FromSeconds(5))
                .TakeUntil(stopClicked)
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(LoadNewTweets(), DisplayError());
        }

        private IEnumerable<Tweet> GetTweetsOn(string searchKeyword, long sinceId)
        {
            var searchUrl = string.Format("http://search.twitter.com/search.json?q={0}&rpp=100&include_entities=true&result_type=mixed&since_id={1}",
                                          searchKeyword,
                                          sinceId);
            var request = (HttpWebRequest) WebRequest.Create(searchUrl);
            TweetSearchResult tweetSearchResult;

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var status = string.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription);
                    DisplayStatus(status);
                }

                using (var responseStream = response.GetResponseStream())
                {
                    tweetSearchResult = (TweetSearchResult) jsonSerializer.ReadObject(responseStream);

                    foreach (var tweet in tweetSearchResult.Tweets)
                    {
                        yield return tweet;
                    }
                }
            }

            foreach (var tweet in GetTweetsOn(searchKeyword, tweetSearchResult.MaxId))
            {
                yield return tweet;
            }
        }

        private Action<IList<Tweet>> LoadNewTweets()
        {
            return newTweets =>
                       {
                           var firstDisplayedRowIndex = Math.Max(tweetStreamGrid.FirstDisplayedScrollingRowIndex, 0);

                           tweets.AddRange(newTweets);
                           tweetSource.ResetBindings(false);

                           tweetStreamGrid.FirstDisplayedScrollingRowIndex = firstDisplayedRowIndex;

                           var progressMessage = string.Format("Loaded {0} tweets", tweets.Count.ToString("#,#"));
                           DisplayProgress(progressMessage);
                       };
        }

        private Action<Exception> DisplayError()
        {
            return exception =>
                       {
                           var message = exception.Message;
                           DisplayStatus(message.Contains("503") ? "Throttled by Twitter, retrying in 2 minutes..." : message);
                       };
        }

        private void DisplayProgress(string progressMessage)
        {
            progressLabel.Text = progressMessage;
        }

        private void DisplayStatus(string status)
        {
            statusLabel.Text = status;
        }
    }
}