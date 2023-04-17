using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Mangmeant
{
    internal class Cage
    {
        public string IndexNumber { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public enum Material { Iron, Wood, Plastic } // Not sure we need to check if its work
        public List<Bird> Birds { get; set; }
    }
}
