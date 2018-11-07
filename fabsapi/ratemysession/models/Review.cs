using System;
using Newtonsoft.Json;

namespace ratemysession.models
{
    public class Review
    {
        [JsonProperty(PropertyName = "text")]
        public string Text {get; set;}
    }
}