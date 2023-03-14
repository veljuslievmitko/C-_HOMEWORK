//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today


while (true)
{
    Console.WriteLine("enter your birth date in format (yyyy. mm. dd):");
    bool ifParsed = DateTime.TryParse(Console.ReadLine(), out DateTime input);
    if (ifParsed == false)
     {
        Console.WriteLine("You enterd wrong format, please try again");
        continue;
    }
    else
    {
        AgeCalculator(input);
        
    }
    Console.WriteLine("If you want to leave the program press 'y', other press any key ");
    bool ifBreakParsed = char.TryParse(Console.ReadLine(), out char ifBreak);
    if (ifBreak == 'y' || ifBreak == 'y')
    {
        break;
    }

}


void AgeCalculator(DateTime input)
{
  
  DateTime nowDate = DateTime.Now;
 
 
    int age = nowDate.Year - input.Year;
int days = nowDate.DayOfYear - input.DayOfYear;
Console.WriteLine(days);


int years = (days >= -1) ? years = age : years = age - 1;
Console.WriteLine($" You are {years} old ");
    
}






