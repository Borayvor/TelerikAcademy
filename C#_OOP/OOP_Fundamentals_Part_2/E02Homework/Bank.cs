namespace E02Homework
{
    using System;
    using System.Collections.Generic;


    public class Bank
    {
        private List<Deposit> depositAccountsList;
        private List<Loan> loanAccountsList;
        private List<Mortgage> mortgageAccountsList;

        public List<Deposit> DepositAccountsList
        {
            get
            {
                return this.depositAccountsList;
            }

            set
            {
                this.depositAccountsList = value;
            }
        }

        public List<Loan> LoanAccountsList
        {
            get
            {
                return this.loanAccountsList;
            }

            set
            {
                this.loanAccountsList = value;
            }
        }

        public List<Mortgage> MortgageAccountsList
        {
            get
            {
                return this.mortgageAccountsList;
            }

            set
            {
                this.mortgageAccountsList = value;
            }
        }
    }
}
