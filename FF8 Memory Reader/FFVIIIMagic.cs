using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF8_Memory_Reader
{
    public class FFVIIIMagic
    {
        private Dictionary<int, string> magicList { get; }

        public FFVIIIMagic()
        {
            magicList = new Dictionary<int, string>();

            magicList.Add(1, "Fire");
            magicList.Add(2, "Fira");
            magicList.Add(3, "Firaga");
            magicList.Add(4, "Blizzard");
            magicList.Add(5, "Blizzara");
            magicList.Add(6, "Blizzaga");
            magicList.Add(7, "Thunder");
            magicList.Add(8, "Thundara");
            magicList.Add(9, "Thundaga");
            magicList.Add(10, "Water");
            magicList.Add(11, "Aero");
            magicList.Add(12, "Bio");
            magicList.Add(13, "Demi");
            magicList.Add(14, "Holy");
            magicList.Add(15, "Flare");
            magicList.Add(16, "Meteor");
            magicList.Add(17, "Quake");
            magicList.Add(18, "Tornado");
            magicList.Add(19, "Ultima");
            magicList.Add(20, "Apocalypse");
            magicList.Add(21, "Cure");
            magicList.Add(22, "Cura");
            magicList.Add(23, "Curaga");
            magicList.Add(24, "Life");
            magicList.Add(25, "Full-life");
            magicList.Add(26, "Regen");
            magicList.Add(27, "Esuna");
            magicList.Add(28, "Dispel");
            magicList.Add(29, "Protect");
            magicList.Add(30, "Shell");
            magicList.Add(31, "Reflect");
            magicList.Add(32, "Aura");
            magicList.Add(33, "Double");
            magicList.Add(34, "Triple");
            magicList.Add(35, "Haste");
            magicList.Add(36, "Slow");
            magicList.Add(37, "Stop");
            magicList.Add(38, "Blind");
            magicList.Add(39, "Confuse");
            magicList.Add(40, "Sleep");
            magicList.Add(41, "Silence");
            magicList.Add(42, "Break");
            magicList.Add(43, "Death");
            magicList.Add(44, "Drain");
            magicList.Add(45, "Pain");
            magicList.Add(46, "Berserk");
            magicList.Add(47, "Float");
            magicList.Add(48, "Zombie");
            magicList.Add(49, "Meltdown");
            magicList.Add(50, "Scan");
            magicList.Add(51, "Full-Cure");
            magicList.Add(52, "Wall");
            magicList.Add(53, "Rapture");
            magicList.Add(54, "Percent (unused)");
            magicList.Add(55, "Catastrophe (unused)");
            magicList.Add(56, "The End");

            //The following are enemy GF draw IDs.
            //Used when a GF is drawable from a boss, etc.
            //Draw will fail if we already have the GF so 
            //this is probably safe to modify.
            magicList.Add(64, "Quezacotl");
            magicList.Add(65, "Shiva");
            magicList.Add(66, "Ifrit");
            magicList.Add(67, "Siren");
            magicList.Add(68, "Brothers");
            magicList.Add(69, "Diablos");
            magicList.Add(70, "Carbuncle");
            magicList.Add(71, "Leviathan");
            magicList.Add(72, "Pandemona");
            magicList.Add(73, "Cerberus");
            magicList.Add(74, "Alexander");
            magicList.Add(75, "Doomtrain");
            magicList.Add(76, "Bahamut");
            magicList.Add(77, "Cactuar");
            magicList.Add(78, "Tonberry");
            magicList.Add(79, "Eden");

        }

        public string getSpell(int spellId)
        {
            if (magicList.ContainsKey(spellId))
            {
                return magicList[spellId];
            }
            return "???";
        }
    }
}
