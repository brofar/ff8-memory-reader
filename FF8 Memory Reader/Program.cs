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

namespace FF8_Memory_Reader
{
    class Program
    {
        public static List<FFVIIIComponent> addresses = new List<FFVIIIComponent>();

        public static bool inBattle = false;

        public static void Main(string[] args)
        {
            Timer t = new Timer(GetValues, null, 0, 500);

            // loop here forever
            ConsoleSpinner spin = new ConsoleSpinner();
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

            try
            {
                mainModule = MyProcess[0].MainModule;
                ProcessBaseAddress = mainModule.BaseAddress;
                reader.ReadProcess = MyProcess[0];
                reader.OpenProcess();

                //Console.WriteLine("Found Process");

                var a = new FFVIIIMemoryAddresses(ProcessBaseAddress, ref reader);

                Dictionary<string, int> gamestate = a.GetGameState();

                if(gamestate["InTriad"] == 1) //Playing Triple Triad
                {
                    a.GetCardGameValues();
                } 
                else if (gamestate["InBattle"] == 1) //In Fight
                {
                    a.GetBattleValues();
                } 
                else //In field
                {
                    a.GetFieldValues();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Waiting for FF8 to start.", "Error: 120");
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        /*
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
        }*/
    }

    public class ConsoleSpinner
    {
        int counter;
        public ConsoleSpinner()
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