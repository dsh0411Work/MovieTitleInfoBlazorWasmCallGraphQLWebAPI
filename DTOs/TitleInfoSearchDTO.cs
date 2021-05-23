using System.Text.Json.Serialization;

namespace TitleInfoClient.DTOs
{
    public class TitleInfoSearchDTO
    {
        [JsonPropertyName("titleId")]
        public long TitleId { get; set; }

        [JsonPropertyName("titleName")]
        public string TitleName { get; set; }

        [JsonPropertyName("storyLines")]
        public StoryLine[] StoryLines { get; set; }

        public partial class StoryLine
        {
            [JsonPropertyName("description")]
            public string Description { get; set; }
        }

    }
}