Console.WriteLine("Hello, World!");
var randomNumber = new Random().Next(10) + 1;
var guessed = false;
var guessNo = 1;
Console.WriteLine("Guess the number! It's in the 1-10 range.");

while (!guessed)
{
    var input = Console.ReadLine();
    var inputNumber = int.Parse(input);

    if (inputNumber == randomNumber)
    {
        Console.WriteLine($"You guessed it! It took you {guessNo} guesses!");
        guessed = true;
    }
    else
    {
        var higherLower = "higher";
        if (randomNumber < inputNumber)
            higherLower = "lower";
        Console.WriteLine($"Sorry, that's not correct. It was {higherLower}! Try again!");
        guessNo = guessNo + 1;
    }
}

