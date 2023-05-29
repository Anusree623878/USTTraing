using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerof2usinginnerclass
{
    public class PowerOfTwoChecker
    {
        private int number;

        public PowerOfTwoChecker(int number)

        {

            this.number = number;

        }

        public bool IsPowerOfTwo()

        {

            PowerChecker powerChecker = new PowerChecker();

            return powerChecker.CheckPowerOfTwo();

        }

        private class PowerChecker

        {
            private int num;

            public bool CheckPowerOfTwo()

            {

                //return (number > 0) && ((number & (number - 1)) == 0);

                while (((num % 2) == 0) && num > 1)

                {

                    num /= 2;

                }

                return (num == 1);
            }

        }
    }
}
