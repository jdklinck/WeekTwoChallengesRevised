using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoChallengesUpdated
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.Name = "Jessica";
            greeter.HelloPerson(greeter.Name);

            greeter.GoodbyePerson(greeter.Name);

            DateTime dateTime = new DateTime(2015, 12, 31, 5, 10, 20);
            int hourOfDay = dateTime.Hour;
            if (hourOfDay > 0 && hourOfDay < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hourOfDay >= 12 && hourOfDay < 16)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (hourOfDay >= 16 && hourOfDay < 21)
            {
                Console.WriteLine("Good Evening");
            }
            else if (hourOfDay >= 21 && hourOfDay <= 24)
            {
                Console.WriteLine("Good Night");
            }

            Console.ReadLine();
        }
    }
}
