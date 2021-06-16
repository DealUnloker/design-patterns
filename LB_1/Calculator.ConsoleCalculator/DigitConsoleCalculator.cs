using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.CalculatorLogic;

namespace Calculator.ConsoleCalculator
{
	public class DigitConsoleCalculator
	{
		private readonly DigitCalculator _calculator;

		public DigitConsoleCalculator()
		{
			_calculator = new DigitCalculator();
			ShowCalculator();
		}

		public void ShowCalculator()
		{
			Console.WriteLine(_calculator.MemoryNumber);
			string operation = Console.ReadLine();
			if (operation.Equals("exit"))
			{
				Environment.Exit(0);
			}
			try
			{
				double number = Convert.ToDouble(Console.ReadLine());
				_calculator.MemoryNumber = _calculator.Calculate(_calculator.MemoryNumber, number, operation);
				Console.Clear();
			}
			catch (Exception exception)
			{
				Console.Clear();
				Console.WriteLine(exception.Message);
			}
			finally
			{
				ShowCalculator();
			}
		}
	}

}
