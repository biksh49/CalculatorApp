using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Addition
    {
        public double Add(double firstInput, double secondInput)
        {
            double sum = firstInput + secondInput;
            return sum;
        }
        public double Add(double firstInput, double secondInput, double thirdInput)
        {
            double sum = firstInput + secondInput + thirdInput;
            return sum;
        }
        // function overloading
        private double Average(double firstInput, double secondInput)
        {
            var result = Add(firstInput, secondInput);
            double sum = result / 2;
            return sum;
        }
    }
}

   