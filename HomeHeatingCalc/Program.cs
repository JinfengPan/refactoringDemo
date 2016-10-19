using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeHeatingCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Home Heating Cost Calculator...");
            Console.WriteLine("How many squarefeed is your home (1500 or 2500)");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("How severe are your winters (Mild, moDerate, Severe)?");
            string w = Console.ReadLine();

            decimal cost = CalculatorCost(size, w);
            Console.WriteLine("Cost: ${0}", cost);
            Console.ReadLine();

        }

        private static decimal CalculatorCost(int size, string s)
        {
            //Mild winter
            if (s.Contains("M"))
            {
                return (decimal) size*1000*0.12m*293/1000000;
            }
            else
            {
                //Moderate winter
                if (s.Contains("D"))
                {
                    return (decimal) size*2000*2.12m*293/1000000;
                }
                else
                {
                    //Severe winter
                    if (size == 1500)
                    {
                        return (decimal) 5000000*0.12*293/1000000;
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        }
    }
}
