using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF8_Memory_Reader
{
    public class FFVIIIDrawPoint
    {
        //Bytelength for draw points is always 1 byte.
        public int locationId { get; set; }
        public int spellId { get; set; }
        public int memoryOffset { get; set; }
        
        //Whether it's the 1st-4th drawpoint at this address
        public int pointNumber { get; set; }
    }
}
