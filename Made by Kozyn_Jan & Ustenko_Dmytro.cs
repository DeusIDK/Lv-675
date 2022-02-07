using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_5
{
    public enum Food: ushort
    {
        Mouse = 3,
        Fish = 5,
        Feed = 10
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat();
            Console.WriteLine("Уровень голода у кошки: " + cat.sitost);
            Console.WriteLine("Покормить кошку?");

            string statement = Console.ReadLine();

            if (statement == "Да" | statement == "да")
            {
                Console.WriteLine("Чем покормить кошку?\n Рыба - 5 ур. сытости\n Мышь - 3 ур. сытости\n Корм - 10 ур. сытости");
            }
            else
                Console.WriteLine("Вы не покормили кошку :с");
            while (cat.sitost > 1 && cat.sitost < 90) 
            {
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "Рыба":
                        Console.WriteLine("Кошка покушала рыбу и её уровень сытости стал: " + (cat.sitost += (int)Food.Fish));
                        if (cat.sitost <= 90)
                            Console.WriteLine("Покормить кошку еще раз? Если да - введите чем: ");
                        else
                            Console.WriteLine("Кошка наелась и теперь довольная)");
                        break;

                    case "Мышь":
                        Console.WriteLine("Кошка покушала мышь и её уровень сытости стал: " + (cat.sitost += (int)Food.Mouse));
                        if (cat.sitost <= 90)
                            Console.WriteLine("Покормить кошку еще раз? Если да - введите чем: ");
                        else
                            Console.WriteLine("Кошка наелась и теперь довольная)");
                        break;

                    case "Корм":
                        Console.WriteLine("Кошка покушала корм и её уровень сытости стал: " + (cat.sitost += (int)Food.Feed));
                        if (cat.sitost <= 90)
                            Console.WriteLine("Покормить кошку еще раз? Если да - введите чем: ");
                        else
                            Console.WriteLine("Кошка наелась и теперь довольная)");
                        break;

                    default:
                        Console.WriteLine("Введите правильно чем покормить кошку!");
                        break;
                }
            }
        }
    }
}
