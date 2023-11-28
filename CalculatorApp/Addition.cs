using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Addition
    {


        public double Add(double firtNumber, double secondNumber)
        {

            double sum = firtNumber + secondNumber;
            return sum;
        }

        public double Average(double firtNumber, double secondNumber)
        {

            double value = (firtNumber + secondNumber) / 2;
            return value;
        }


    }
}
