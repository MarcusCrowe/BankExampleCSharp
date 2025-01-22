using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class HighInterestSavingsAccount : SavingsAccount
    {
        public HighInterestSavingsAccount(string accountNumber, decimal initialBalanace, decimal interestRate) :
            base(accountNumber, initialBalanace, interestRate)
        {

        }
        public void ApplyBonusInterest(decimal bonusRate)
        {
            decimal bonusInterestPayment = this.Balance * bonusRate;
            this.Deposit(bonusInterestPayment);
        }
    }
}
