﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcessMemoryReaderLib;
using System.IO;

namespace FF8_Memory_Reader
{
    class FFVIIIMemoryAddresses
    {
        //Contants
        public static string PATH = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
        private IntPtr ProcessBaseAddress;
        private ProcessMemoryReader reader;


        public FFVIIIMemoryAddresses(IntPtr ProcessAddress, ref ProcessMemoryReader MemReader)
        {
            ProcessBaseAddress = ProcessAddress;
            reader = MemReader;
        }
        
        public Dictionary<string, int> GetGameState()
        {
            var gameState = new Dictionary<string, int>();

            //In battle
            var InBattle = new FFVIIIComponent { AddressOffset = 0x18FF848, ByteLength = 4, Description = "Battle - In Battle" };

            gameState.Add("InBattle", ReadMemoryAddress(InBattle.AddressOffset, InBattle.ByteLength));

            //Flag to tell us if we're in a card game
            var InTriad = new FFVIIIComponent { AddressOffset = 0x19CD798, ByteLength = 1, Description = "Triple Triad - In Game" };

            gameState.Add("InTriad", ReadMemoryAddress(InTriad.AddressOffset, InTriad.ByteLength));

            return gameState;
        }

        //Change void to something relevant once I figure out what it should be.
        public void GetBattleValues()
        {
            var spellList = new FFVIIIMagic();

            List<FFVIIIComponent> addresses = new List<FFVIIIComponent>();
            List<FFVIIIComponent> draws = new List<FFVIIIComponent>();

            //Flag to tell us if we're in a battle


            //HP Values
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927D98, ByteLength = 4, Description = "Battle - Enemy 1 HP" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927E68, ByteLength = 4, Description = "Battle - Enemy 2 HP" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927F38, ByteLength = 4, Description = "Battle - Enemy 3 HP" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1928008, ByteLength = 4, Description = "Battle - Enemy 4 HP" });

            //Post-battle earnings (these are calculated when each enemy dies)
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FF5C0, ByteLength = 2, Description = "Battle - AP to Earn" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FF574, ByteLength = 2, Description = "Battle - XP to Earn" });

            //Enemy Draws. Values correspond to the standard magic list, BUT if the magic is something that is junctioned, then 1024 is added to the value.
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F18, ByteLength = 4, Description = "Battle - Enemy 1 Draw 1" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F1C, ByteLength = 4, Description = "Battle - Enemy 1 Draw 2" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F20, ByteLength = 4, Description = "Battle - Enemy 1 Draw 3" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F24, ByteLength = 4, Description = "Battle - Enemy 1 Draw 4" });
            
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F5F, ByteLength = 4, Description = "Battle - Enemy 2 Draw 1" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F63, ByteLength = 4, Description = "Battle - Enemy 2 Draw 2" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F67, ByteLength = 4, Description = "Battle - Enemy 2 Draw 3" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928F6B, ByteLength = 4, Description = "Battle - Enemy 2 Draw 4" });
            
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FA6, ByteLength = 4, Description = "Battle - Enemy 3 Draw 1" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FAA, ByteLength = 4, Description = "Battle - Enemy 3 Draw 2" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FAE, ByteLength = 4, Description = "Battle - Enemy 3 Draw 3" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FB2, ByteLength = 4, Description = "Battle - Enemy 3 Draw 4" });
            
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FED, ByteLength = 4, Description = "Battle - Enemy 4 Draw 1" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FF1, ByteLength = 4, Description = "Battle - Enemy 4 Draw 2" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FF5, ByteLength = 4, Description = "Battle - Enemy 4 Draw 3" });
            draws.Add(new FFVIIIComponent { AddressOffset = 0x1928FFF, ByteLength = 4, Description = "Battle - Enemy 4 Draw 4" });

            //Each slot is one character in battle
            //ATB: 12000 = Full
            //Convert to percentage?
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927B24, ByteLength = 2, Description = "Battle - Slot 1 ATB" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927B28, ByteLength = 2, Description = "Battle - Slot 1 Current HP" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927B2C, ByteLength = 2, Description = "Battle - Slot 1 Max HP" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927BF4, ByteLength = 2, Description = "Battle - Slot 2 ATB" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927BF8, ByteLength = 2, Description = "Battle - Slot 2 Current HP" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927BFC, ByteLength = 2, Description = "Battle - Slot 2 Max HP" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927CC4, ByteLength = 2, Description = "Battle - Slot 3 ATB" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927CC8, ByteLength = 2, Description = "Battle - Slot 3 Current HP" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x1927CCC, ByteLength = 2, Description = "Battle - Slot 3 Max HP" });

            Dictionary<string, string> battleStats = new Dictionary<string, string>();
            foreach (FFVIIIComponent viiiComponent in addresses)
            {
                int i = ReadMemoryAddress(viiiComponent.AddressOffset, viiiComponent.ByteLength);

                battleStats.Add(viiiComponent.Description, i.ToString());
            }
            foreach (FFVIIIComponent viiiComponent in draws)
            {
                int i = ReadMemoryAddress(viiiComponent.AddressOffset, viiiComponent.ByteLength);
                
                //if a spell is junctioned, the game adds 1024 to the value
                //presumably to add the J sumbol by the spell.
                //so we need to subtract 1024 in these cases to get the name.
                if(i > 1024)
                {
                    i = i - 1024;
                }
                string spellName = spellList.getSpell(i);
                if(spellName != "???")
                {
                    battleStats.Add(viiiComponent.Description, spellName);
                }
            }
            MakeWebpage(battleStats);
        }

        public void GetCardGameValues()
        {
            List<FFVIIIComponent> addresses = new List<FFVIIIComponent>();
            List<FFVIIIComponent> playRules = new List<FFVIIIComponent>();


            //Still need to figure out which maps are which card zones
            var triad = new FFVIIITripleTriad();

            //Play Rules
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEAC8, ByteLength = 1, Description = "Balamb Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEAC9, ByteLength = 1, Description = "Galbadia Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEACA, ByteLength = 1, Description = "Trabia Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEACB, ByteLength = 1, Description = "Centra Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEACC, ByteLength = 1, Description = "Dollet Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEACD, ByteLength = 1, Description = "FH Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEACE, ByteLength = 1, Description = "Space Rules" });
            playRules.Add(new FFVIIIComponent { AddressOffset = 0x18FEACF, ByteLength = 1, Description = "Esthar Rules" });

            //Pull & Process Play Rules
            Dictionary<string, string> cards = new Dictionary<string, string>();
            foreach (FFVIIIComponent viiiComponent in playRules)
            {
                int i = ReadMemoryAddress(viiiComponent.AddressOffset, viiiComponent.ByteLength);

                string ruleSet = String.Join(", ", triad.GetRules(i));
                //Console.WriteLine(viiiComponent.Description + ": " + ruleSet);
                cards.Add(viiiComponent.Description, ruleSet);
            }
            MakeWebpage(cards);

            //Trade Rules
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD0, ByteLength = 1, Description = "Balamb Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD1, ByteLength = 1, Description = "Galbadia Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD2, ByteLength = 1, Description = "Trabia Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD3, ByteLength = 1, Description = "Centra Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD4, ByteLength = 1, Description = "Dollet Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD5, ByteLength = 1, Description = "FH Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD6, ByteLength = 1, Description = "Space Trade Rule" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAD7, ByteLength = 1, Description = "Esthar Trade Rule" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEADA, ByteLength = 1, Description = "Last Region Played" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEADB, ByteLength = 1, Description = "Second Last Region Played" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEFAC, ByteLength = 1, Description = "Total Wins" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEFAE, ByteLength = 1, Description = "Total Losses" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEFB0, ByteLength = 1, Description = "Total Draws" });
        }
        public void GetFieldValues()
        {
            List<FFVIIIComponent> addresses = new List<FFVIIIComponent>();

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE9C8, ByteLength = 2, Description = "Field - SeeD Pts" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE764, ByteLength = 4, Description = "Field - Gil" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE9CC, ByteLength = 2, Description = "Field - Battles Won" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE9D2, ByteLength = 2, Description = "Field - Battles Escaped" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE928, ByteLength = 4, Description = "Field - Play Time" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEAB8, ByteLength = 2, Description = "Field - Story Progress" });

            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18D2FC0, ByteLength = 2, Description = "Field - Current Map" });
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FEA0C, ByteLength = 2, Description = "Field - Last Area" });

            //Centra
            addresses.Add(new FFVIIIComponent { AddressOffset = 0x18FE940, ByteLength = 1, Description = "Tonberry Kills" });

            Dictionary<string, string> fieldStats = new Dictionary<string, string>();
            foreach (FFVIIIComponent viiiComponent in addresses)
            {
                int i = ReadMemoryAddress(viiiComponent.AddressOffset, viiiComponent.ByteLength);

                string output = i.ToString();

                //Play Time
                if (viiiComponent.AddressOffset == 0x18FE928)
                {
                    TimeSpan t = TimeSpan.FromSeconds(i);

                    output = string.Format("{0:D2}:{1:D2}",
                                    t.Hours,
                                    t.Minutes);
                }
                //SeeD Pts
                else if (viiiComponent.AddressOffset == 0x18FE9C8)
                {
                    output = output + "(Lv. " + (i / 100) + ")";
                }

                fieldStats.Add(viiiComponent.Description, output);
            }
            MakeWebpage(fieldStats);
        }

        protected int ByteToInt(byte[] bytes, int size)
        {
            int i = 0;
            try {
                if (size == 4)
                {
                    i = BitConverter.ToInt32(bytes, 0);
                }
                else if (size == 2)
                {
                    i = BitConverter.ToInt16(bytes, 0);
                }
                else if (size == 1)
                {
                    i = bytes[0];
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return i;

        }
        private int ReadMemoryAddress(int offset, uint bytelength)
        {
            int bytesReadSize;

            IntPtr readAddress = IntPtr.Add(ProcessBaseAddress, offset);
            byte[] mem = reader.ReadProcessMemory(readAddress, bytelength, out bytesReadSize);

            int i = ByteToInt(mem, bytesReadSize);

            return i;
        }
        static void MakeWebpage(Dictionary<string,string> dataPoints)
        {
            string fileName = "page.html";
            string filePath = PATH + @"\output\" + fileName;
            string localPath = new Uri(filePath).LocalPath;

            string htmlBody = "";
            foreach (KeyValuePair<string, string> entry in dataPoints)
            {
                htmlBody = String.Concat(htmlBody, "<div class=\"databox\"><strong>", entry.Key, "</strong><br />", entry.Value, "</div>");
            }

            string htmlHeader = @"<!DOCTYPE html><html> <head> <meta charset=""UTF-8""> <title>FF8 Stats</title> <link rel=""stylesheet"" href=""stylesheet.css"" type=""text/css""> <script>setTimeout(function (){location.reload(true);}, 500);</script> </head> <body>";
            string htmlFooter = "</body></html>";

            string html = String.Concat(htmlHeader, htmlBody, htmlFooter);

            File.WriteAllText(localPath, html);
        }
    }
}
