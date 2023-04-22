using Birds_Mangmeant;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[JsonObject(MemberSerialization.OptIn)]
public class Cage
{
    [JsonProperty]
    public string? IndexNumber { get; set; }

    [JsonProperty]
    public string? Length { get; set; }

    [JsonProperty]
    public string? Width { get; set; }

    [JsonProperty]
    public string? Height { get; set; }

    [JsonProperty]
    public string? Material { get; set; }

    [JsonProperty(nameof(BirdsOfCage))]
   // [JsonConverter(typeof(BirdsOfCageConverter))]
    public Dictionary<string,Bird>? BirdsOfCage
    {
        get;
        set;
    }


    [JsonProperty]
    public string? IndexKey { get; set; }

    public int getBirdsAmount() {
        if (BirdsOfCage != null) {
            return BirdsOfCage.Count;
        }
        else { return 0; }
        
    }
    

   
    public Cage()
    {
        // initialize BirdsOfCage to an empty list if it's currently null
        BirdsOfCage = new Dictionary<string, Bird>();
    }
    //public class BirdsOfCageConverter : JsonConverter<List<Bird>>
    //{
    //    public override List<Bird>? ReadJson(JsonReader reader, Type objectType, List<Bird>? existingValue, bool hasExistingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.StartArray)
    //        {
    //            // If the value is an array, deserialize it as a List<Bird>
    //            return serializer.Deserialize<List<Bird>>(reader);
    //        }
    //        else if (reader.TokenType == JsonToken.StartObject)
    //        {
    //            // If the value is an object, deserialize it as a single Bird and wrap it in a List<Bird>
    //            var bird = serializer.Deserialize<Bird>(reader);
    //            if (bird != null)
    //            {
    //                var list = new List<Bird>();
    //                list.Add(bird);
    //                return list;
    //            }
    //            else
    //            {
    //                return new List<Bird>();
    //            }
    //        }
    //        else
    //        {
    //            throw new JsonSerializationException($"Unexpected token type {reader.TokenType} for property BirdsOfCage");
    //        }
    //    }

    //    public override void WriteJson(JsonWriter writer, List<Bird> value, JsonSerializer serializer)
    //    {
    //        if (value == null)
    //        {
    //            writer.WriteNull();
    //            return;
    //        }

    //        writer.WriteStartArray();
    //        foreach (Bird bird in value)
    //        {
    //            serializer.Serialize(writer, bird);
    //        }
    //        writer.WriteEndArray();
    //    }
    //}
}
