using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma
{
    class ClassA
    {
        protected List<double> myAL = new List<double>();


        public List<double> MyAL
        {
            get { return myAL; }
            set { myAL = value; }
        }
        public List<double> linearEquation(int a, int b)
        {
            if (a == 0)
            {
                throw new Exception("Уравнение не существует!");
            }
            myAL.Add((double)-b / a);

            return myAL;
        }
    }

    class ClassB : ClassA
    {

        protected double discriminant(int a, int b, int c)
        {

            return b * b - 4 * a * c;

        }



        public List<double> solve(int a, int b, int c)
        {

            if (a == 0)
                return linearEquation(b, c);
            double d = this.discriminant(a, b, c);


            if (d == 0)
            //Корень один
            {

                myAL.Add((-b + Math.Sqrt(d)) / 2 * a);


            }
            else if (d > 0)
            // два корня
            {
                myAL.Add((-b + Math.Sqrt(d)) / 2 * a);
                myAL.Add((-b - Math.Sqrt(d)) / 2 * a);

            }
            else throw new Exception("Корней нет! D<0");

            return myAL;


        }

        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    ClassB b = new ClassB();
                    b.solve(3, 12, 8);
                    int count = b.MyAL.Count;

                    if (count == 0)
                    {
                        Console.WriteLine("Количество корней: " + count);
                        Console.WriteLine("D<0 Корней нет");
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("Количество корней: " + count);
                        Console.WriteLine(b.MyAL[0]);

                    }

                    if (count == 2)
                    {
                        Console.WriteLine("Количество корней: " + count);
                        Console.WriteLine(b.MyAL[0] + " " + b.MyAL[1]);

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
