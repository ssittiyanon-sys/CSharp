using System;
using System.Globalization;

Console.WriteLine("Plus between two Number Program");
Console.WriteLine("Pleae Enter your two Number");

// Declare Variable for Integer number
double myNumber = 0.0;
double myNumber2 = 0.0;

// Declare Variable for recieve the number
string userInput = Console.ReadLine();
Console.WriteLine("and");
string userInput2 = Console.ReadLine();

// Parse the String into Integer Number for int variable
myNumber = double.Parse(userInput, CultureInfo.InvariantCulture);
myNumber2 = double.Parse(userInput2, CultureInfo.InvariantCulture);


// variable that using 
double sumNumber = myNumber + myNumber2;
sumNumber = Math.Round(sumNumber, 2);

Console.WriteLine($"The sum result of {myNumber.ToString(CultureInfo.InvariantCulture)} and {myNumber2.ToString(CultureInfo.InvariantCulture)} is \n{sumNumber.ToString(CultureInfo.InvariantCulture)}");

// Enter any key to exit
Console.WriteLine("Press any key to Exit");
Console.ReadKey();