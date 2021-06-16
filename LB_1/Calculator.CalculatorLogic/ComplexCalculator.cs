using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator.CalculatorLogic
{
    class ComplexCalculator : ICalculator<Complex, String>
    {
		public Complex MemoryNumber { get; set; }
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
		public Complex Calculate(Complex first, Complex second, string operation)
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
