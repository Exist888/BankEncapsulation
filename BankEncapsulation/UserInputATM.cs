using System.Net;

namespace BankEncapsulation;

public class UserInputAtm
{
    public void SelectOption(BankAccount userAccount)
    {
        Console.WriteLine("Welcome to our virtual ATM.\n" +
                          "");
        
        while (true)
        {
            Console.WriteLine("Please type one of the following options:\n" +
                              "1. Check Balance\n" +
                              "2. Make Deposit\n" +
                              "3. Exit");
            
            var parsedSuccess = int.TryParse(Console.ReadLine(), out var userSelection);

            if (parsedSuccess == false)
            {
                Console.WriteLine("Your response is not valid.");
                                  
                continue;
            }

            switch (userSelection)
            {
                case 1:
                    Console.WriteLine($"You current balance is {userAccount.GetBalance():F2}.");
                    break;
                case 2:
                    Console.WriteLine($"What is the amount of your deposit?");
                    var depositAmountSuccess = double.TryParse(Console.ReadLine(), out var depositAmount);

                    if (depositAmountSuccess == false)
                    {
                        Console.WriteLine("Your response is not valid.\n" +
                                          "Please select option 2 again below.\n" +
                                          "Then enter a dollar amount,\n" +
                                          "a decimal point,\n" +
                                          "and two digits for cents.");
                        continue;
                    }
                    userAccount.Deposit(depositAmount);
                    Console.WriteLine($"Your deposit has been approved.");
                    break;
                case 3:
                    Console.WriteLine("Thank you for using our Virtual ATM. Remember to take your card.");
                    return;
                default:
                    Console.WriteLine("Please type either 1, 2, or 3.");
                    break;
            }
        }
        
        
        
        
        
    }
}