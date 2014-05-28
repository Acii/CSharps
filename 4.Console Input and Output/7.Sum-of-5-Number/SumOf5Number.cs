using System;

class SumOf5Number
{
    static void Main()
    {
        string a = Console.ReadLine();

        string[] nums = a.Split(new char[] { ' ' });
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += double.Parse(nums[i]);
        }

        Console.WriteLine(sum);
        
    }
}

