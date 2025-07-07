int herojausGyvybes = 10;
int monstroGyvybes = 10;

Random ataka = new Random();
while (herojausGyvybes > 0 && monstroGyvybes > 0)
{

    int padare = ataka.Next(1, 6);
    monstroGyvybes -= padare;
    Console.WriteLine($"Monstras prarado {padare} gyvybes, liko {monstroGyvybes}");
    if (monstroGyvybes <= 0) break;

    padare = ataka.Next(1, 6);
    herojausGyvybes -= padare;
    Console.WriteLine($"Herojus prarado {padare} gyvybes, liko {herojausGyvybes}");
    if (herojausGyvybes <= 0) break;

}

if (herojausGyvybes > 0) Console.WriteLine("Herojus laimi");
else Console.WriteLine("Monstras laimi");
