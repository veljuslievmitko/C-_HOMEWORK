// Take one string from the input and print its last 5 characters.
Console.WriteLine("Enter string with minimum 5 caracthers");



while (true)
{
    string inputString = Console.ReadLine();

    if (inputString.Length < 5)
    {
        Console.WriteLine("you entered short string, please try again ");
        continue;

    }
    else
    {
        Console.WriteLine(inputString.Substring(inputString.Length - 5, 5));
        Console.WriteLine("If you want to continue press y");
        string letter = Console.ReadLine();
        if (letter == "y" || letter == "Y")
        {
            Console.WriteLine("Enter string with minimum 5 caracthers");

            continue;
        }
        else
        {
            break;
        };

    }
}


 


