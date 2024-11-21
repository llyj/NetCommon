using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ServiceStack;

namespace NetCommon.JsonConverters
{
    public class NullableDateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string _dateFormatString;

        public NullableDateTimeConverter(string dateFormatString = "yyyy-MM-dd HH:mm:ss")
        {
            _dateFormatString = dateFormatString;
        }

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //Debug.Assert(typeToConvert == typeof(DateTime?));
            string @string = reader.GetString();
            return @string.IsNullOrEmpty() ? null : new DateTime?(DateTime.Parse(@string));
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value?.ToString(_dateFormatString));
        }
    }
}