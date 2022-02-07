using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_4
{
    struct Dog
    {
        public string dogName;
        public string mark;
        public int age;

        public override string ToString()
        {
            return string.Format("Dog = ({0}, {1}, {2})", dogName, mark, age); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            myDog.age = 5;
            myDog.dogName = "westrnUnion";
            myDog.mark = "Haski";

            Console.WriteLine(myDog);
        }
    }
}
