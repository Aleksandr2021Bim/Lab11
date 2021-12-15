using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_11._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Привет инженер \nметод ввиде структур");
            Console.WriteLine("Введите число k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            LinEgua linEgua = new LinEgua(k, b);
            Console.WriteLine(linEgua.Root());
            Console.ReadKey();
        }
    }

        struct LinEgua //создание структуры
        {
            public double k ;
            public double b ;
            
            public LinEgua(double k, double b)
            {
                this.k = k;
                this.b = b;
            }


            public string Root() // метод в структуре
            {
                string result = "";
                if ((k != 0) && (b != 0))
                      result = (-b / k).ToString();
                else if ((k == 0) && (b == 0))
                      result = "х - любое число";
                else if ((k == 0) && (b != 0))
                        result = "х - нет решения";
                      return result;
            }
                
        }
}
    

