using System.Text.Json.Serialization;

namespace WebAPIC_.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] // so it Appears as the Var not Val (Fighter not 1)
    public enum Categories
    {
        Fighter = 1,
        Assasin = 2,
        Tank=3
    }
}