namespace E04Homework
{
    using System;



    class TestPerson
    {
        static void Main ()
        {
            // Create a class Person with two fields – name and age. Age can be left unspecified (may contain null 
            // value. Override ToString() to display the information of a person and if age is not specified – to 
            // say so. Write a program to test this functionality.
            Person pesho = new Person ("Pesho", 67);

            Person gosho = new Person ("Gosho");

            Console.WriteLine (pesho + "\r\n\n" + gosho);
        }
    }
}
