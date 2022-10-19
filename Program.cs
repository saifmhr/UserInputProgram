using System;
namespace UserInputProgram
{
 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plaese enter letter : ");
            int cValue = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(cValue);


            //convert to integer into string
            Console.Write("Plaese enter first value : ");
            int fValue=Convert.ToInt32(Console.ReadLine());

            Console.Write("Plaese enter second value : ");
            int sValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fValue+sValue);

            //simple string
            Console.Write("Plaese enter your name : ");
            string firstname = Console.ReadLine();

            Console.Write("Plaese enter your name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Helllo {0} , {1} ", firstname ,lastName);

            Console.WriteLine("Hello " + firstname + ", " + lastName);
        }
    }
}
