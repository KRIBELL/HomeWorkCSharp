using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  HOMEWORK_4
{
    class ClassCounter
    {
        public delegate void SomeMethod1();
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 77)
                {
                    Count();
                }
            }
        }
    }
}
