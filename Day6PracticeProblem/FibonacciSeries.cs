﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblem
{
	internal class FibonacciSeries
	{
		public static void fibonacciseries()
		{

			int a = 0;
			int b = 1;
			int c;
			Console.WriteLine(a);
			Console.WriteLine(b);

			for (int i = 0; i < 20; i++)
			{
				c = a + b;
				Console.WriteLine(c);
				a = b;
				b = c;

			}
			Console.ReadLine();
		}
	}
}
