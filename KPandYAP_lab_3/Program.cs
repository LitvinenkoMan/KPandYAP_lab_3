using System;
using System.Numerics;


namespace KPandYAP_lab_3
{
    class Program
    {

        public void Function()
        { 
            
        }

        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////1
           /* Console.WriteLine("Выберите в какие единицы перевести: ");
            Console.WriteLine("1. дециметры");
            Console.WriteLine("2. километры");
            Console.WriteLine("3. метры");
            Console.WriteLine("4. милиметрах");
            Console.WriteLine("5. сантиметры");
            double ed = 0;
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    {
                        Console.WriteLine($"дециметрах: {ed = 0.1}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"километрах: {ed = 1000}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"меирах: {ed = 1}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"миллиметрах: {ed = 0.0001}");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine($"сантиметрах: {ed = 0.001}");
                        break;
                    }

                default:
                    break;
            }

            Console.WriteLine("Введите длинну отрезка: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"в метрах это: {number *= ed}");

            /////////////////////////////////////////////////////////////2
            Console.WriteLine("введите значение для х: ");
            double z = Convert.ToDouble(Console.ReadLine()), x = 0;
            if (z<0)
            {
                x = z;
            }
            else
            {
                x = Math.Sin(z);
            }

            double y = ((2.0 / 3.0) * Math.Pow(Math.Sin(x), 2.0)) - ((3.0 / 4.0) * Math.Pow(Math.Cos(x), 2.0));
            Console.WriteLine($"Ответ: {y}");

            /////////////////////////////////////////////////////////////3*/
            Console.WriteLine("введите возраст: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && a < 5)
            {
                Console.WriteLine($"мне {a} года");
            }
            else if (a > 5 && a < 21)
            {
                Console.WriteLine($"мне {a} лет");
            }
            else if (a == 21)
            {
                Console.WriteLine($"мне {a} год");
            }
            else if (a > 21 && a < 31)
            {
                Console.WriteLine($"мне {a} лет");
            }
            else if (a == 31)
            {
                Console.WriteLine($"мне {a} год");
            }
            else if (a > 31 && a < 41)
            {
                Console.WriteLine($"мне {a} лет");
            }
            else if (a == 41)
            {
                Console.WriteLine($"мне {a} год");
            }
            else if (a > 41 && a < 51)
            {
                Console.WriteLine($"мне {a} лет");
            }
            else if (a == 51)
            {
                Console.WriteLine($"мне {a} год");
            }
            else
                Console.WriteLine($"мне {a} лет");
        }
    }
}
