using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет инженер \nметод ввиде структур");
            LinEgua linEgua = new LinEgua();
            Console.WriteLine("Введите число k");
            Console.WriteLine("Введите число b");
            linEgua.Root();
            Console.WriteLine("Значение х =", x);
            Console.ReadKey();
        }

        struct LinEgua //создание структуры
        {
            public double k = Convert.ToDouble(Console.ReadLine());
            public double b = Convert.ToDouble(Console.ReadLine());
            public double x = 0;

            public void Root() // метод в структуре
            { if ((k != 0) && (b != 0))
                {
                    Console.Write("Решать по формуле");
                    x += - b / k;
                    break;
                    if ((k = 0) && (b = 0))
                    {
                        Console.Write("х - любое число");
                        break;
                        if ((k = 0) && (b != 0))
                        {
                            Console.Write("х - нет решения");
                            break;
                        }
                    }
                    return;
                }
                Console.ReadKey();
            }
        }
    }
}
