using System;

namespace Calculator.ConsoleCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var instance = CalculatorManager.getInstance();
			instance.ShowMenu();
		}
	}

}
