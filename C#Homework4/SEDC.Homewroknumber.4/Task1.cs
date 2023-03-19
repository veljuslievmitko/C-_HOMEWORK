#region Task text
/*Task 1
Create a class Human
Add properties: FirstName, LastName, Age !!!
Create a method called GetPersonDetails that returns the full name of the human as well as their age !!!
Create an object human by asking the user to fill the required information (take first name, last name and age from user input)!!!
Call the GetPersonDetails method and print the result in the console after the object is created !!!
*/


#endregion

#region 

using SEDC.Homewroknumber._4.Classes;

int ageFromInput = 0;
Console.WriteLine("Please enter name, last name and age");
string nameFromInput = Console.ReadLine();
string lnameFromInput = Console.ReadLine();
while (true) {
    bool ifParsed = int.TryParse(Console.ReadLine(), out ageFromInput);
    if (ifParsed == false)
    {
        Console.WriteLine("You entered wrong number,");

    }
    else {
        break;
            }
}

Human human1 = new Human(nameFromInput, lnameFromInput, ageFromInput);
human1.GetPersonDetails();


#endregion