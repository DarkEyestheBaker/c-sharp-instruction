﻿using System;

namespace ch05_Optional_Arguments
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Optional args!");
			int nb1 = 22;
			int nb2 = 44;

			Console.WriteLine("Sum is: " + Sum(nb1, nb2));

			Console.WriteLine("Bye!");
		}
		static int Sum(int n1, int n2)
		{
			return n1 + n2;
		}
			}
}
