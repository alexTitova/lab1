using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.parts
{
    class ExceptionOfNotEqualPaths : Exception
    {
        public ExceptionOfNotEqualPaths(string message)
            :base(message)
        {  }
    }
}
