﻿// See https://aka.ms/new-console-template for more information


using CalculatorApp;

Message();
int userInput = int.Parse(Console.ReadLine());
Console.WriteLine(userInput);


Addition add = new Addition();

if (userInput == 1)
{

    Console.WriteLine("Please input the first Number");

    double firtNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Please input the second Number");

    double secondNumber = double.Parse(Console.ReadLine());

    double additionValue = add.Add(firtNumber, secondNumber); ///Addition(firtNumber, secondNumber);
    Console.WriteLine("Total Addition value is " + additionValue);
    Console.WriteLine($"Total Addition value is  {additionValue}");////String polation in C#
    Console.WriteLine("Total Addition value of {0} and {1} is", firtNumber, secondNumber, additionValue);
}
else if (userInput == 2)
{

    Console.WriteLine("Please input the first Number");

    double firtNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Please input the second Number");
    double secondNumber = double.Parse(Console.ReadLine());

    double diffValue = Subtraction(firtNumber, secondNumber);
    Console.WriteLine("Total Subtracted value is " + diffValue);

}
else if (userInput == 3)
{

    Console.WriteLine("Please input the first Number");

    double firtNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Please input the second Number");
    double secondNumber = double.Parse(Console.ReadLine());

    double value = Multiplication(firtNumber, secondNumber);
    Console.WriteLine("Total Multiplication value is " + value);

}

else if (userInput == 4)
{

    Console.WriteLine("Please input the first Number");

    double firtNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Please input the second Number");
    double secondNumber = double.Parse(Console.ReadLine());

    double value = Division(firtNumber, secondNumber);
    Console.WriteLine("Total Division value is " + value);

}

else if (userInput == 5)
{

    Console.WriteLine("Please input the first Number");

    double firtNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Please input the second Number");
    double secondNumber = double.Parse(Console.ReadLine());

    double additionValue = add.Average(firtNumber, secondNumber);
    Console.WriteLine("Total Division value is " + additionValue);

}

else if (userInput == 6)
{

    Console.WriteLine("Please input the first Number");

    int firtNumber = int.Parse(Console.ReadLine());

    MultiplicationTable(firtNumber);






}
else
{
    Console.WriteLine("Please select valid operation value");
}


void Message()
{
    Console.WriteLine("Hello, World!");

    Console.WriteLine("Welcome to the Calculator App!");
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
}

//double Addition(double firtNumber, double secondNumber)
//{

//    double sum = firtNumber + secondNumber;
//    return sum;
//}

double Subtraction(double firtNumber, double secondNumber)
{

    double diff = firtNumber - secondNumber;
    return diff;
}


double Multiplication(double firtNumber, double secondNumber)
{

    double value = firtNumber * secondNumber;
    return value;
}

double Division(double firtNumber, double secondNumber)
{

    double value = firtNumber / secondNumber;
    return value;
}



void MultiplicationTable(double firtNumber)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(firtNumber + " X " + i + " = " + (firtNumber * i));

    }
}
