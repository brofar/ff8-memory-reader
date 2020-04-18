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

        public int CardRegion(int locationNum)
        {
           /* Card regions
            * 0 - Unknown
            * 1 - Balamb
            * 2 - Galbadia
            * 3 - Trabia
            * 4 - Centra
            * 5 - Dollet
            * 6 - FH Rules
            * 7 - Space
            * 8 - Esthar
            */

            switch (locationNum)
            {
                case 1:
                case 2:
                case 4:
                case 88:
                case 3:
                case 86:
                case 83:
                case 85:
                case 87:
                case 84:
                case 69:
                case 76:
                case 67:
                case 66:
                case 82:
                case 72:
                case 73:
                case 65:
                case 70:
                case 80:
                case 74:
                case 71:
                case 64:
                case 81:
                case 68:
                case 75:
                case 77:
                case 79:
                case 78:
                case 92:
                    return 1;
                    break;
                case 126:
                case 127:
                case 129:
                case 131:
                case 132:
                case 130:
                case 133:
                case 134:
                case 128:
                case 136:
                case 23:
                case 18:
                case 16:
                case 15:
                case 22:
                case 21:
                case 135:
                case 137:
                case 122:
                case 121:
                case 124:
                case 116:
                case 117:
                case 118:
                case 119:
                case 111:
                case 125:
                case 113:
                case 114:
                case 120:
                case 115:
                case 123:
                case 112:
                case 101:
                case 109:
                case 103:
                case 8:
                case 6:
                case 9:
                case 7:
                case 107:
                case 5:
                case 17:
                case 106:
                case 108:
                case 10:
                case 110:
                case 105:
                case 104:
                case 102:
                case 145:
                case 144:
                case 143:
                case 25:
                case 141:
                case 142:
                case 140:
                case 24:
                case 139:
                case 138:
                    return 2;
                    break;
                case 196:
                case 197:
                case 198:
                case 203:
                case 200:
                case 201:
                case 202:
                case 199:
                case 195:
                case 191:
                case 194:
                case 193:
                case 192:
                case 31:
                case 32:
                case 28:
                case 30:
                case 35:
                case 27:
                case 33:
                case 36:
                case 37:
                case 26:
                case 204:
                case 190:
                    return 3;
                    break;
                case 55:
                case 59:
                case 57:
                case 62:
                case 182:
                case 56:
                case 54:
                case 61:
                case 63:
                case 60:
                case 58:
                case 189:
                case 183:
                case 186:
                case 185:
                case 188:
                case 187:
                case 184:
                    return 4;
                    break;
                case 99:
                case 11:
                case 12:
                case 94:
                case 13:
                case 14:
                case 100:
                case 98:
                case 93:
                case 95:
                case 97:
                case 96:
                    return 5;
                    break;
                case 150:
                case 151:
                case 157:
                case 155:
                case 152:
                case 149:
                case 158:
                case 153:
                case 147:
                case 156:
                case 154:
                case 148:
                case 146:
                    return 6;
                    break;
                case 219:
                case 222:
                case 224:
                case 220:
                case 223:
                case 221:
                case 225:
                case 170:
                case 171:
                case 172:
                case 226:
                    return 7;
                    break;
                case 168:
                case 167:
                case 179:
                case 48:
                case 161:
                case 159:
                case 40:
                case 41:
                case 45:
                case 50:
                case 42:
                case 49:
                case 38:
                case 39:
                case 160:
                case 163:
                case 53:
                case 47:
                case 52:
                case 46:
                case 44:
                case 173:
                case 43:
                case 20:
                case 91:
                case 181:
                case 162:
                case 178:
                case 164:
                case 165:
                case 166:
                case 176:
                case 174:
                case 175:
                case 180:
                case 177:
                case 205:
                case 206:
                case 207:
                    return 8;
                    break;
                default:
                    //we don't know.
                    return 0;
            }
        }

    }
}
