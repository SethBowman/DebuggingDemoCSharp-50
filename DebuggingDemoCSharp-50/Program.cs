
//Compile-time errors
//int number = "Seth";

//runtime errors
//throw exceptions

// Console.WriteLine("Give me a number");
//
// var userInput = int.Parse(Console.ReadLine());
//
// Console.WriteLine(userInput);

// var numbers = new int[] { 1, 2, 3, 4 };
//
// Console.WriteLine(numbers[10]);


//logical errors

var name = "bob";
var age = 50;

Console.WriteLine($"Hello my name is {age} and I am {name} years old");

//<-- put a breakpoint here
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}