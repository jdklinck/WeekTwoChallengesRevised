using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoChallengesUpdated
{
    public class Greeter
    {
        //Property
        public string Name { get; set; }
        public int Id { get; set; }

        //Method
        public void HelloPerson(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void GoodbyePerson(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }

    }
}