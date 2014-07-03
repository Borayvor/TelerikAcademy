namespace E02Homework
{
    using System;


    public class IndividualCustomer : Customer
    {
        private string lastName;

        public IndividualCustomer (ulong id, string firstName, string lastName)
            : base (id, firstName)
        {
            this.LastName = lastName;
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace (value))
                {
                    throw new ArgumentException ("Last name cannot be null, empty or white-space !");
                }
                this.lastName = value;
            }
        }
    }
}
