using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    
    public class CustomMath
    {
        public void Num(int n)

        {
            int multiple = 1;
            for (int i = 1; i <= n; i++)
            {
                multiple *= i;
            }
            Console.WriteLine(multiple);

        }
    }
    public void Array(int[] arr)
    {
      
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)

            {
                arr[i] = count++;
            }
        }
        Console.WriteLine(count);

    }

}
