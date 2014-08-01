namespace Problem02AstrologicalDigits
{
    using System;


    public class AstrologicalDigits
    {
        public static void Main(string[] args)
        {
            string inputNumber = null;
            int result;

            inputNumber = Console.ReadLine();

            do
            {
                result = 0;

                for(int index = 0; index < inputNumber.Length; index++)
                {
                    if(inputNumber[index] != '-' && inputNumber[index] != '.')
                    {
                        result += int.Parse(inputNumber[index].ToString());
                    }
                }

                inputNumber = result.ToString();

            } while(result > 9);

            Console.WriteLine(inputNumber);
        }
    }
}
