using Microsoft.VisualBasic.CompilerServices;

namespace BankEncapsulation;

public class BankAccount
{
    //Field - Account Balance - Staring at 0
    private double _balance = 0;
    
    //Method - Accepts Money and Stores in Balance Field
    public void Deposit(double addMoney)
    {
        _balance = _balance + addMoney;
    }
    
    //Method - Returns Updated Balance
     public double GetBalance()
     {
         return _balance;
     }

}