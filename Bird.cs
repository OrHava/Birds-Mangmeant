using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Mangmeant
{

    [JsonObject(MemberSerialization.OptIn)]
    public  class Bird
	{

        [JsonProperty]
        public string?	 IndexNumber { get; set; }

        [JsonProperty]
        public string?	 Breed_of_Bird { get; set; }
        [JsonProperty]
        public string?	 Subspecies { get; set; }
        [JsonProperty]
        public string?	 HatchDate { get; set; }
        [JsonProperty]

        public string?	 IndexCage { get; set; }
        [JsonProperty]

        public string?	 IndexMother { get; set; }
        [JsonProperty]
        public string?	 IndexFather{ get; set; }
        [JsonProperty]

        public string?	 Gender { get; set; }

        [JsonProperty]
        public string? IndexKey { get; set; }

        public string GetBirdInfoAsString()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"Index Number: {IndexNumber}");
            sb.AppendLine($"Breed of Bird: {Breed_of_Bird}");
            sb.AppendLine($"Subspecies: {Subspecies}");
            sb.AppendLine($"Hatch Date: {HatchDate}");
            sb.AppendLine($"Index Cage: {IndexCage}");
            sb.AppendLine($"Index Mother: {IndexMother}");
            sb.AppendLine($"Index Father: {IndexFather}");
            sb.AppendLine($"Gender: {Gender}");
            return sb.ToString();
        }

    }

}
