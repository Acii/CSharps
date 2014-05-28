using System;

class Information
{
    static void Main()
    {
        Console.WriteLine("Company");
        Console.Write("Name: ");
        string nameCompany = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web: ");
        string web = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Manager");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company \nName:{0} \nAddress:{1} \nPhone:{2} \nFax Number:{3} \nWeb:{4}",
            nameCompany, address, phone, faxNumber, web);
        Console.WriteLine();
        Console.WriteLine("Manager \nFirst Name:{0} \nLast name:{1} \nAge:{2} \nPhone number:{3}",
            firstName, lastName, age, phoneNumber);
    }
}

