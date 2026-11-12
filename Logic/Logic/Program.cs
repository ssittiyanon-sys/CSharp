bool isRainy = false;
bool hasUmbrella = false;

// Logical Operator
// AND &&
// OR ||
// NOT !

if (!isRainy || hasUmbrella)
{
    Console.WriteLine("i'M GETTING WET!");
}
Console.WriteLine("Ay oOK!");


int num1 = 5;
int num2 = 6;





// relational operator < <= > >=
// !=

bool isGreater = num1 < num2;    // 5 < 6 = true;
bool isLesstan = num1 > num2;     // 5 > 6 = false;

int age = 15;
bool isWithParents = true;

if(age >= 13 && isWithParents)
{
    Console.WriteLine("Go party in the Club with your parents");
}
else if (age >= 18)
{
    Console.WriteLine("Go party in Club!!");
}
else 
{
    Console.WriteLine("Go party in school!!");
}


Console.ReadKey();