
// See https://aka.ms/new-console-template for more information

Console.WriteLine("N \tN^2 \tN^3 \tN^2 + N^3");

int n = 10;
while (true)
{

    for (int x = 0; x < 5; x++)
    {
        int nn = n * n;
        int nnn = nn * n;
        Console.WriteLine(n + "\t" + nn + "\t" + nnn + " \t" + (nn + nnn));
        n += 10;
    }

    Console.WriteLine("Press any key to continue");
    Console.ReadLine();
}