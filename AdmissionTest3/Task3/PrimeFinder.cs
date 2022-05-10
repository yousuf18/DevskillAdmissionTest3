using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrimeFinder
    {
        public int[] GetPrimes(int lowerValue, int upperValue)
        {
            int j = 0;
            int[] arr1 = new int[upperValue - lowerValue+1];
            while (lowerValue < upperValue)
            {
               
                int i,flag;
                flag = 0;
                for (i = 2; i <= lowerValue / 2; i++)
                {
                    if (lowerValue % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
               
               
                if (flag == 0)
                { 
                    arr1[j]= lowerValue;
                    j++;
                }
                lowerValue++;


            }
            return arr1;
          
            
        }
    }
    
}
