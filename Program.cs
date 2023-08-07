﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrac32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            List<int> output = new List<int>();

            // Linq 없이 2의 배수 구하기
            foreach(var item in input)
            {
                if(item % 2 == 0) output.Add(item);
            }

            var output2 = from item in input
                          where item % 2 == 0   
                          orderby item
                          select item;
        }
    }
}
