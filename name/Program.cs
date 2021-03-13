using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please fill in the following: ");

            //fill in/userinput

            Console.Write("first name: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("middle name: ");
            string middlename = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("last name: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("title: ");
            string title = Console.ReadLine();

            //results

            Console.WriteLine("=================================================");

            Console.WriteLine(title +" " +firstname+" " + middlename +" "+ lastname);

            Console.WriteLine(firstname + " " + middlename + " " + lastname);

            Console.WriteLine(firstname + " "+lastname);

            Console.WriteLine(lastname + ", " + firstname + " " + middlename + ", " + title);

            Console.WriteLine(lastname + ", " + firstname + " " + middlename);

            Console.WriteLine(lastname + ", " + firstname);

            //close program

            Console.WriteLine("press any key to close prgram");
            Console.ReadKey();
        }
    }
}
