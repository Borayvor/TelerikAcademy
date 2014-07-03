namespace E02Homework
{
    using System;


    public abstract class Account : IDepositable, IInterestAmountCalculator
    {
        private Customer owner;
        private decimal balance;
        private decimal monthlyInterestRate;
        private ushort numberOfMonths;

        protected Account (Customer owner, decimal balance, decimal monthlyInterestRate, ushort numberOfMonths)
        {
            this.Owner = owner;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
            this.NumberOfMonths = numberOfMonths;
        }

        public Customer Owner
        {
            get
            {
                return this.owner;
            }

            protected set
            {                
                this.owner = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get
            {
                return monthlyInterestRate;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException ("The monthly interest rate cannot be negative !");
                }
                this.monthlyInterestRate = value / 100;
            }
        }

        public ushort NumberOfMonths
        {
            get
            {
                return this.numberOfMonths;
            }
            protected set
            {
                this.numberOfMonths = value;
            }
        }

        public void Deposit (decimal amount)
        {
            this.Balance += amount;
        }



        public virtual decimal CalculateInterestAmount ()
        {
            return this.NumberOfMonths * this.MonthlyInterestRate * this.Balance;
        }

        public override string ToString ()
        {
            return string.Format (base.GetType ().Name + ": " + this.Owner.Name + "\r\nID: " + this.Owner.Id + "\r\nBalance: " +
                this.Balance + "\r\nTerm of use: " + this.NumberOfMonths +
                "\r\nMonthly Interest Rate: " + this.MonthlyInterestRate + "\r\nInterest Amount: " + this.CalculateInterestAmount ());
        }
    }
}
