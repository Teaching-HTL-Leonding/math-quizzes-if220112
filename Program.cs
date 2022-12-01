System.Console.WriteLine("Please enter a number: ");
int number1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Please enter a second number: ");
int number2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Please enter the result of the two numbers: ");
int result = int.Parse(Console.ReadLine()!);



 if (number1 * number2 == result || number2 * number1 == result)
{
System.Console.WriteLine("The two numbers are multiplied");
}

else if (number1 + number2 == result || number2 + number1 == result)
{
System.Console.WriteLine("The two numbers are added ");
}

else if (number1 / number2 == result || number2 / number1 == result)
{
System.Console.WriteLine("The two numbers are divided ");
}

else if (number1 - number2 == result || number2 - number1 == result)
{
System.Console.WriteLine("The two numbers are subtracted ");
}



