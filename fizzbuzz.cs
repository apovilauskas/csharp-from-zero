for (int i = 0; i < 100; i++)
{
    string ats = "";
    if (i % 3 == 0) ats += "fizz";
    if (i % 5 == 0) ats += "buzz";

    Console.WriteLine(ats == "" ? i : ats);

}
