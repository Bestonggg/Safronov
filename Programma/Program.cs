using Safronov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 0, c = 0;
                Console.WriteLine("Введите 3 параметра a, b и с");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                MyLog.log("Введено уравнение: " + a + "X^2+" + b + "X+" + c + "=0");
                QuadraticEquation qe = new QuadraticEquation();
                List<double> list = qe.solve(a, b, c);
                String s = "Roots: ";
                foreach (double i in list)
                {
                    s += i + " ";
                }

                MyLog.log(s);

            }
            catch (SafronovExeption e)
            {
                MyLog.log("Ошибка: " + e.Message);
            }
            MyLog.write();
            Console.ReadKey();
        }
    }
}
