﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection.Metadata.Ecma335;

#region Display and Read the UserInput

//greeting according to the time
var GreetingTime = DateTime.Now;
if (GreetingTime.Hour >= 4 && GreetingTime.Hour < 12)
{
    Console.WriteLine("Good morning");
}
else if (GreetingTime.Hour >= 12 && GreetingTime.Hour <= 6)
{
    Console.WriteLine("Good afternoon");
}
else if (GreetingTime.Hour >= 6 && GreetingTime.Hour <= 4)
{
    Console.WriteLine("Good evening");
}
/// Display the  message in the screen.

Console.WriteLine("{0} Welcome to the Calculator App!", GreetingTime);
Console.WriteLine("Hi, Welcome to the calculator App.");
Console.WriteLine("Please select the below option in order to perform the operation");
Console.WriteLine("1:Addition");
Console.WriteLine("2:Substraction");
Console.WriteLine("3:Multiplication");
Console.WriteLine("4:Division");
Console.WriteLine("5:Calculate the Average");
Console.WriteLine("6:Generate the multiplication table of desired number");
Console.WriteLine();
Console.WriteLine("Please select  the one of the operation:");

/// Store the user input which is called as variable.

int userInput = int.Parse(Console.ReadLine());
Console.WriteLine(userInput);

#endregion

// perform the operation on the basis of userInput using if and else.

//#region IF AND ELSE CLAUSE USAGE

//if (userInput == 1)
//{
//    Console.WriteLine("Please enter the First Input");
//    double firstInput = double.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter the Second Input");
//    double secondInput = double.Parse(Console.ReadLine());
//    var sum =   Addition(firstInput,secondInput);
//    Console.WriteLine($"The sum of {firstInput} and {secondInput} is : {sum}");
  
//}

//else if (userInput == 2)
//{
//    Console.WriteLine("Please enter the First Input");
//    double firstInput = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter the Second Input");
//    double secondInput = int.Parse(Console.ReadLine());
//    double difference = firstInput - secondInput;
//    Console.WriteLine($"The differnce  of {firstInput} and {secondInput} is :");
//}
//else if (userInput == 3)
//{
//    Console.WriteLine("Please enter the First Input");
//    double firstInput = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter the Second Input");
//    double secondInput = int.Parse(Console.ReadLine());
//    double product = firstInput * secondInput;
//    Console.WriteLine($"The product  of {firstInput} and {secondInput} is : ");
//}
//else if (userInput == 4)
//{
//    Console.WriteLine("Please enter the First Input");
//    double firstInput = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter the Second Input");
//    double secondInput = int.Parse(Console.ReadLine());
//    double quotient = firstInput / secondInput;
//    Console.WriteLine($" The {firstInput} divided by {secondInput} is :{quotient}");
//}
//else
//{
//    Console.WriteLine("Please enter the First Input");
//    double firstInput = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter the Second Input");
//    double secondInput = int.Parse(Console.ReadLine());
//    double quotient = firstInput / secondInput;
//    Console.WriteLine($"The division of {firstInput} and {secondInput} is : {quotient}");
//}


///*using System;

//class Program
//{
//    static void Main()
//    {
//        double firstInput = GetDoubleInput("Please enter the First Input");
//        double secondInput = GetDoubleInput("Please enter the Second Input");

//        Console.WriteLine($"First Input: {firstInput}");
//        Console.WriteLine($"Second Input: {secondInput}");
//    }

//    static double GetDoubleInput(string prompt)
//    {
//        Console.WriteLine(prompt);

//        if (double.TryParse(Console.ReadLine(), out double result))
//        {
//            return result;
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return GetDoubleInput(prompt);
//        }
//    }
//}
//*/

//#endregion

//#region SWITCH STATEMENT
//Console.WriteLine("Please enter the First Input");
//    double firstInputSwitchs = double.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter the Second Input");
//    double secondInputSwitchs = double.Parse(Console.ReadLine());
//    switch (userInput)
//    {

//        case 1:
//            double sum = Addition(firstInputSwitchs, secondInputSwitchs);
//            double average = sum / 2;
//            break;

//        case 2:

//            double subtract = firstInputSwitchs - firstInputSwitchs;
//            Console.WriteLine($"The differnce  of {firstInputSwitchs} and {firstInputSwitchs} is : {subtract}");
//            break;
//        case 3:
//            double product = firstInputSwitchs * firstInputSwitchs;
//            Console.WriteLine($"The product  of {firstInputSwitchs} and {firstInputSwitchs} is : {product}");
//            break;
//        case 4:
//            double div = firstInputSwitchs / firstInputSwitchs;
//            Console.WriteLine($"The quotient  of {firstInputSwitchs} and {firstInputSwitchs} is : {div}");
//            break;
//        default:
//            Console.WriteLine("The input is not valid!!!");
//            break;
//    }
//#endregion

//#region USE OF LOOP
//if (userInput == 6)
//{
//    Console.WriteLine("Please enter the number to generate the multplication table: ");
//    double multiple = double.Parse(Console.ReadLine()); 

//    Console.WriteLine("Please enter the end number: ");
//    double number = double.Parse(Console.ReadLine());

//    Console.WriteLine();

//    for(int i=1; i <=number; i++)
//    {
//        Console.WriteLine($"Multiplication table of {multiple}");
//        Console.WriteLine($"T{multiple}*{i}={multiple * i}");
//    }
//}
//#endregion

//#region Function

//    double Addition(double firstInput, double secondInput)
//{
    
//    double sum = firstInput + secondInput;
//    return sum;
//}
//    double Substraction(double firstInput, double secondInput)
//    {
//        double differnce = firstInput - secondInput;
//        return differnce;
    
//    }
//    double Multiplication(double firstInput, double secondInput)
//    {
//        double product = firstInput*secondInput;
//        return product;
    
//    }
//    double Division(double firstInput, double secondInput)
//    {
//        double quotient = firstInput/secondInput;
//        return quotient;
    
//    }

//// array program
//int i, num;
//int[] arr1 = new int[100];

//Console.WriteLine("Input the number of arrays you want");   //asking for the number of arrays
//num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the data one by one for {0}", num);

//Console.WriteLine("Input {0} of arrays you want ", num);   //printing the arrays 1 by 1
//for (i = 0; i < num; i++)
//{
//    Console.WriteLine("element - {0} : ", i);
//    arr1[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("The values store into the array are :");  //prining the values stored
//for (i = 0; i < num; i++)
//{
//    Console.Write("{0}  ", arr1[i]);
//}
//#endregion











