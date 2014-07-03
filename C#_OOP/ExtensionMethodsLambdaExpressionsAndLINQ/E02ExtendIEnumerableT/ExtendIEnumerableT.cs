
namespace E02ExtendIEnumerableT
{
    using System;
    using System.Collections.Generic;


    public static class ExtendIEnumerableT 
    {
               
        public static T Sum<T>(this IEnumerable<T> colection) 
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            dynamic sum = 0;

            foreach (var item in colection)
            {
                sum += item;
            }
            return (T)sum;
        }

        public static T Product<T>(this IEnumerable<T> colection) 
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            dynamic product = 1;

            foreach (var item in colection)
            {                
                product *= item;

                if (product == 0)
                {
                    break;
                }                
            }
            return (T)product;
        }

        public static T Min<T>(this IEnumerable<T> colection) 
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            IEnumerator<T> enumerator = colection.GetEnumerator();
            enumerator.MoveNext();
            T element = enumerator.Current;

            foreach (var item in colection)
            {
                if (item.CompareTo(element) < 0)
                {
                    element = item;
                }
            }
            return element;
            
        }

        public static T Max<T>(this IEnumerable<T> colection) 
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            IEnumerator<T> enumerator = colection.GetEnumerator();
            enumerator.MoveNext();
            T element = enumerator.Current;

            foreach (var item in colection)
            {
                if (item.CompareTo(element) > 0)
                {
                    element = item;
                }
            }
            return element;
        }


        public static T Average<T>(this IEnumerable<T> colection) 
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            dynamic sum = 0;
            int count = 0;

            foreach (var item in colection)
            {
                count++;
                sum += item;
            }
            
            return (T)(sum / count); 
        }
    }
}
