﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    internal class InsertionSort
    {
        public static void Sort(int[] arr)
        {
			int i, j, key;
			for (i = 1; i < arr.Length; i++)
			{
				key = arr[i];
				j = i - 1;

				while (j >= 0 && arr[j] > key)
					arr[j + 1] = arr[j--];

				arr[j + 1] = key;
			}
		}
    }
}
