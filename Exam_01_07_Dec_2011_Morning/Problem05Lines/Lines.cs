namespace Problem05Lines
{
    using System;
    using System.Text;

    public class Lines
    {
        public static void Main(string[] args)
        {
            string sequenceOfBytes = null;
            int numberOfBytes = 8;
            int numberOfBits = 8;
            int sequenceOfFullCellsLength = 0;            
            int numberOfTheLongestSequences = 0;
            int countOfSequences = 0;

            StringBuilder strBuilder = new StringBuilder();

            for(int indexSeq = 0; indexSeq < numberOfBytes; indexSeq++)
            {
                strBuilder.Clear();
                //// convert to binary number, then convert to string, and then add to 'currentNumber'
                string currentNumber = Convert.ToString((int.Parse(Console.ReadLine())), 2);
                //// complement binary number up to eight digits
                for(int index = 0; index < numberOfBits - currentNumber.Length; index++)
                {
                    strBuilder.Append("0");
                }

                sequenceOfBytes += (strBuilder + currentNumber);
            }
            
            //// rows
            for(int indexOfByte = 0; indexOfByte < sequenceOfBytes.Length; indexOfByte += numberOfBytes)
            {
                int currentByteLength = indexOfByte + numberOfBits;

                for(int indexOfBit = indexOfByte; indexOfBit < currentByteLength; indexOfBit++)
                {
                    int countFullCells = 0;

                    if(sequenceOfBytes[indexOfBit] == '1')
                    {
                        for(int indexOfCurrentBit = indexOfBit; indexOfCurrentBit < currentByteLength; indexOfCurrentBit++)
                        {
                            if(sequenceOfBytes[indexOfBit] != sequenceOfBytes[indexOfCurrentBit])
                            {
                                indexOfBit = indexOfCurrentBit - 1;
                                break;
                            }

                            countFullCells++;

                            if(indexOfCurrentBit == numberOfBytes - 1)
                            {
                                indexOfBit = indexOfCurrentBit;
                                break;
                            }
                        }

                        if(sequenceOfFullCellsLength == countFullCells)
                        {
                            countOfSequences++;
                        }

                        if(sequenceOfFullCellsLength < countFullCells)
                        {
                            sequenceOfFullCellsLength = countFullCells;
                            countOfSequences = 0;
                            countOfSequences++;
                        }
                    }            
                }
            }

            if(sequenceOfFullCellsLength == 1)
            {
                countOfSequences = 0;
            }
                                    
            //// columns
            for(int indexOfBit = 0; indexOfBit < numberOfBits; indexOfBit++)
            {
                for(int indexOfByte = indexOfBit; indexOfByte < sequenceOfBytes.Length; indexOfByte += numberOfBytes)
                {
                    int countFullCells = 0;

                    if(sequenceOfBytes[indexOfByte] == '1')
                    {          
                        for(int indexOfCurrentBit = indexOfByte; indexOfCurrentBit < sequenceOfBytes.Length; indexOfCurrentBit += numberOfBytes)
                        {
                            if(sequenceOfBytes[indexOfByte] != sequenceOfBytes[indexOfCurrentBit])
                            {
                                indexOfByte = indexOfCurrentBit - numberOfBytes;
                                break;
                            }

                            countFullCells++;

                            if(indexOfCurrentBit == sequenceOfBytes.Length - numberOfBytes)
                            {
                                indexOfByte = indexOfCurrentBit;
                                break;
                            }
                        }

                        if(sequenceOfFullCellsLength == countFullCells)
                        {
                            countOfSequences++;
                        }

                        if(sequenceOfFullCellsLength < countFullCells)
                        {
                            sequenceOfFullCellsLength = countFullCells;
                            countOfSequences = 0;
                            countOfSequences++;
                        }
                    }               
                }
            }

            if(numberOfTheLongestSequences <= countOfSequences)
            {
                numberOfTheLongestSequences = countOfSequences;
            }  

            Console.WriteLine(sequenceOfFullCellsLength);
            Console.WriteLine(numberOfTheLongestSequences);
        }
    }
}