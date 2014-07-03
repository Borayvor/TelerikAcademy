using System;

class E15PrimeNumbers
{
    static void Main ()
    {
        // Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm.
        runEratosthenesSieve (10000000);
    }


    public static void runEratosthenesSieve (int upperBound)
    {   // Идеята на алгоритъма е, че ако намерим просто число n, то всяко n-то след него няма да е просто.        
		int upperBoundSquareRoot = (int) Math.Sqrt (upperBound);
        
		bool[] isComposite = new bool[upperBound + 1];
		
		int count = 0;
		
		for (int value = 2; value < upperBoundSquareRoot; value++)
        {	// Ако числото x е задраскано, преминаваме към следващото.		
			if (!isComposite[value])
			{
				count++;				
				Console.Write (value + " ");
				
				if (count >= 10)
				{
					Console.WriteLine ();					
					count = 0;
				}
			}
            // Ако x е незадраскано, то задължително всички кратни на х, по-малки от x.2, ще са задраскани от стъпките
            // на простите числа по-малки от х. Следователно стигайки до просто число, първото което задраскваме може 
            // да е неговия квадрат. Така спестяваме по x-2 стъпки за всяко просто число x, за сметка на повдигане на 
            // x на квадрат.
				for (int element = value * value; element <= upperBound; element += value)
				{
					isComposite[element] = true;
				}		
		}		
		Console.WriteLine ();

		for (int value = upperBoundSquareRoot; value <= upperBound; value++)
        {   // Aко в главния цикъл на итерацията си стигнем корена на горната граница n, то задължително
            // всички незадраскани числа след него, до n са прости.
			if (!isComposite[value])
			{
				count++;				
				Console.Write (value + " ");
				
				if (count >= 10)
				{
                    Console.WriteLine ();					
					count = 0;
				}
			}
		}
	}
}
