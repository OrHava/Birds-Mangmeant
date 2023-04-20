using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Mangmeant
{

    //[JsonObject]
   public  class Bird
	{
		public string?	 IndexNumber { get; set; }
		public string?	 Breed_of_Bird { get; set; }
		public string?	 Subspecies { get; set; }
		public string?	 HatchDate { get; set; }

		public string?	 IndexCage { get; set; }

		public string?	 IndexMother { get; set; }
		public string?	 IndexFather{ get; set; }

		public string?	 Gender { get; set; }
	}
}
