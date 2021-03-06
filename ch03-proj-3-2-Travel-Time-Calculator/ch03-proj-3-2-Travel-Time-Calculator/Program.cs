﻿using System;

namespace ch03_proj_3_2_Travel_Time_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double speed, miles, timeSpan;
			Console.WriteLine("Welcome to the Travel Time Calculator!");
			Console.WriteLine();

			String choice = "y";
			while (choice.Equals("y")) {
				Console.Write("Enter miles: ");
				miles = Convert.ToDouble(Console.ReadLine());

				Console.Write("Enter miles per hour: ");
				speed = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				Console.WriteLine("Estimated travel time: ");
				Console.WriteLine("______________________");
				int hours = (int)((int)miles / speed);
				int min = (int)((miles / speed) * 60 % 60);
				/*var timeInMinutes = TimeSpan.FromMinutes(d1);
				var timeInHours = TimeSpan.FromHours(d1);
				int hh = timeInHours.Hours;
				int mm = timeInMinutes.Minutes;
				*/
				Console.WriteLine();
				Console.WriteLine("Hours: " + hours);
				Console.WriteLine("Minutes: " + min);
				Console.WriteLine();
				Console.Write("Continue?  (y/n) ");
				choice = Console.ReadLine();
				Console.WriteLine();
			}
			Console.WriteLine("Good-bye!");
		}
	}
}
