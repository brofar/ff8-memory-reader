using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF8_Memory_Reader
{
    public class FFVIIIComponent
    {
        public int AddressOffset { get; set; }
        public uint ByteLength { get; set; }
        public string Description { get; set; }
        public string Show { get; set; } //Always / InBattle / InField / InCardGame
    }
}
