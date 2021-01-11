using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_2
{
    class Class1
    {

        public void display()
        {
#if DEBUG
            int x = 5;
            Console.WriteLine(x);
#else
            int x = 10;
#endif
        }
    }
}
