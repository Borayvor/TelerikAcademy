namespace E02Homework
{

    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit (Customer owner, decimal balance, decimal monthlyInterestRate, ushort numberOfMonths)
            : base (owner, balance, monthlyInterestRate, numberOfMonths)
        {
        }
               

        public void Withdraw (decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount ()
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterestAmount ();
        }
                
    }
}