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
            switch (Console.ReadLine())
            {
                case "1":
                    AssignmentDay23.UC5.Customer();
                    AssignmentDay23.UC5.Listing();
                    break;
                case "2":
                    AssignmentDay23.UC5.Customer();
                    AssignmentDay23.UC5.Modify();
                    AssignmentDay23.UC5.Listing();
                    break;
                case "3":
                    AssignmentDay23.UC5.Customer();
                    AssignmentDay23.UC5.Listing();
                    break;
                case "4":
                    AssignmentDay23.UC5.Customer();
                    AssignmentDay23.UC5.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}

 