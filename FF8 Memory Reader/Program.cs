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
        public static bool inBattle = false;
        
		public static void Main(string[] args)
		{
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
		static void GetValues (Object o)
		{

			Dictionary<int, Dictionary<int, string>> values = new Dictionary<int, Dictionary<int, string>>();
			
			List<FF8Address> addresses = new List<FF8Address>();
			
			addresses.Add(new FF8Address {AddressOffset=0x18FF848, ByteLength=4, Description="In Battle"});
			addresses.Add(new FF8Address {AddressOffset=0x1927D98, ByteLength=4, Description="Enemy 1 HP", Battle=true});
			addresses.Add(new FF8Address {AddressOffset=0x1927E68, ByteLength=4, Description="Enemy 2 HP", Battle=true});
			addresses.Add(new FF8Address {AddressOffset=0x1927F38, ByteLength=4, Description="Enemy 3 HP", Battle=true});
			addresses.Add(new FF8Address {AddressOffset=0x1928008, ByteLength=4, Description="Enemy 4 HP", Battle=true});
			addresses.Add(new FF8Address {AddressOffset=0x18FF5C0, ByteLength=2, Description="AP to Earn", Battle=true});
			addresses.Add(new FF8Address {AddressOffset=0x18FF574, ByteLength=2, Description="XP to Earn", Battle=true});
			
			//Non Battle
			addresses.Add(new FF8Address {AddressOffset=0x18FE9C8, ByteLength=2, Description="SeeD Pts.", Battle=false});
			addresses.Add(new FF8Address {AddressOffset=0x18FE764, ByteLength=4, Description="Gil", Battle=false});
			addresses.Add(new FF8Address {AddressOffset=0x18FE9CC, ByteLength=2, Description="Battles Won", Battle=false});
			addresses.Add(new FF8Address {AddressOffset=0x18FE9D2, ByteLength=2, Description="Escaped", Battle=false});
			addresses.Add(new FF8Address {AddressOffset=0x18FE928, ByteLength=4, Description="Play Time", Battle=false});
			
			
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
	            
	            foreach (FF8Address offset in addresses)
	            {
					IntPtr readAddress = IntPtr.Add(ProcessBaseAddress, offset.AddressOffset);
		            var mem = reader.ReadProcessMemory(readAddress, offset.ByteLength, out bytesReadSize);
		            
		            int i = 0;
		            
		            if(offset.ByteLength == 4) {
		            	i = BitConverter.ToInt32(mem, 0);
		            } else if(offset.ByteLength == 2) {
			            i = BitConverter.ToInt16(mem, 0);
		            }
		            
		            string output = i.ToString();
		            
					//Play Time
		            if(offset.AddressOffset == 0x18FE928) {
						TimeSpan t = TimeSpan.FromSeconds( i );
						
						output = string.Format("{0:D2}:{1:D2}", 
						                t.Hours, 
						                t.Minutes);
		            }
		            
		            //Battle. In its own clause because it should always be visible.
		            if(offset.AddressOffset == 0x18FF848)
		            {
		            	inBattle = (i == 1);
		            }
	            	if(inBattle == offset.Battle) {
	            		modify_file(offset.Description, output);
	            	} else {
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
            
            if(includeFNameInBody) {
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
    class FF8Address
    {
        public int AddressOffset { get; set; }
        public uint ByteLength { get; set; }
        public string Description { get; set; }
        public bool Battle { get; set; }
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