/*
 * Zilin(Ian) Chen
 * 9/5/2019
 * CS3386
 * Homework 1
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCostCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			FuelCost expense = new FuelCost();

			Console.WriteLine("Welcome to the Fuel Cost Calculator, " +
				"please provide number of miles you have driven for a recent trip.");


			// Get a # of miles driven by the user 
			try
			{
				expense.Miles = float.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Input Invalid, please restart the program");
			}

			// Get # of gallons of gas used
			Console.WriteLine("How many gallons of gas was used?");
			try
			{
				expense.Gallons = float.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Input Invalid, please restart the program");
			}

			// Get the total # of miles (1 way) for the trip
			Console.WriteLine("What will be the total number of miles for your future trip?");
			try
			{
				expense.Tripdistance = float.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Input Invalid, please restart the program");
			}

			// Get the price of gas
			Console.WriteLine("Please provide the price of gas at the start of your trip.");
			try
			{
				expense.PriceFirst = float.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Input Invalid, please restart the program");
			}

			Console.WriteLine("Please provide the price of gas at the destination of your trip.");
			try
			{
				expense.PriceLast = float.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Input Invalid, please restart the program");
			}

			expense.Mpg = expense.Miles / expense.Gallons;

			// # of gallons of gas required for the round-trip
			expense.NumOfGallon = expense.Tripdistance * 2 / expense.Mpg;

			expense.Cost = (expense.PriceFirst + expense.PriceLast) / 2 * expense.NumOfGallon;

			Console.WriteLine($"Your Car's mpg is: {expense.Mpg}");
			Console.WriteLine($"The number of gallons of gas required for the round-trip : {expense.NumOfGallon}");
			Console.WriteLine($"Total round-trip cost for gas: {expense.Cost:C}");
			Console.ReadLine();

            float miles;
            bool isSuccessful = float.TryParse(Console.ReadLine(), out miles);
            while(isSuccessful ==  false)
            {
                Console.WriteLine("error");
            }

		}
	}
}
