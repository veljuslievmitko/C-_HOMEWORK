// Create a function that takes a number as input. This method should return the sum of the digits in the number.

while (true)
{
    Console.WriteLine("please enter a number:");
    string numberString = Console.ReadLine();
    bool ifPased31 = int.TryParse(numberString, out int inputNumber);
    if (ifPased31 == false)
    {
        Console.WriteLine("You entered wrong input, please try again");
        continue;
    }
    else
    {
        int sum = 0;
        while (inputNumber > 0)
        {
            int helper = inputNumber % 10;
            sum = sum + helper;
            inputNumber = inputNumber / 10;
        }
        Console.WriteLine(sum);
    }
    Console.WriteLine("If you want to leave the program press 'y', other press any key ");
    bool ifBreakParsed = char.TryParse(Console.ReadLine(), out char ifBreak);
    if (ifBreak == 'y' || ifBreak == 'y') 
    {
        break;
    }
}

