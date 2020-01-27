using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safronov
{
    class LinearEquation
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
                throw new SafronovExeption("Уравнение не существует!");
            }
            myAL.Add((double)-b / a);

            MyLog.log("Определено, что это линейное уравнение");
            return myAL;
        }
    }
}
