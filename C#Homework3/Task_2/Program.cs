// Take a sentence as input and print its words.


while (true)
{
    Console.WriteLine("enter a string with minimum of 5 characters:");
    string sentence = Console.ReadLine();
    if (sentence.Length < 5)
    {
        Console.WriteLine("You entered shorr string, please try again");
        continue;
    }
    else
    {

        char[] wordOfsentence = sentence.ToCharArray();

        foreach (char word in wordOfsentence)
        {
            Console.WriteLine(word);
        }
    }
}
