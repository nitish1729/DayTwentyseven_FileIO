using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addressbook_FileIO;

//string wellcome;
//wellcome = "Welcome to Address Book Program in AddressBookMain class on Master Branch";
//Console.WriteLine("AddressBooks program by File Handling:- {0}", wellcome);
//Console.ReadLine();
//AddessBook show = new AddessBook();
//show.ContactDetails();
//show.display();
EditPersonName editName = new EditPersonName();
Console.WriteLine("'''''''''''''''''''''''''''''''''''''''");
Console.WriteLine("Enter person FirstName");
string FirstNmae = Console.ReadLine();
Console.WriteLine("Enter person LastName");
string LastName = Console.ReadLine();
string editedName = FirstNmae +"  " +LastName;
Console.WriteLine("person edited name :- {0}",editedName);

editName.edit(FirstNmae, LastName);
Console.ReadLine();
