using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safronov
{
    class QuadraticEquation : LinearEquation, Core.EquationInterface
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

            else throw new SafronovExeption("Нет корней");

            MyLog.log("Определено, что это квадратное уравнение");
            return myAL;


        }
    }
}
