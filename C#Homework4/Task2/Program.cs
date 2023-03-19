using SEDC.Homewroknumber._4.Classes;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Reflection;
using System.Xml.Linq;
using System;

/* Task 2
Make a class Driver. Add properties: Name, Level !!!
Make a class Car. Add properties: Model, Speed and Driver !!!!

Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied
by the speed of the car and return it as a result.!!!!!
Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.!!!!

Make 4 car objects and 4 driver objects.!!!!!
Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and 
call the RaceCars() methods
Test Data:
Choose a car no.1:
Hyundai
Mazda
Ferrari
Porsche
Choose Driver:
Bob
Greg
Jill
Anne
Choose a car no.2:
Hyundai
Mazda
Ferrari
Porsche
Choose Driver:
Bob
Greg
Jill
Anne
Expected Output:
Car no. 2 was faster.
BONUS 1: If a user chooses option one for the first car, eliminate that option when the user picks car two.

BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.
 
 */

while (true)
{

    string[] carForChoiceString = new string[] { "Hyundai", "Mazda", "Ferrari", "Porsche" };
    string[] driversForChoiceString = new string[] { "Tito", "Dame", "Spase", "Caki" };


    Car[] mycars = new Car[]
    {
    new Car ("Hyundai", 180),
    new Car ("Mazda", 240),
    new Car("Ferrari", 330),
    new Car ("Porsche", 343)
    };
    int indexCar1 = -1;
    int indexCar2 = -1;
    int indexDriver1 = -1;
    int indexDriver2 = -1;
    Car choosen = new Car();
    Car choosen2 = new Car();

    Driver[] driverForChoice = new Driver[]
    {
new Driver ("Tito", 20),
new Driver ("Dame", 19),
new Driver ("Spase", 21),
new Driver ("Caki", 23)
    };

    Console.WriteLine("Please choose two cars ");
    Console.WriteLine("Please choose two cars from:");

    void PrintArray(string[] arrayname)
    {
        foreach (string item in arrayname)
        {
            Console.WriteLine(item);
        }
    }


   
   
   

     while (true)
    { Console.WriteLine(" choose car n.1 from theese cars: ");
        PrintArray(carForChoiceString);
        string choiceCar1 = Console.ReadLine();
        indexCar1 = Array.IndexOf(carForChoiceString, choiceCar1);
        if (indexCar1 == -1)
        {
            Console.WriteLine("Please try again choose car n.1");
            continue;
        }
        else
        {
            Array.Fill(carForChoiceString, "", indexCar1, 1);

            choosen = mycars[indexCar1];
            break;
        }
    }

    while (true) { 
            Console.WriteLine(" choose car n.2 from theese cars");
            PrintArray(carForChoiceString);
       
            string choiceCar2 = Console.ReadLine();
            indexCar2 = Array.IndexOf(carForChoiceString, choiceCar2);
            if (indexCar2 == -1)
            {
                
                Console.WriteLine("Please try again and choose car n.2");
                continue;
            }
            else
            {
                choosen2 = mycars[indexCar2];
                                break;
            }

        
    }
    Console.WriteLine("Please choose two drivers ");
    Console.WriteLine();
    Console.WriteLine("Please choose driver for the first car:");
  

    while (true)
    {
      Console.WriteLine(" choose driver for car n.1 from theese drivers");
         PrintArray(driversForChoiceString);
        string choiceDriver1 = Console.ReadLine();
        indexDriver1 = Array.IndexOf(driversForChoiceString, choiceDriver1);
        if (indexDriver1 == -1)
        {
            Console.WriteLine("You choose wrong driver Please try again");
            continue;
        }
        else
        {
            Array.Fill(driversForChoiceString, "", indexDriver1, 1);
            break;
        }
    };


    while (true) { 
            Console.WriteLine(" choose Driver for car n.2 from theese drivers");
         PrintArray(driversForChoiceString);
             string choiceDriver2 = Console.ReadLine();
            indexDriver2 = Array.IndexOf(driversForChoiceString, choiceDriver2);
            if (indexDriver2 == -1)
            {
                Console.WriteLine("Please try again");
                continue;
            }
            else { break; }

     };
    
    choosen.Driver = driverForChoice[indexDriver1];
    choosen2.Driver = driverForChoice[indexDriver2];
    Console.WriteLine(  );

    Console.WriteLine("The chosen cars are:");
    Console.WriteLine(choosen.Model);
    Console.WriteLine(choosen2.Model);
    Console.WriteLine();
    Console.WriteLine("====lets race now=================");
    Console.ForegroundColor = ConsoleColor.Green;

    while (true)
    {
        choosen.raceCars(choosen2);
        Console.WriteLine("If you want to try the race again pres 'y'");
        string controlKey = Console.ReadLine();
        if (controlKey == "Y" || controlKey == "y")
        {
            continue;
        }
        else { break; }

    }
    Console.ResetColor();

    Console.WriteLine("If you are not satisfay with the race cars and drivers you can try again from the start \n " +
        "if you want to try the race again pres 'y'");
    string controlKey1 = Console.ReadLine();
    if (controlKey1 == "Y" || controlKey1 == "y")
    {
        continue;
    }
    else { break; }
}


 