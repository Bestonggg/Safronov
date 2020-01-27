using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma
{
    class A
    {

    }

    class B : A
    {
        object a1;
        object a2;
        object a3;
        object a4;
        public object A
        {
            get { return a1; }
            set { a1 = value; }
        }

        public B(object obj1, object obj2, object obj3, object obj4)
        {
            this.a1 = obj1;
            this.a2 = obj2;
            this.a3 = obj3;
            this.a4 = obj4;


        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B(a, a, a, a);

        }
    }
}
