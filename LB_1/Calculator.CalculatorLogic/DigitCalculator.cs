using System;

namespace Calculator.CalculatorLogic
{
	public class DigitCalculator : ICalculator<double, string>
	{
		public double MemoryNumber { get; set; }
		public double Plus(double first, double second)
		{
			return first + second;
		}
		public double Minus(double first, double second)
		{
			return first - second;
		}
		public double Multiply(double first, double second)
		{
			return first * second;
		}
		public double Divide(double first, double second)
		{
			if (second == 0)
				throw new DivideByZeroException();
			return first / second;
		}
		public double Calculate(double first, double second, string operation)
		{
			switch (operation)
			{
				case "+":
					return Plus(first, second);
				case "-":
					return Minus(first, second);
				case "*":
					return Multiply(first, second);
				case "/":
					return Divide(first, second);
				default:
					throw new Exception("No such operation!");
			}
		}
	}

}
