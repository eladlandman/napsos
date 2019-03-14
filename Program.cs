using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp9
{
    partial class Program
    {
        static void Main(string[] args)
        {


            string folder = args.Length == 0 ? Environment.CurrentDirectory : args[0];

            FolderManage dict = new FolderManage(Directory.GetCurrentDirectory());
            dict.NotifyFileProcessInfoEvent += Dict_threadInfo;
            long size1 = dict.GetSizeByThreads();
            long size2 = dict.GetSizeByThreads();
            long size3 = dict.GetSizeByThreads();
            long size4 = dict.GetSizeByThreads();
            Console.WriteLine($"Our final  results are :{size1},{size2},{size3},{size4}");
      
        


            
            RaiseEvents rs = new RaiseEvents(1000);
            rs.Tick += Rs_Tick;
            rs.StartingByThread();
            Thread.Sleep(3000);
            rs.Stop();
            


            Console.ReadLine();


        }
        private static void Dict_threadInfo(object sender, FileProcessInfoArgs e)
        { 
                Console.WriteLine($"Thread {e.ThreadNum} read file {e.FilePath}.Size={e.SizeOfFile}");
            
            
        }

        private static void Rs_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("hello elad");
        }
    }
}
