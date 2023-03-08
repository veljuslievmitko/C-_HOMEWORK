#region task1 

#region 

//Make a console application called SumOfEven. Inside it create an array of 6 integers. 
//    Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14
#endregion
#endregion

//int[] sumOfEven = new int [6];
//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine ($"Enter number {i + 1}");
//    bool ifParsed = int.TryParse(Console.ReadLine(), out int number);
//    if (!ifParsed)
//    {
//        Console.WriteLine("you entered wrong character, please restar the program");
//        return;
//    }
//    else
//    {

//        sumOfEven[i] = number;
//     }   
//}

//int sum = 0;
//foreach (int number in sumOfEven)
//{   

//    if(number%2 == 0)
//    {
//        sum += number;
//    }
//}
//Console.WriteLine(sumOfEven[5]);
//if (sumOfEven.Length == 6)
//{
//    Console.WriteLine("the sum of even number is:" + sum);
//}


//bool input1 = int.TryParse(Console.ReadLine(), out int number1);
//bool input2 = int.TryParse(Console.ReadLine(), out int number2);
//bool input3 = int.TryParse(Console.ReadLine(), out int number3);
//bool input4 = int.TryParse(Console.ReadLine(), out int number4);
//bool input5 = int.TryParse(Console.ReadLine(), out int number5);
//bool input6 = int.TryParse(Console.ReadLine(), out int number6);




#region task2

#region 
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko
#endregion

string[] studentG1 = new string[] { "Goce", "Dame", "Nikola", "Pitu", "Sando"};
string[] studentG2 = new string[] { "Nikola", "Branko", "Ljupco", "Micko", "Zajko" };
Console.WriteLine("Please write a number between 1 and 2:");
 double.TryParse(Console.ReadLine(), out double numberForString); // dali ova e dobra praksa ??
if (numberForString >= 1 && numberForString <= 2)
{
    
    if (numberForString < 1.51)
    {
        foreach (string item in studentG1)
        {
            Console.WriteLine(item);
        }

    }
    else
    {
        foreach (string item in studentG2)
        {
            Console.WriteLine(item);
        }
    }
}
else
{
    Console.WriteLine("You entered wrong Character or your Number is not between 1 and 2!!");
}


#endregion