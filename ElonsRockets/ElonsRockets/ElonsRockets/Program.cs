var rocket = new Rocket();

Console.WriteLine("Press a key to launch the rocket");
Console.ReadKey();
rocket.Launch();
Console.WriteLine("Launched!");
Console.WriteLine("Press a key to see the status of the rocket, q to quit, l to land");

while (true)
{
    var key = Console.ReadKey();
    if (key.KeyChar == 'q')
        break;
    if (key.KeyChar == 'l')
        rocket.Land();
    Console.WriteLine($"The status is: {rocket.Status}.");
}

