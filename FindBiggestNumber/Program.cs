using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] ArrayNr = { 10, 5, 60, 8, 2 };

            int biggestNr = 60;
            //int index = 0;

            for (int i = 0; i < ArrayNr.Length; i++)
            {
                if (ArrayNr[i] > biggestNr)
                {
                    biggestNr = ArrayNr[i];
                    //index = Array.IndexOf(ArrayNr, ArrayNr[i]);
                }
            }
            Console.WriteLine($"The biggest Nr = {biggestNr}");
        }
    }
}