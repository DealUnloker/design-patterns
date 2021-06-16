using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CalculatorLogic
{
	public class CalculatorFactory
	{
		public static Calculator Create(CalculatorTypeEnum calculatorType)
		{
			switch (calculatorType)
			{
				case CalculatorTypeEnum.Digit:
					return new DigitCalculator();
				case CalculatorTypeEnum.Complex:
					return new ComplexCalculator();
				default:
					throw new NotImplementedException();
			}
		}
	}


}
