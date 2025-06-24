int total = 0;
Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

total += (roll1 + roll2 + roll3);
Console.WriteLine($"Rolls: {roll1}, {roll2}, {roll3}");


if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine($"You rolled a triple");
    total += 6;
}
else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    Console.WriteLine($"You rolled a double");
    total += 2;
}
if(total >= 10) Console .WriteLine($"You win with a total of {total}!");
else Console.WriteLine($"You lose with a total of {total}.");
