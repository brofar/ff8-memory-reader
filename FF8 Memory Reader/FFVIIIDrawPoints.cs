using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF8_Memory_Reader
{
    public class FFVIIIDrawPoints
    {

        //THIS WILL FAIL AS IS. There are multiple entries with identical keys. Need to find ram addresses for each of these as the source of uniqueness.

        //Background info for memory things:
        //Each draw point byte in the game's memory contains information for FOUR draw points.
        //Essentially the formula is SUM(i x status) from i=1 to i=4
        //          Full    Half    Empty   Exhausted
        //1st point: +0     +1      +2      +3
        //2nd point: +0     +4      +8      +12
        //3rd point: +0     +16     +32     +48
        //4th point: +0     +64     +128    +192

        //Dictionary<Location ID, Magic ID>
        //Location of -1 = nowhere/unused.
        private List<FFVIIIDrawPoint> drawPointList = new List<FFVIIIDrawPoint>();
        public Dictionary<int, string> drawPointStatus { get; }

        public FFVIIIDrawPoints()
        {
            PopulateDrawPointList();
            PopulateDrawPointStatuses();
        }
        private void PopulateDrawPointStatuses()
        {
            drawPointStatus.Add(0, "Filled");
            drawPointStatus.Add(1, "Half Filled");
            drawPointStatus.Add(2, "Empty");
            drawPointStatus.Add(3, "Exhausted");
        }
        private void PopulateDrawPointList()
        {
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 65,  spellId = 21, memoryOffset = 0x18FEA2C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 78,  spellId = 4,  memoryOffset = 0x18FEA2C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 68,  spellId = 25, memoryOffset = 0x18FEA2C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 64,  spellId = 27, memoryOffset = 0x18FEA2C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 67,  spellId = 13, memoryOffset = 0x18FEA2D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 81,  spellId = 12, memoryOffset = 0x18FEA2D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 85,  spellId = 7,  memoryOffset = 0x18FEA2D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 87,  spellId = 21, memoryOffset = 0x18FEA2D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 92,  spellId = 1,  memoryOffset = 0x18FEA2E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 93,  spellId = 41, memoryOffset = 0x18FEA2E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 99,  spellId = 38, memoryOffset = 0x18FEA2E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 101, spellId = 50, memoryOffset = 0x18FEA2E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 101, spellId = 21, memoryOffset = 0x18FEA2F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 109, spellId = 6,  memoryOffset = 0x18FEA2F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 113, spellId = 35, memoryOffset = 0x18FEA2F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 117, spellId = 24, memoryOffset = 0x18FEA2F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 122, spellId = 30, memoryOffset = 0x18FEA30 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 125, spellId = 29, memoryOffset = 0x18FEA30 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 121, spellId = 33, memoryOffset = 0x18FEA30 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 124, spellId = 32, memoryOffset = 0x18FEA30 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 110, spellId = 21, memoryOffset = 0x18FEA31 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 110, spellId = 10, memoryOffset = 0x18FEA31 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 129, spellId = 8,  memoryOffset = 0x18FEA31 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 134, spellId = 48, memoryOffset = 0x18FEA31 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 134, spellId = 27, memoryOffset = 0x18FEA32 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 134, spellId = 12, memoryOffset = 0x18FEA32 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 2,  memoryOffset = 0x18FEA32 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 135, spellId = 46, memoryOffset = 0x18FEA32 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 135, spellId = 9,  memoryOffset = 0x18FEA33 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 136, spellId = 11, memoryOffset = 0x18FEA33 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 137, spellId = 5,  memoryOffset = 0x18FEA33 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 137, spellId = 38, memoryOffset = 0x18FEA33 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 137, spellId = 25, memoryOffset = 0x18FEA34 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 138, spellId = 44, memoryOffset = 0x18FEA34 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 138, spellId = 28, memoryOffset = 0x18FEA34 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 140, spellId = 23, memoryOffset = 0x18FEA34 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 138, spellId = 31, memoryOffset = 0x18FEA35 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 145, spellId = 29, memoryOffset = 0x18FEA35 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 145, spellId = 47, memoryOffset = 0x18FEA35 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 145, spellId = 22, memoryOffset = 0x18FEA35 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 154, spellId = 35, memoryOffset = 0x18FEA36 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 147, spellId = 30, memoryOffset = 0x18FEA36 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 146, spellId = 26, memoryOffset = 0x18FEA36 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 150, spellId = 25, memoryOffset = 0x18FEA36 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 149, spellId = 19, memoryOffset = 0x18FEA37 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 157, spellId = 9,  memoryOffset = 0x18FEA37 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 157, spellId = 16, memoryOffset = 0x18FEA37 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 159, spellId = 23, memoryOffset = 0x18FEA37 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 159, spellId = 4,  memoryOffset = 0x18FEA38 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 160, spellId = 17, memoryOffset = 0x18FEA38 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 159, spellId = 18, memoryOffset = 0x18FEA38 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 167, spellId = 33, memoryOffset = 0x18FEA38 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 45, memoryOffset = 0x18FEA39 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 167, spellId = 15, memoryOffset = 0x18FEA39 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 173, spellId = 37, memoryOffset = 0x18FEA39 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 37, memoryOffset = 0x18FEA39 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 177, spellId = 24, memoryOffset = 0x18FEA3A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 177, spellId = 31, memoryOffset = 0x18FEA3A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 178, spellId = 43, memoryOffset = 0x18FEA3A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 182, spellId = 14, memoryOffset = 0x18FEA3A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 182, spellId = 41, memoryOffset = 0x18FEA3B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 182, spellId = 19, memoryOffset = 0x18FEA3B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 182, spellId = 39, memoryOffset = 0x18FEA3B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 181, spellId = 42, memoryOffset = 0x18FEA3B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 181, spellId = 16, memoryOffset = 0x18FEA3C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 181, spellId = 23, memoryOffset = 0x18FEA3C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 36, memoryOffset = 0x18FEA3C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 185, spellId = 23, memoryOffset = 0x18FEA3C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 15, memoryOffset = 0x18FEA3D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 14, memoryOffset = 0x18FEA3D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 182, spellId = 40, memoryOffset = 0x18FEA3D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 182, spellId = 39, memoryOffset = 0x18FEA3D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 189, spellId = 11, memoryOffset = 0x18FEA3E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 189, spellId = 44, memoryOffset = 0x18FEA3E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 189, spellId = 45, memoryOffset = 0x18FEA3E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 190, spellId = 9,  memoryOffset = 0x18FEA3E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 191, spellId = 48, memoryOffset = 0x18FEA3F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 193, spellId = 32, memoryOffset = 0x18FEA3F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 197, spellId = 19, memoryOffset = 0x18FEA3F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 199, spellId = 6,  memoryOffset = 0x18FEA3F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 201, spellId = 3,  memoryOffset = 0x18FEA40 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 18, memoryOffset = 0x18FEA40 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 207, spellId = 14, memoryOffset = 0x18FEA40 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 210, spellId = 22, memoryOffset = 0x18FEA40 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 210, spellId = 24, memoryOffset = 0x18FEA41 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 211, spellId = 25, memoryOffset = 0x18FEA41 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 217, spellId = 28, memoryOffset = 0x18FEA41 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 217, spellId = 27, memoryOffset = 0x18FEA41 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 218, spellId = 34, memoryOffset = 0x18FEA42 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 218, spellId = 19, memoryOffset = 0x18FEA42 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 221, spellId = 49, memoryOffset = 0x18FEA42 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 225, spellId = 16, memoryOffset = 0x18FEA42 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 35, memoryOffset = 0x18FEA43 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 36, memoryOffset = 0x18FEA43 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 23, memoryOffset = 0x18FEA43 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 24, memoryOffset = 0x18FEA43 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 37, memoryOffset = 0x18FEA44 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 26, memoryOffset = 0x18FEA44 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 33, memoryOffset = 0x18FEA44 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 228, spellId = 34, memoryOffset = 0x18FEA44 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 248, spellId = 15, memoryOffset = 0x18FEA45 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 237, spellId = 23, memoryOffset = 0x18FEA45 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 233, spellId = 22, memoryOffset = 0x18FEA45 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 50, memoryOffset = 0x18FEA45 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 27, memoryOffset = 0x18FEA46 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 243, spellId = 36, memoryOffset = 0x18FEA46 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 244, spellId = 28, memoryOffset = 0x18FEA46 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 245, spellId = 37, memoryOffset = 0x18FEA46 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 246, spellId = 24, memoryOffset = 0x18FEA47 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 15, memoryOffset = 0x18FEA47 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 232, spellId = 32, memoryOffset = 0x18FEA47 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 236, spellId = 14, memoryOffset = 0x18FEA47 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 231, spellId = 16, memoryOffset = 0x18FEA48 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 238, spellId = 49, memoryOffset = 0x18FEA48 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 240, spellId = 19, memoryOffset = 0x18FEA48 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 241, spellId = 25, memoryOffset = 0x18FEA48 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 245, spellId = 34, memoryOffset = 0x18FEA49 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA49 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA49 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA49 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 1,   spellId = 21, memoryOffset = 0x18FEA4C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 1,   spellId = 27, memoryOffset = 0x18FEA4C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 6,   spellId = 7,  memoryOffset = 0x18FEA4C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 8,   spellId = 2,  memoryOffset = 0x18FEA4C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 17,  spellId = 8,  memoryOffset = 0x18FEA4D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 5,  memoryOffset = 0x18FEA4D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 10,  spellId = 4,  memoryOffset = 0x18FEA4D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 1,  memoryOffset = 0x18FEA4D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 11,  spellId = 21, memoryOffset = 0x18FEA4E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 14,  spellId = 10, memoryOffset = 0x18FEA4E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 11,  spellId = 22, memoryOffset = 0x18FEA4E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 20,  spellId = 27, memoryOffset = 0x18FEA4E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 21,  spellId = 50, memoryOffset = 0x18FEA4F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 30, memoryOffset = 0x18FEA4F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 23,  spellId = 35, memoryOffset = 0x18FEA4F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 11, memoryOffset = 0x18FEA4F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 12, memoryOffset = 0x18FEA50 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 24,  spellId = 24, memoryOffset = 0x18FEA50 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 62,  spellId = 13, memoryOffset = 0x18FEA50 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 61,  spellId = 29, memoryOffset = 0x18FEA50 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 57,  spellId = 14, memoryOffset = 0x18FEA51 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 55,  spellId = 9,  memoryOffset = 0x18FEA51 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 53,  spellId = 37, memoryOffset = 0x18FEA51 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 50,  spellId = 3,  memoryOffset = 0x18FEA51 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 26,  spellId = 26, memoryOffset = 0x18FEA52 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 26,  spellId = 6,  memoryOffset = 0x18FEA52 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 30,  spellId = 39, memoryOffset = 0x18FEA52 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 32,  spellId = 15, memoryOffset = 0x18FEA52 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 32,  spellId = 28, memoryOffset = 0x18FEA53 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 32,  spellId = 36, memoryOffset = 0x18FEA53 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 37,  spellId = 17, memoryOffset = 0x18FEA53 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 46,  spellId = 23, memoryOffset = 0x18FEA53 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 39,  spellId = 18, memoryOffset = 0x18FEA54 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 39,  spellId = 25, memoryOffset = 0x18FEA54 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 25,  spellId = 31, memoryOffset = 0x18FEA54 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 13,  spellId = 32, memoryOffset = 0x18FEA54 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 12,  spellId = 17, memoryOffset = 0x18FEA55 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 33, memoryOffset = 0x18FEA55 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 17,  spellId = 42, memoryOffset = 0x18FEA55 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 41,  spellId = 16, memoryOffset = 0x18FEA55 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 41,  spellId = 19, memoryOffset = 0x18FEA56 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 41,  spellId = 34, memoryOffset = 0x18FEA56 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 42,  spellId = 39, memoryOffset = 0x18FEA56 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 41,  spellId = 38, memoryOffset = 0x18FEA56 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 26,  spellId = 17, memoryOffset = 0x18FEA57 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 26,  spellId = 40, memoryOffset = 0x18FEA57 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 26,  spellId = 41, memoryOffset = 0x18FEA57 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 32,  spellId = 15, memoryOffset = 0x18FEA57 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 31,  spellId = 43, memoryOffset = 0x18FEA58 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 12,  spellId = 44, memoryOffset = 0x18FEA58 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 11,  spellId = 45, memoryOffset = 0x18FEA58 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 46, memoryOffset = 0x18FEA58 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 21,  spellId = 47, memoryOffset = 0x18FEA59 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 22,  spellId = 48, memoryOffset = 0x18FEA59 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 49, memoryOffset = 0x18FEA59 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 16,  spellId = 48, memoryOffset = 0x18FEA59 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 18, memoryOffset = 0x18FEA5A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 17, memoryOffset = 0x18FEA5A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 16, memoryOffset = 0x18FEA5A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 14, memoryOffset = 0x18FEA5A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 15, memoryOffset = 0x18FEA5B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 32, memoryOffset = 0x18FEA5B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 19, memoryOffset = 0x18FEA5B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 34, memoryOffset = 0x18FEA5B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 24, memoryOffset = 0x18FEA5C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 18, memoryOffset = 0x18FEA5C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 17, memoryOffset = 0x18FEA5C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 16, memoryOffset = 0x18FEA5C });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 14, memoryOffset = 0x18FEA5D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 15, memoryOffset = 0x18FEA5D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 32, memoryOffset = 0x18FEA5D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 19, memoryOffset = 0x18FEA5D });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 34, memoryOffset = 0x18FEA5E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 24, memoryOffset = 0x18FEA5E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 18, memoryOffset = 0x18FEA5E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 17, memoryOffset = 0x18FEA5E });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 16, memoryOffset = 0x18FEA5F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 14, memoryOffset = 0x18FEA5F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 15, memoryOffset = 0x18FEA5F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 32, memoryOffset = 0x18FEA5F });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 19, memoryOffset = 0x18FEA60 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 34, memoryOffset = 0x18FEA60 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 24, memoryOffset = 0x18FEA60 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 51,  spellId = 19, memoryOffset = 0x18FEA60 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 16, memoryOffset = 0x18FEA61 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 14, memoryOffset = 0x18FEA61 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 15, memoryOffset = 0x18FEA61 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 32, memoryOffset = 0x18FEA61 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 19, memoryOffset = 0x18FEA62 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 34, memoryOffset = 0x18FEA62 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 24, memoryOffset = 0x18FEA62 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 16, memoryOffset = 0x18FEA62 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 14, memoryOffset = 0x18FEA63 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 34, memoryOffset = 0x18FEA63 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 32, memoryOffset = 0x18FEA63 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 19, memoryOffset = 0x18FEA63 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 34, memoryOffset = 0x18FEA64 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 24, memoryOffset = 0x18FEA64 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 16, memoryOffset = 0x18FEA64 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 14, memoryOffset = 0x18FEA64 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 15, memoryOffset = 0x18FEA65 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 32, memoryOffset = 0x18FEA65 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 19, memoryOffset = 0x18FEA65 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 34, memoryOffset = 0x18FEA65 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 24, memoryOffset = 0x18FEA66 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 16, memoryOffset = 0x18FEA66 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 34, memoryOffset = 0x18FEA66 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 15, memoryOffset = 0x18FEA66 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 32, memoryOffset = 0x18FEA67 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 19, memoryOffset = 0x18FEA67 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 34, memoryOffset = 0x18FEA67 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 24, memoryOffset = 0x18FEA67 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 16, memoryOffset = 0x18FEA68 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 14, memoryOffset = 0x18FEA68 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 15, memoryOffset = 0x18FEA68 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 32, memoryOffset = 0x18FEA68 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 19,  spellId = 19, memoryOffset = 0x18FEA69 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 1,   spellId = 4,  memoryOffset = 0x18FEA69 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 1,   spellId = 21, memoryOffset = 0x18FEA69 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 15,  spellId = 28, memoryOffset = 0x18FEA69 });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 20,  spellId = 39, memoryOffset = 0x18FEA6A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 43,  spellId = 16, memoryOffset = 0x18FEA6A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 43,  spellId = 33, memoryOffset = 0x18FEA6A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 43,  spellId = 33, memoryOffset = 0x18FEA6A });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 43,  spellId = 14, memoryOffset = 0x18FEA6B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 47,  spellId = 15, memoryOffset = 0x18FEA6B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = 48,  spellId = 19, memoryOffset = 0x18FEA6B });
            drawPointList.Add(new FFVIIIDrawPoint { locationId = -1,  spellId = 50, memoryOffset = 0x18FEA6B });

        }
        public string GetDrawPoint(int locationId)
        {
            //TODO
        }
    }
}
