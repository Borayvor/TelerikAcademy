using System;

class E7PrimeNumbers
{
    static void Main ()
    {
        Console.Write ("Please enter a number to check if it is prime number: ");
        int n = Int32.Parse (Console.ReadLine ());

        if (isPrime (n))
        {
            Console.WriteLine ("{0} is prime number.", n);
        }
        else
        {
            Console.WriteLine ("{0} is composite number.", n);
        }
    }


    static bool isPrime (int number)
    {
        if (number % 2 == 0) return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
