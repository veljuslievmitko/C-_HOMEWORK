#region Task#1 Real Calaculator
//Create new console application “RealCalculator” that takes two numbers 
// from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25


//Console.WriteLine("enter operation");
//bool operationParsed = char.TryParse(Console.ReadLine(), out char operation);



//if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
//{
//    Console.WriteLine("you entered wrong operation, restart the program");
//}
//else
//{
//    Console.WriteLine("enter two numbers:");
//     bool numberParse1 = double.TryParse(Console.ReadLine(), out double number1);

//     bool numberParse2 = double.TryParse(Console.ReadLine(), out double number2);  
//     double sum = 0;



//    if (numberParse1 && numberParse2)
//    {

//        if (operationParsed)
//        {
//            switch (operation)
//            {
//                case '+':
//                    sum = number1 + number2;

//                    break;
//                case '-':
//                    sum = (number1 - number2);
//                    break;
//                case '*':
//                    sum = (number1 * number2);
//                    break;
//                case '/':
//                    sum = (number1 / number2);
//                    break;


//            }

//        }
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("You entered wrong numbers, plesae restart the program and try again");
//    }
//}


#endregion


#region Task #2 avarage number
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18


//Console.WriteLine("enter four numbers: ");
//bool ifParsed1 = double.TryParse(Console.ReadLine(), out double a);
//bool ifPased2 = double.TryParse(Console.ReadLine(), out double b);
//bool ifParsed3 = double.TryParse(Console.ReadLine(), out double c);
//bool ifParsed4 = double.TryParse(Console.ReadLine(), out double d);
//if (ifParsed1 && ifPased2 && ifParsed3 && ifParsed4)
//{

//    Console.WriteLine($"Avarage number is {(a + b + c + d) / 4}");
//}
//else
//{
//    Console.WriteLine("You entered wrong caracther. Pleace enter just numbers");
//}

#endregion

#region Task#3 Swap numbers
#region task
//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap
//the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

#endregion

//Console.WriteLine("enter Firts number: ");
//bool ifParsed31 = double.TryParse(Console.ReadLine(), out double number1);
//if (ifParsed31 == false)
//{
//    Console.WriteLine("you enterd wrong caracter, please restart the program");
//}
//else
//{
//    Console.WriteLine("enter Second number: ");
//    bool ifParsed32 = double.TryParse(Console.ReadLine(), out double number2);

//    if(ifParsed32 == false)
//    {
//        Console.WriteLine("you enterd wrong caracter, please restart the program");
//    }
//    else
//    { 
//      Console.WriteLine("Press any key and you will see MAGIC!!!!!");
//      Console.ReadKey();
//    double temporary = number1;
//    number1 = number2;
//    number2 = temporary;
//    Console.WriteLine($"number 1 before swap was {temporary} after swap is " + number1);
//    Console.WriteLine($"number 2 before swap was {number1} after swap is " + number2);
//    }
//}
#endregion