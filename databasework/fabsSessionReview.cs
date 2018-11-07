// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using espc2018;
//
//    var fabsSession = FabsSession.FromJson(jsonString);

namespace espc2018
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FabsSession
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("sessionNumber")]
        public string SessionNumber { get; set; }

        [JsonProperty("sessionName")]
        public string SessionName { get; set; }

        [JsonProperty("sessionDate")]
        public string SessionDate { get; set; }

        [JsonProperty("sessionCity")]
        public string SessionCity { get; set; }

        [JsonProperty("sessionRegionState")]
        public string SessionRegionState { get; set; }

        [JsonProperty("sessionCountry")]
        public string SessionCountry { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zerotofiveRating")]
        public long ZerotofiveRating { get; set; }

        [JsonProperty("feedback")]
        public string Feedback { get; set; }

        [JsonProperty("requestContact")]
        public bool RequestContact { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class FabsSession
    {
        public static FabsSession FromJson(string json) => JsonConvert.DeserializeObject<FabsSession>(json, espc2018.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FabsSession self) => JsonConvert.SerializeObject(self, espc2018.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
