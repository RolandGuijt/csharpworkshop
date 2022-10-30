// See https://aka.ms/new-console-template for more information
var position = 0;
var turnNo = 0;
var snakes = new int[] { 11, 21, 28, 40, 51, 71, 78};
var ladders = new int[] { 1, 15, 42, 47, 49, 56, 64, 90 };

while (position < 100)
{
    turnNo = turnNo + 1;

    Console.WriteLine($"You're at square {position}.");
    Console.WriteLine("Press a key to roll the die!");
    Console.ReadKey();
    
    var dieRoll = new Random().Next(6) + 1;
    var newPosition = position + dieRoll;
    
    Console.WriteLine($"You rolled a {dieRoll}. That gets you to square {newPosition}.");
    
    if (snakes.Contains(newPosition))
    {
        newPosition = newPosition - 10;
        Console.WriteLine("But there's a snake there! You're pushed back!");
    }
    if (ladders.Contains(newPosition))
    {
        newPosition = newPosition + 10;
        Console.WriteLine("But a ladder takes you higher!");
    }
    
    position = newPosition;
}
Console.WriteLine($"You made it to 100 in {turnNo} turns. Congratulations!");
