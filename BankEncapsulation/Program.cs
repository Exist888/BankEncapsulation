namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiate UserInputATM Class
            var atm1 = new UserInputAtm();
            
            //New variable userAccount instantiates BankAccount Class
            var userAccount = new BankAccount();
            
            //atm1 Instance of Class UserInput Calls Select Option Method from Same Class
            //Then passes in userAccount Instance of BankAccount Class as parameter into Select Option Method
            //Syntax Notes to Self - classInstantiationName.MethodName(variable/parameters)
            atm1.SelectOption(userAccount);   
            
            
            
            
            //_______________________________________________
            //Previous Version - Simpler App without Loop - Commented Out
            //New variable currentBalance calls GetBalance Method - Skips Deposit for now
            //var currentBalance = userAccount.GetBalance();
            
            //TEMP - Comment out for now, experiment with user input
            // Console.WriteLine(currentBalance);
            
            //Call Deposit Method, attached to userAccount instance of BankAccount
            // userAccount.Deposit(431.74);
            
            //Call Get Balance Method, this time after Deposit
            // currentBalance = userAccount.GetBalance();
            
            //TEMP - Comment out for now, experiment with user input
            //Console.WriteLine(currentBalance);
        }
    }
}
