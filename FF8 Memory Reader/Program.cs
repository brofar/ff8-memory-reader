/*
 * Created by SharpDevelop.
 * User: Behrawr
 * Date: 3/25/2020
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using ProcessMemoryReaderLib;
using System.Threading;
using System.IO;

namespace FF8_Memory_Reader
{
    class Program
    {
        public static string PATH = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
        public static List<FFVIIIComponent> addresses = new List<FFVIIIComponent>();

        public static bool inBattle = false;

        public static void Main(string[] args)
        {
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FF848, ByteLength = 4, Description = "In Battle" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927D98, ByteLength = 4, Description = "Enemy 1 HP", Show = "InBattle" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927E68, ByteLength = 4, Description = "Enemy 2 HP", Show = "InBattle" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927F38, ByteLength = 4, Description = "Enemy 3 HP", Show = "InBattle" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1928008, ByteLength = 4, Description = "Enemy 4 HP", Show = "InBattle" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FF5C0, ByteLength = 2, Description = "AP to Earn", Show = "InBattle" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FF574, ByteLength = 2, Description = "XP to Earn", Show = "InBattle" });

            //Non Battle
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE9C8, ByteLength = 2, Description = "SeeD Pts.", Show = "InField" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE764, ByteLength = 4, Description = "Gil", Show = "InField" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE9CC, ByteLength = 2, Description = "Battles Won", Show = "InField" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE9D2, ByteLength = 2, Description = "Escaped", Show = "InField" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE928, ByteLength = 4, Description = "Play Time", Show = "InField" });

            Timer t = new Timer(GetValues, null, 0, 500);

            // loop here forever
            ConsoleSpiner spin = new ConsoleSpiner();
            Console.Write("FF8 Memory Reader Working...");
            while (true)
            {
                spin.Turn();

                // add a sleep for 100 mSec to reduce CPU usage
                Thread.Sleep(100);
            }
        }
        static void GetValues(Object o)
        {

            Dictionary<int, Dictionary<int, string>> values = new Dictionary<int, Dictionary<int, string>>();

            ProcessMemoryReader reader = new ProcessMemoryReader();
            Process[] MyProcess = Process.GetProcessesByName("FF8_EN");

            ProcessModule mainModule;
            IntPtr ProcessBaseAddress;
            int bytesReadSize;

            try
            {
                mainModule = MyProcess[0].MainModule;
                ProcessBaseAddress = mainModule.BaseAddress;
                reader.ReadProcess = MyProcess[0];
                reader.OpenProcess();

                foreach (FFVIIIComponent offset in addresses)
                {
                    IntPtr readAddress = IntPtr.Add(ProcessBaseAddress, offset.AddressOffset);
                    var mem = reader.ReadProcessMemory(readAddress, offset.ByteLength, out bytesReadSize);

                    int i = 0;

                    if (offset.ByteLength == 4)
                    {
                        i = BitConverter.ToInt32(mem, 0);
                    }
                    else if (offset.ByteLength == 2)
                    {
                        i = BitConverter.ToInt16(mem, 0);
                    }

                    string output = i.ToString();

                    //Play Time
                    if (offset.AddressOffset == 0x18FE928)
                    {
                        TimeSpan t = TimeSpan.FromSeconds(i);

                        output = string.Format("{0:D2}:{1:D2}",
                                        t.Hours,
                                        t.Minutes);
                    }

                    //Battle. In its own clause because it should always be visible.
                    if (offset.AddressOffset == 0x18FF848)
                    {
                        inBattle = (i == 1);
                    }
                    if (inBattle == offset.InBattle)
                    {
                        modify_file(offset.Description, output);
                    }
                    else
                    {
                        modify_file(offset.Description, "", false);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Start FF8 before running this application.", "Error: 120");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
        static void modify_file(string fname, string file_content, bool includeFNameInBody = true)
        {
            string fileName = fname + ".txt";
            string filePath = PATH + @"\output\" + fileName;
            string localPath = new Uri(filePath).LocalPath;

            if (includeFNameInBody)
            {
                file_content = fname + '\n' + file_content;
            }

            File.WriteAllText(localPath, file_content);
        }
        static string read_file(string filename)
        {
            string fileName = filename + ".txt";
            string filePath = PATH + @"\output\" + fileName;
            string localPath = new Uri(filePath).LocalPath;
            return File.ReadAllText(localPath);
        }
    }

    public class ConsoleSpiner
    {
        int counter;
        public ConsoleSpiner()
        {
            counter = 0;
        }
        public void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}