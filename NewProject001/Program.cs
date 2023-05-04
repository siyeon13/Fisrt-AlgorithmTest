using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject001
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxCnt = 10;
            int divNum = 42;
            int remainder = 0;
            bool[] isRemain = new bool[divNum];

            for(int i=0; i< maxCnt; i++)
            {
                remainder = int.Parse(Console.ReadLine()) % divNum;
                isRemain[remainder] = true;
            }

            int cnt = 0;
            for(int i =0; i < isRemain.Length; i++)
            {
                if(isRemain[i] == true)
                {
                    cnt++;
                }
            }
           
            Console.WriteLine("답 : " + cnt);




        }

        public void Dive()
        {

        }
    }
}
