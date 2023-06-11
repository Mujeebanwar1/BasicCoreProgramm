using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramm
{
    
    
        public class PowerOfTwo
        {
            public void Power()
            {
                Console.WriteLine("Enter the power value");
                int exponent = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= exponent; i++)
                {
                    Console.WriteLine("2^{0} " + " " + "= {1}", i, Math.Pow(2, i));
                }
            }
        }
}
