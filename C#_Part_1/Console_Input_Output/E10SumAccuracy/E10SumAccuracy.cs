using System;

class E10SumAccuracy
{
    static void Main ()
    {
        double count = 2;
        double sum = 1;
        int sign = 1;

        while ((1 / count) > 0.001)
        {
            sum = sum + (1 / count) * sign;
            sign = sign * (-1); // променя знака пред числото
            count++;
        }
        Console.WriteLine("sum = {0:0.000}", sum);   
    }
}
