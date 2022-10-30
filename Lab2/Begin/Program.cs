Console.WriteLine("Hello, World!");
var randomNumber = new Random().Next(10) + 1;

Console.WriteLine("Guess the number! It's in the 1-10 range.");
var input = Console.ReadLine();
var inputNumber = int.Parse(input);

if (inputNumber == randomNumber)
    Console.WriteLine("You guessed it!");
else
{
    var higherLower = "higher";
    if (randomNumber < inputNumber)
        higherLower = "lower";
    Console.WriteLine($"Sorry, that's not correct. It was {higherLower}! {randomNumber} in fact.");
}

