using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.Write("numbers : ");
        string number = Console.ReadLine();
        string[] line = number.Split(new char[] { ' ' });
        double oddProduct = 1;
        double evenProduct = 1;
        for (int i = 0; i < line.Length; i +=2 )
        {
            oddProduct *= double.Parse(line[i]);

        }
        for (int u = 1; u < line.Length; u += 2)
        {
            evenProduct *= double.Parse(line[u]);
        }
        if(oddProduct == evenProduct)
        {
            Console.WriteLine("yes \nProduct = " + oddProduct);
        }
        else
        {
            Console.WriteLine("no \nOdd_product = {0} \nEven_product = {1}", oddProduct, evenProduct);
        }
    }
}

