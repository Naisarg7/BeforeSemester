using System;
using System.Collections.Generic;
using System.Text;

namespace Internal_Access_Specifier
{
    class Internal
    {
        private int num1;
        private int num2;

        public void showSum()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1+num2));
        }

        public int Number1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        public int Number2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }

    }
}
