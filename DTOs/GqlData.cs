using System.Text.Json.Serialization;

namespace TitleInfoClient.DTOs
{
    public partial class GqlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("titles")]
        public TitleInfoSearchDTO[] Titles { get; set; }
    }


}