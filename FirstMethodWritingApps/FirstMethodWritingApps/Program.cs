using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMethodWritingApps
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 10,input;
            input = GetSquare(i);
            Console.WriteLine(input);
            Console.ReadKey();
        }
        public static double GetSquare(double i)
        {
          double result = i * i;
            return result;
        }
            
    }
}
