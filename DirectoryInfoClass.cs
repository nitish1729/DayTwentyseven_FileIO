using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_FileIO
{
    public class DirectoryInfoClass
    {
        public void dispaly()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27/My Directory2";
            string path2 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27/My Directory";
            string path3 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27/new\new1";
            DirectoryInfo dir = new DirectoryInfo(path3);
            Console.WriteLine("Directory Name :- {0}",dir.Name);
            Console.WriteLine("Directory FullName :- {0}",dir.FullName);
            Console.WriteLine("Directory LastAccessTime :- {0}",dir.LastAccessTime);
            Console.WriteLine("Directory CreationTime :- {0}", dir.CreationTime);
            Console.WriteLine("Directory ParentName :- {0}", dir.Parent);
            Console.WriteLine("Directory AttributesName :- {0}", dir.Attributes);
            Console.WriteLine("Directory RootName :- {0}", dir.Root);
            
            Console.WriteLine("Nitish Mehta");
            // DirectoryInfo[] dirs = dir.GetDirectories(); // it show the directory path
            // foreach (var iteam in dirs)
            // {
            //    //Console.WriteLine(iteam.FullName);
            //    Console.WriteLine(iteam.GetFiles().Length);
            // }
            // dir.Delete(true);
            // Console.WriteLine("Directory Deleted");
            // dir.MoveTo(path2);
            // Console.WriteLine("Directory Moved");

            // dir.Create();       // To create new directory
            // dir.CreateSubdirectory("New Directory");  // To Create SubDirectory
            //   Console.WriteLine("New Directory Created");

            Console.ReadLine();
        }
    }
}





