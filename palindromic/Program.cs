using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_problem
    {
    class Program
        {
        static void Main(string[] args)
            {
            List<int> multipls = new List<int>();
            for(int i = 1; i<1000; i++)
                {
                if(i%3==0 ||i% 5==0)
                    {
                    multipls.Add(i);
                    }
                Console.WriteLine(multipls.Sum());
                }
            }
        }
    }
