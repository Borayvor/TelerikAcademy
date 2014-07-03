namespace E01ExtendStringBuilder
{    
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring (this StringBuilder sb, int index, int length)
        {
            var newSb = new StringBuilder ();
            for (int i = index; i < (index + length); i++)
            {
                newSb.Append (sb[i]);
            }

            return newSb;
        }
    }
}
