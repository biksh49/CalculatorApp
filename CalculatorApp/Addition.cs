using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

   
    internal class Addition
    {

        Function func= new Function();


        public double Add(int reqNumber)
        {

            double sum = 0;
            int inputNum;
            
            int[] array= new int[reqNumber];
            
            for (int i = 0; i <reqNumber; i++)
            {
                Console.WriteLine($"Put the number {func.DecimalToWords(i+1)}");
                inputNum= int.Parse(Console.ReadLine());

                array[i] = inputNum;
                
                sum += inputNum;
            }

         
                Console.WriteLine("Your total of numbers {0}{1}", string.Join(" ", array),$" is {sum} ");
           
            

            return sum;
        }

        public double Average(double firtNumber, double secondNumber)
        {

            double value = (firtNumber + secondNumber) / 2;
            return value;
        }

      

 


    }
}
