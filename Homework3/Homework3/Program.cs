//Rachel Reich
//Touro ID:T00416601

//display header
Console.WriteLine("N \tN^2 \tN^3 \tN^2 + N^3");

//variable to hold end condition
var endCondition = "";

//variable for number to work with. Starts out with value of ten
int n = 10;

//as long as user doesn't type 'x', keep looping
while (!endCondition.ToLower().Equals("x"))
{
    //loop five times to display five rows
    for (int x = 0; x < 5; x++)
    {
        //variable to hold n squared
        int nSquared = n * n;
        
        //variable to hold n cubed
        int nCubed = nSquared * n;
        
        //display n, n squared, n cubed and their sum
        Console.WriteLine(n + "\t" + nSquared + "\t" + nCubed + " \t" + (nSquared + nCubed));
        
        //increment n by ten
        n += 10;
    }
    
    //get users input to either continue displaying or to finish
    Console.WriteLine("Press any key to continue, or x to end. ");
    endCondition = Console.ReadLine();
}

