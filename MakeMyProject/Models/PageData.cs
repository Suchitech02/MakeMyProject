using Newtonsoft.Json;
using System.Collections.Generic;

namespace MakeMyProject.Models
{
    public class PageData
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("year")]
        public string year { get; set; }
        [JsonProperty("color")]
        public string color { get; set; }
        [JsonProperty("pantone_value")]
        public string pantone_value { get; set; }
        public string group { get; set; }
        [JsonProperty("page")]
        public string page { get; set; }
    }
    public class Data
    {
        public List<PageData> data { get; set; }
    }
}
}