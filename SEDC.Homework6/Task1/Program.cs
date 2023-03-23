
#region Text
/*
 Give the user an option to input numbers
After inputing each number ask them if they want to input another with a Y/N question
Store all numbers in a QUEUE
When the user is done adding numbers print the numbers in the order that the user entered them from the QUEUE
*/
#endregion
Queue<int> queueFronUser = new Queue<int>();
while (true)
{
    while (true)
    {
        Console.WriteLine("Please enter numbers");

        
        bool ifParsed = int.TryParse(Console.ReadLine(), out int inputNumber);
        if (ifParsed)
        {
            queueFronUser.Enqueue(inputNumber);
            break;

        }
        else
        {
            continue;
        }
    }




    Console.WriteLine("If you want to exit press 'Y' if you  want to continue press any key");
    string control = Console.ReadLine();
    if (control == "Y" || control == "y" ){
        break;
    }
}

foreach (int item in queueFronUser)
{
    Console.WriteLine(item);
}