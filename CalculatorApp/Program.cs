﻿// See https://aka.ms/new-console-template for more information
using CalculatorApp;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Markup;

#region Display and Read the UserInput
/// Display the  message in the screen.
DisplayScreen();

/// Store the user input which is called as variable.

int userInput = ReadUserInput();

string user = string.Empty;

#endregion

// perform the operation on the basis of userInput using if and else.

#region IF AND ELSE CLAUSE USAGE

//if (userInput == 1 )
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
//    Console.WriteLine($"The differnce  of {firstInput} and {secondInput} is : {difference}");
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
//    //Console.WriteLine("Please enter the First Input");
//    //double firstInput = int.Parse(Console.ReadLine());
//    //Console.WriteLine("Please enter the Second Input");
//    //double secondInput = int.Parse(Console.ReadLine());
//    //double quotient = firstInput / secondInput;
//    //Console.WriteLine($"The division of {firstInput} and {secondInput} is : {quotient}");
//}

#endregion

//#region SWITCH STATEMENT
//    //Console.WriteLine("Please enter the First Input");
//    //double firstInputSwitchs = double.Parse(Console.ReadLine());
//    //Console.WriteLine("Please enter the Second Input");
//    //double secondInputSwitchs = double.Parse(Console.ReadLine());
//    Addition addition = new Addition();


//    switch (userInput)
//    {

//        case 1:
//            double sum = addition.Add(firstInputSwitchs,secondInputSwitchs);
//            double sums = addition.Add(firstInputSwitchs, secondInputSwitchs,4);
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
//        case 7:
//            int[] array1 = new int[] { 2, 5, 9, 10 };
//            for(int i=0; i < array1.Length; i++)
//            {
//                GenerateMultiplicationTable(array1[0], secondInputSwitchs);
//            }
//            break;

       

//        default:
//            Console.WriteLine("The input is not valid!!!");
//            break;

        
//    }
//#endregion

if (userInput == 8)
{
    Console.WriteLine("Please provide the number limit in order to add");
    int inputNumber = int.Parse(Console.ReadLine());
    int sum = 0;

    for(int i = 0; i < inputNumber; i++)
    {
        Console.WriteLine($"Enter the {i+1} number");
        int input=int.Parse(Console.ReadLine());
        sum=sum+input;
        
    }
    Console.WriteLine($"The sum of above is {sum}");


    
}

#region USE OF LOOP
if (userInput == 6)
{
    Console.WriteLine("Please enter the number to generate the multplication table: ");
    double multiple = double.Parse(Console.ReadLine()); 

    Console.WriteLine("Please enter the end number: ");
    double number = double.Parse(Console.ReadLine());

    Console.WriteLine();
    GenerateMultiplicationTable(multiple, number);
}
#endregion

#region Function


void GenerateMultiplicationTable(double multiple, double number){
    for (int i = 1; i <= number; i++)
    {
        //Console.WriteLine($"Multiplication table of {multiple}");
        Console.WriteLine($"{multiple}*{i}={multiple * i}");
    }
}

double Substraction(double firstInput, double secondInput)
{
    double differnce = firstInput - secondInput;
    return differnce;

}
double Multiplication(double firstInput, double secondInput)
{
    double product = firstInput * secondInput;
    return product;

}
double Division(double firstInput, double secondInput)
{
    double quotient = firstInput / secondInput;
    return quotient;

}

void DisplayScreen()
{
    Console.WriteLine("Welcome to the Calculator App!");
    Console.WriteLine("Hi, Welcome to the calculator App.");
    Console.WriteLine("Please select the below option in order to perform the operation");
    Console.WriteLine("1:Addition");
    Console.WriteLine("2:Substraction");
    Console.WriteLine("3:Multiplication");
    Console.WriteLine("4:Division");
    Console.WriteLine("5:Calculate the Average");
    Console.WriteLine("6:Generate the multiplication table of desired number");
    // For example input :2,5,6,7
    //Output : 2*1=2 ...2*10=20, 5*1=5 ....5*10=50,
    Console.WriteLine("7:Generate the multiplication table of desired number");
    Console.WriteLine("8:Add numbers");
    Console.WriteLine();
    Console.WriteLine("Please select  the one of the operation:");
}
int ReadUserInput()
{
    try
    {
        int userInput = int.Parse(Console.ReadLine());
        //Console.WriteLine(userInput);
        return userInput;
    }
    catch (Exception)
    {
        Console.WriteLine("The input given by user is incorrect. Please provide input interms of integer.");
        //throw;
    }
    return 0;
    
}
#endregion















