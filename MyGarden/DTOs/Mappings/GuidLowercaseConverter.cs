using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyGarden.DTOs.Mappings
{
    public class GuidLowercaseConverter : JsonConverter<Guid>
    {
        public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetGuid();
        }

        public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("d"));
        }
    }
}
