using System;

class E14QuickSort
{
    static void Main ()
    {
        // Write a program that sorts an array of strings using the quick sort algorithm.
        int[] array = new int[20];
        Random randomInt = new Random ();
        Console.Write ("Array : ");
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = randomInt.Next (0, 100);
            Console.Write ("{0} ", array[index]);
        }
        Console.WriteLine ();

        quickSort (array, 0, array.Length - 1);

        Console.Write ("Sorted Array : ");
		for (int index = 0; index < array.Length; index++)
		{
			 Console.Write ("{0} ", array[index]);
		}
        Console.WriteLine ();
    }


    static int partition (int[] array, int left, int right)	
	{		
		int i = left, j = right;
		
		int temp;
        // Избира се "главен" елемент от списъка с елементи, които ще бъдат сортирани.
		int pivot = array[((left + right) / 2)];
		
		
		while (i <= j)
        {// Списъкът се пренарежда така, че всички елементи, които са по-малки от "главния" се поставят вляво от него,
			while (array[i] < pivot)
			{
				i++;
			}
            while (array[j] > pivot)// а всички, които са по-големи - вдясно от него.
			{
				j--;
			}
			if (i <= j)
			{
				
				temp = array[i];
				
				array[i] = array[j];
				
				array[j] = temp;
				
				i++;
				
				j--;
			}			
		};	
		return i;
	}
	
	
	static void quickSort (int[] array, int left, int right)
    {// Намираме списъците с по-малките и по-големите елементи, както и позицията на избрания главен елемент
		int index = partition (array, left, right);

        if (left < index - 1)// Рекурсивно сортираме елементите, по-малки от главния елемент
		{
			quickSort (array, left, index - 1);
		}
        if (index < right)// Рекурсивно сортираме елементите, по-малки или равни на главния елемент
		{
			quickSort (array, index, right);
		}
	}
}
