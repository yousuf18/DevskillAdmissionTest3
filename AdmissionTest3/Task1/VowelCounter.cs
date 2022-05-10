using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class VowelCounter
    {
        public string GetCounts(string text)
        {
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            StringBuilder sb = new StringBuilder();

            foreach (var item in text)
            {

                int ascii = item;
                if ((ascii == 65||  ascii == 69||ascii==73||ascii==79||ascii==85) || (ascii == 97 || ascii == 101||ascii==105||ascii==111||ascii==117))
                {
                    if (ascii >= 97 && ascii <= 122)
                        ascii -= 32;
                    arr[ascii - 65]++;

                }
            }
            sb.Clear();
            for (int i = 0; i < 26; i++)
            {
                if (i == 0||i==4||i==8||i==14||i==20)
                {
                    int ch = i + 65 + 32;

                    sb.Append((char)ch);
                    sb.Append('-');
                    sb.Append(arr[i]);
                    sb.Append(',');


                }

            }
            return sb.ToString();
        }
    }
}
