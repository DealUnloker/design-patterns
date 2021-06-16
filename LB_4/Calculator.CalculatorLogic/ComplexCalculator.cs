using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator.CalculatorLogic
{
	public class ComplexCalculator : Calculator, IOperand<Complex>
	{
		internal ComplexCalculator()
		{
			MemoryNumber = "0";
		}
		public string MemoryNumber { get; set; }
		public Complex Plus(Complex first, Complex second)
		{
			return first + second;
		}
		public Complex Minus(Complex first, Complex second)
		{
			return first - second;
		}
		public Complex Multiply(Complex first, Complex second)
		{
			return first * second;
		}
		public Complex Divide(Complex first, Complex second)
		{
			if (second == 0)
				throw new DivideByZeroException();
			return first / second;
		}
		public override string Calculate(string first, string second, string operation)
		{
			Complex firstArg;
			Complex secondArg;
			var firstSplit = first.Split(',');
			var secondSplit = second.Split(',');
			string realFirst = string.Empty;
			string realSecond = string.Empty;
			string imFirst = string.Empty;
			string imSecond = string.Empty;
			for (int i = 0; i < 2; i++)
			{
				foreach (var item in firstSplit[i])
				{
					if (char.IsNumber(item) || item.Equals('.'))
					{
						if (i == 0)
							realFirst += item;
						else
							imFirst += item;
					}
				}
				foreach (var item in secondSplit[i])
				{
					if (char.IsNumber(item) || item.Equals('.'))
					{
						if (i == 0)
							realSecond += item;
						else
							imSecond += item;
					}
				}
			}
			firstArg = new Complex(Convert.ToDouble(realFirst), Convert.ToDouble(imFirst));
			secondArg = new Complex(Convert.ToDouble(realSecond), Convert.ToDouble(imSecond));
			switch (operation)
			{
				case "+":
					return Plus(firstArg, secondArg).ToString();
				case "-":
					return Minus(firstArg, secondArg).ToString();
				case "*":
					return Multiply(firstArg, secondArg).ToString();
				case "/":
					return Divide(firstArg, secondArg).ToString();
				default:
					throw new Exception("No such operation!");
			}
		}
	}

}
