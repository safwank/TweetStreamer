using System.Runtime.Serialization;

namespace RxWinForms
{
    [DataContract]
    public class TweetSearchResult
    {
        [DataMember(Name = "max_id")]
        public long MaxId { get; set; }

        [DataMember(Name = "results")]
        public Tweet[] Tweets { get; set; }
    }
}