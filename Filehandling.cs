using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_FileIO
{
     public class Filehandling
    {
        public void FileHandling()
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\Addressbook_FileIO\Addressbook_FileIO\Contacts.cs";
            //(.Exists)_Method checking whether the specified path Exists or not- gives boolen values
            if (File.Exists(path))
            {
                Console.WriteLine("Yes, the file exists");
            }
            else
            {
                Console.WriteLine("No, the file don't exists");
            }
            Console.ReadLine();
        }
    }
}
