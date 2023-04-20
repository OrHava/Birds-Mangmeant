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
	}
}
