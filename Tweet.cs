using System.Runtime.Serialization;

namespace RxWinForms
{
    [DataContract]
    public class Tweet
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "from_user")]
        public string Username { get; set; }

        [DataMember(Name = "text")]
        public string Content { get; set; }
    }
}