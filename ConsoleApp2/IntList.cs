﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class IntList
    {
        private int[] arr;

        public IntList()
        {
            arr = new int[0];
        }
        public void Add(int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
        public void ShowNum()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
