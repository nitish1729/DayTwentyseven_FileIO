using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This Namespace is used for performing operations with files


namespace Addressbook_FileIO
{
    public class ReadOrWriteFile
    {
        public void ReadOrWrite()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\Addressbook_FileIO\Addressbook_FileIO\AddessDetails.cs";

            // .Exists -- method is used to check that a particular file exists or not.
            if (File.Exists(path)) 
            {
                Console.WriteLine("Yes, the file exists");

                /*ReadAllText(String) is used for Opens a text file, reads all the text in the file,
                and then closes the file.*/
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("No, the file don't exists");
            }
            Console.ReadLine();
        }



    }
}
