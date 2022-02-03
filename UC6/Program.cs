using System;

namespace AssignmentDay23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            UC6 addressbook = new UC6();
            switch (Console.ReadLine())
            {
                case "1":
                    addressbook.Customer();
                    addressbook.Listing();
                    break;
                case "2":
                    addressbook.Customer();
                    addressbook.Modify();
                    addressbook.Listing();
                    break;
                case "3":
                    addressbook.Customer();
                    addressbook.Listing();
                    break;
                case "4":
                    addressbook.Customer();
                    addressbook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }

        }
    }
}

 