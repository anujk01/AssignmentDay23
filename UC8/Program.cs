using System;

namespace AssignmentDay23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome To Adderess Book Program-------------");
            Console.WriteLine("1.Enter to add the details\n2.Enter to modify the details");
            Console.WriteLine("3.Listing the details");
            Console.WriteLine("4.Remove the Contact details");
            Console.WriteLine("5.Multiple Contact Details");
            Console.WriteLine("Enter a option");
            UC8 addressBook = new UC8();
            switch (Console.ReadLine())
            {
                case "1":
                    addressBook.Listing();
                    break;
                case "2":
                    addressBook.Modify();
                    addressBook.Listing();
                    break;
                case "3":
                    addressBook.Listing();
                    break;
                case "4":
                    addressBook.RemovePeople();

                    break;
                case "5":
                    addressBook.Listing();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}

 