using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF8_Memory_Reader
{
    public class FFVIIITripleTriad
    {
        //Background info for memory things:
        //The card rules for a specific region use bit masking (I think that's what it's called)
        //In other words, each byte in the address represents whether that specific rule is on or off.
        // +1 open
        // +2 same
        // +4 plus
        // +8 random
        // +16 sudden death
        // +32 Retry (unused)
        // +64 Same Wall
        // +128 Elemental
        //e.g. 3 = open(1) + same(2); 77 = open(1) + plus(4) + random(8) + same wall(64); etc.
        //There's no value for Combo. Any time Same or Plus is active, Combo is also automatically active.
        [Flags]
        public enum Rules
        {
            Open = 1,
            Same = 2,
            Plus = 4,
            Random = 8,
            SuddenDeath = 16,
            Retry = 32,
            SameWall = 64,
            Elemental = 128
        }

        private static readonly IEnumerable<Rules> ruleCache = Enum.GetValues(typeof(Rules)).Cast<Rules>();

        public List<Rules> GetRules(int ruleByte)
        {
            Rules ruleSet = (Rules)ruleByte;
            return ruleCache.Where(value => ruleSet.HasFlag(value)).ToList();
        }
        public string GetTradeRule(int ruleByte)
        {
            switch (ruleByte)
            {
                case 1:
                    return "One";
                case 2:
                    return "Diff";
                case 3:
                    return "Direct";
                case 4:
                    return "All";
                case 6:
                    return "Used Up (unused)";
                default:
                    return "???";
            }
        }

    }
}
