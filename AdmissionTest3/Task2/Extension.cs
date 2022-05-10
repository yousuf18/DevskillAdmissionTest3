using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static  class Extension
    {

        public static int VowelCount(this string text)
        {
            int vowelcount=0;

           
                int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                

                foreach (var item in text)
                {

                    int ascii = item;
                    if ((ascii == 65 || ascii == 69 || ascii == 73 || ascii == 79 || ascii == 85) || (ascii == 97 || ascii == 101 || ascii == 105 || ascii == 111 || ascii == 117))
                    {
                    vowelcount++;
                        if (ascii >= 97 && ascii <= 122)
                            ascii -= 32;
                        arr[ascii - 65]++;

                    }
                }


            return vowelcount;
           
        }

    }
}
