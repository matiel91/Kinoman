using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class CertImageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CertImage) || t == typeof(CertImage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return CertImage.Empty;
                case "/-/media/images/certificates/12.png":
                    return CertImage.MediaImagesCertificates12Png;
                case "/-/media/images/certificates/15.png":
                    return CertImage.MediaImagesCertificates15Png;
            }
            throw new Exception("Cannot unmarshal type CertImage");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CertImage)untypedValue;
            switch (value)
            {
                case CertImage.Empty:
                    serializer.Serialize(writer, ""); return;
                case CertImage.MediaImagesCertificates12Png:
                    serializer.Serialize(writer, "/-/media/images/certificates/12.png"); return;
                case CertImage.MediaImagesCertificates15Png:
                    serializer.Serialize(writer, "/-/media/images/certificates/15.png"); return;
            }
            throw new Exception("Cannot marshal type CertImage");
        }
    }
}

