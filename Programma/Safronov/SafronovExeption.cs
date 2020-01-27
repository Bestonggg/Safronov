using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safronov
{
    class SafronovExeption : Exception
    {
        public SafronovExeption(string message)
            : base(message)
        {

        }
    }
}
