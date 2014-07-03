using System;

class E2CirclePerimeterArea
{
    static void Main ()
    {
        double radius = -1; // радиус на кръга

        do // повтаря докато се въведе нула или положително число
        {
            Console.Write ("Please enter radius of circle:");
            radius = enterNum (Console.ReadLine ());
        }while (radius < 0);

        double perimeter = Math.PI * radius;
        Console.WriteLine ("The perimeter of the circle is : {0}", perimeter);

        double area = Math.PI * radius * radius;
        Console.WriteLine ("The area of the circle is : {0}", area);
    }


    private static int enterNum (string value) // проверява дали е въведено число
    {
        int number = 0;
        bool result = Int32.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return -1; //Ако не е число връща -1
        }
    }
}
