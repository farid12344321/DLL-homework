using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_homework
{
    internal class Calculator
    {
        public void Calculation()
        {



            double result = 0;

            Console.WriteLine("birinci ededi daxil edin");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("ikinci ededi daxil edin");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("operator daxil edin");
            string c = Console.ReadLine();


            switch (c)
            {
                case "+":
                    result = n + m;
                    break;

                case "-":
                    result = n - m;
                    break;
                case "*":
                    result = n * m;
                    break;
                case "/":
                    result = n / m;
                    break;
            }
            Console.WriteLine("cavab= " + result);

        }
    }
}
