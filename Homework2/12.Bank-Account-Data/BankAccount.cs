using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("Client Account");
        Console.WriteLine();
        string firstName = "Asen";
        string middleName = "Stoilov";
        string lastName = "Bojilov";
        decimal money = 80.0m;
        Console.WriteLine("First Name:{0} \nMiddle Name:{1} \nLast Name:{2} \nAvailable amount of money:{3}",firstName,middleName,lastName,money);
        Console.WriteLine();
        string bank = "My Bank OOD";
        long iban = 54621645951;
        long creditc1 = 65165156546;
        long creditc2 = 54166315665;
        long creditc3 = 36656521565;
        Console.WriteLine("Name of Bank:{0} \nIBAN:{1} \nCredit card number:{2} \nCredit card number:{3} \nCredit card number:{4}",bank,iban,creditc1,creditc2,creditc3);
    }
}

