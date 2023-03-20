

using Domain.Classes;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Threading.Channels;
#region
//Create an ATM application. A customer should be able to authenticate with card number and pin and should be
//greeted with a message greeting them by full name. After that they can choose one of the following:

//Balance checking - This should print out the current balance of money on their account
//Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough
//it should print a success message that contains the money withdrawn and the balance of money after the withdrawal
//Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the
//account after the deposit.
//In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches
//through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome
//message is shown and the customer can now choose the options.

//Example
//Welcome to the ATM app
//Please enter your card numer:
//> 1234 - 1234 - 1234 - 1234
//Enter Pin:
//> 4325
//Welcome Bob Bobsky!
//What would you like to do:
//Check Balance
//Cash Withdrawal
//Cash Deposit
//> 2
//You withdrew 250$. You have 400$ left on your account.
//Thank you for using the ATM app.
//Bonus: The balance and pin should not be public

//Bonus: The ATM card number to be a number instead of a string. The user should still input 1234-1234-1234-1234.

//Bonus: When the Customer finishes with a transaction a question must pop up if the Customer wants to do another action.
//If not it should print a goodbye message and show up the login menu again.

//Bonus: Add an option to register a new card in the system that store the customer in the system if the card number
//is not used for any other customer
#endregion




// Ja napraviv so proverka na ime i prezime, i sega da se vrakam za proverka so karticka ke bide malku nogo
// POO-ZDRAV


Customer[] database = new Customer[]
{
    new Customer("Angel", "Mitrov", new Card(1234123412341234, 100)),
    new Customer("John", "Doe", new Card(4321432143214321, 1000)),
    new Customer("Majkl", "Jordan",new Card(2001512, 1000254)),
    new Customer("Naum", "Petrevski", new Card(123456, 1000)),
    new Customer("Dino", "Merlin", new Card(20000002, 1000000000)),

};
Console.WriteLine(database.Length);
Console.WriteLine(database[4].Firstname); 


foreach (Customer customer in database)
{
    customer.GetCustomerInfo();
}




Customer customerForServing = new Customer();
bool whileBool = true;
while (whileBool)
{
    Console.WriteLine("Please enter your name:");
    string userNameFromInput = Console.ReadLine();
    Console.WriteLine("Please enter your last name");
    string userLNameFromInput = Console.ReadLine();
    int pin = 0;
    Console.WriteLine("Pealse enter your pin code");
    while (true)
    {
        bool ifParsed = int.TryParse(Console.ReadLine(), out int pin1);
        if (ifParsed)
        {
            pin = pin1;
            break;
        }
        else
        {
            Console.WriteLine("Please write pin again:");
            continue;
        }
    }
    int counterForcheckIfCustomerIsInBase = 0;
    for (int i = 0; i < database.Length; i++)
    {

        if (userNameFromInput == database[i].Firstname && userLNameFromInput == database[i].Lastname && pin == database[i].Card.GetCardPin())
        {
            Console.WriteLine($"Welcome{userLNameFromInput}{userLNameFromInput} to ypur account. Now you have {String.Format(" Money:{0:C}", database[i].Card.GetYourBalance())} ");
            customerForServing = database[i];
            whileBool = false;
            break;
        }
        else
        {
            counterForcheckIfCustomerIsInBase++;
        }

    }
    if (counterForcheckIfCustomerIsInBase == database.Length)
    {
        Console.WriteLine("You entered wrong inputs please try again");
    }
}
bool whileBool1 = true;

while (whileBool1)
{
    Console.WriteLine("Please choose one of following activity:");
    Console.WriteLine("To check your balance press '1' \n" +
    "To Withdrawal money press '2'\n" +
    "To deposit money press '3'\n" +
    "To enter new card press '4'\n" +
    "To exit press any key");
    string choice = Console.ReadLine();
    int moneyOnAccount = customerForServing.Card.GetYourBalance();
    switch (choice)
    {
        case "1":
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"On your account you have {String.Format("{0:C}", customerForServing.Card.GetYourBalance())} ");
                Console.ResetColor();
                break;
            }
        case "2":
            {
                bool choice2 = true;
                while (choice2)
                {
                    Console.WriteLine("write how much money you would like to withdraw:");
                    bool ifParsedMoney = int.TryParse(Console.ReadLine(), out int moneyWithdraw);
                    if (ifParsedMoney)
                    {
                        if (moneyWithdraw < moneyOnAccount)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"You can withdraw your money");
                            customerForServing.Card.WithdrowMoney(moneyWithdraw);
                            Console.WriteLine($"On your account you have {String.Format("{0:C}", customerForServing.Card.GetYourBalance())} ");
                            Console.ResetColor();
                            choice2 = false;


                        }
                        else
                        {   
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine($"You dont have enough money on your account, you have " +
                            $"{String.Format("{0:C}", customerForServing.Card.GetYourBalance())} ");
                            Console.ResetColor();
                            choice2 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                }
                break;
            }
        case "3":
            {
                bool choice3 = true;
                while (choice3)
                {
                    Console.WriteLine($"On your account you have {String.Format("{0:C}", customerForServing.Card.GetYourBalance())} ");
                    Console.WriteLine("How much money you want to deposit");
                    bool ifParsedMoneyForDeposit = int.TryParse(Console.ReadLine(), out int moneyForDeposit);
                    if (ifParsedMoneyForDeposit)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        customerForServing.Card.WithdrowMoney(-moneyForDeposit);
                        Console.WriteLine($"On your account you have {String.Format("{0:C}", customerForServing.Card.GetYourBalance())} ");
                        choice3 = false;

                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                }
                break;

            }

        case "4":
            {

                bool whileBool4 = true;
                while (whileBool4)
                {
                    Console.WriteLine("Please enter the number of card that you want to register");
                    bool ifparsedNumberCard = int.TryParse(Console.ReadLine(), out int inputCardNumber);
                    int CardIncludetInDataBase = -1;


                    for (int i = 0; i < database.Length; i++)
                    {

                        if (inputCardNumber == database[i].Card.Number)
                        {
                            Console.WriteLine("You card already exists, try with another card");
                            break;
                        }
                        else
                        {
                            CardIncludetInDataBase = -1;
                        }


                    }
                    if (CardIncludetInDataBase == -1)
                    {

                        while (true)
                        {
                            Console.WriteLine("Enter your balance on this card");
                            bool IfParsedBalance = int.TryParse(Console.ReadLine(), out int balanceForNewCard);
                            if (IfParsedBalance)
                            {
                                customerForServing.Card = new Card(inputCardNumber, balanceForNewCard);
                                whileBool4 = false;
                                break;
                            }
                            else
                            { continue; }

                        }
                    }

                }
                    break;
            }
            default: 
            {
                    Console.WriteLine("Thank you for using our ATM");
                    whileBool1 = false;
                    break;

                
            }

    }

    // returning the data to the dataBase 
    for (int i = 0; i < database.Length; i++)
    {
        if (customerForServing.Firstname == database[i].Firstname)
        {

            database[i] = customerForServing; 
         break;
        }
       


    }
}
foreach (Customer customer in database)
{
    customer.GetCustomerInfo();
}
