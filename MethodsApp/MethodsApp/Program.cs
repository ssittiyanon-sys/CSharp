//Methods art structured like this
//modifier returnType MethodName(Parameters){
// code block
//}
/*
// Definition of a "void" method that returns nothing
void MyFirstMethod()
{
    Console.WriteLine("MyFirstMethod was called");
    Console.WriteLine("Some super complicated code");
}

//Calling a Method
MyFirstMethod();
MyFirstMethod();
MyFirstMethod();
MyFirstMethod();

Console.WriteLine("This is outside of the medthod\n");

//Parameter

void WriteSomething()
{
    Console.WriteLine("I'm writhing something!");
}

WriteSomething();

void WriteSomethingSpecific(string myString)
{
    Console.WriteLine("You passed this argument to me " + myString);
}
string myUsername = "Rujipe";
WriteSomethingSpecific(myUsername);
*/


int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    // จะเอา result ออกมา ก็ต้องใช้ return
    return result;
}
Console.WriteLine("Enter first number.");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number.");
int num2 = int.Parse(Console.ReadLine());

int myResult = AddTwoValues(num1, num2);
Console.WriteLine($"The result is : {myResult}");

Console.ReadKey();