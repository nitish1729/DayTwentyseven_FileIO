using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_FileIO
{
    public class AddessBook
    {
        List<Contacts> AddedNewCont = new List<Contacts>();
        public void ContactDetails()
        {
            Contacts Contact = new Contacts();

            Console.WriteLine("Enter your FirstName");
            Contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            Contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address Details");
            Console.WriteLine("Enter your StateName");
            Contact.State = Console.ReadLine();
            Console.WriteLine("Enter your CityName");
            Contact.CityName = Console.ReadLine();
            Console.WriteLine("Enter your Zip_Code");
            Contact.ZipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your PhoneNumber");
            Contact.PhoneNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email_ID");
            Contact.Email_ID = Console.ReadLine();
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("Your contact details ");
            AddedNewCont.Add(Contact);
        }
          public void display()
           {
             foreach (var Address in AddedNewCont)
             {
                Console.WriteLine("FirstName :-{0}",  Address.FirstName);
                Console.WriteLine("LastNmae :- {0} ",   Address.LastName);
                Console.WriteLine("FullName :- {0} {1}",Address.FirstName, Address.LastName);
                Console.WriteLine("state Nmae:-{0}  ", Address.State);
                Console.WriteLine("CityName :- {0}  ",   Address.CityName);
                Console.WriteLine("ZipCode :-  {0}",    Address.ZipCode);
                Console.WriteLine("PhoneNum :- {0} ",   Address.PhoneNum);
             }
            Console.ReadLine();
          }
        
    }
}
