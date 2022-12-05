using Newtonsoft.Json;

namespace FinanceApp.Models
{
    public class NewsArticle
    {
        [JsonProperty("title")]
        public string Title;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("source")]
        public string Source;

        [JsonProperty("tickers")]
        public List<string> Tickers;

        [JsonProperty("tags")]
        public List<string> Tags;

        [JsonProperty("published_at")]
        public DateTime PublishedAt;
    }

    public class Pagination
    {
        [JsonProperty("limit")]
        public int Limit;

        [JsonProperty("offset")]
        public int Offset;

        [JsonProperty("count")]
        public int Count;

        [JsonProperty("total")]
        public int Total;
    }

    public class FinanceNews
    {
        [JsonProperty("pagination")]
        public Pagination Pagination;

        [JsonProperty("data")]
        public List<NewsArticle> Data;
    }


}
