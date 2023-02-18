// See https://aka.ms/new-console-template for more information
//Rachel Reich
//Touro ID: T00416601

//variables to hold length and width
int length, width;

//get length from user
Console.WriteLine("Enter measurements for a triangle:");
Console.WriteLine("Length (between 1 and 15): ");
length = Convert.ToInt16(Console.ReadLine());

//if user enters invalid value, reset the length
switch (length)
{
    case < 1:
        length = 1;
        Console.WriteLine("Invalid. By default, length set to 1");
        break;
    case > 15:
        length = 15;
        Console.WriteLine("Invalid. By default, length set to 15");
        break;
}

//get width from user
Console.WriteLine("Width (between 1 and 10)");
width = Convert.ToInt16(Console.ReadLine());

//if user enters invalid value, reset the width
switch (width)
{
    case < 1:
        width = 1;
        Console.WriteLine("Invalid. By default, width set to 1");
        break;
    case > 10:
        width = 10;
        Console.WriteLine("Invalid. By default, length set to 105");
        break;
}

//display a rectangle of asterisks according to users width and length 
for (int x = 0; x < width; x++)
{
    for (int y = 0; y < length; y++)
    {
        Console.Write("*  ");
    }
    Console.WriteLine();
}
