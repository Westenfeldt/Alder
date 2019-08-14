using System;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            double age1;

            Console.WriteLine("Angiv dit navn, derefter din alder");

            name = Console.ReadLine();
            age = Console.ReadLine();

            age1 = float.Parse(age);

            
            
            if (age1 > 50)
                {
                    Console.WriteLine("Du er for gammel");
                }
                else if (age1 <= 50  && age1 >=30)
                {
                    Console.WriteLine("Du er okay");
                }
                    else if (age1 < 30)
                    {
                Console.WriteLine("Du er for ung");
                    }



        }
    }
}
