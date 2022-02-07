using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_5
{
    public class Cat
    {
        static Random rnd = new Random();
        public int sitost = rnd.Next(0, 100);


        public int level_sitosti = 0;

        public int Level_sitosti
        {
            get
            {
                return level_sitosti;
            }
            set
            {
                level_sitosti = value;
            }
        }

        public static void EatFood()
        {
            //Cat cat = new Cat();
            //cat.level_sitosti += (int)Food.Fish;
            //Console.WriteLine("Кошка покушала рыбу и её уровень сытости стал: " + cat.level_sitosti);
            //cat.level_sitosti = 0;
            //cat.level_sitosti += (int)Food.Mouse;
            //Console.WriteLine("Кошка съела мышь и её уровень сытости стал: " + cat.level_sitosti);
            //cat.level_sitosti = 0;
            //cat.level_sitosti += (int)Food.Feed;
            //Console.WriteLine("Кошка покушала корм и её уровень сытости стал: " + cat.level_sitosti);

        }


    }
}
