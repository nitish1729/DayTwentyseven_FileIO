using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_FileIO
{
    public class CreateCopyOfFile
    {
        public void CopyFile()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\Addressbook_FileIO\test.txt";
            // copy the text file inside the same folder with different name
            string path1 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\Addressbook_FileIO\test1.txt";
            // To copy the file inside the folder 
            string path2 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\Addressbook_FileIO\Data\test2.txt";

            // File.Copy(path, path2); for copy with differ file name or in differ folder
            File.Copy(path, path2, true);
            Console.ReadLine();

        }
    }
}
