using System;
using Bank;
using Xunit;

namespace RushayBankXUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Adding_FundsUpdates_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Add(100);

            //ASSERT
            Assert.Equal(1100, account.Balance);
        }

        [Fact]
        public void Adding_Negative_Funds_Throws()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-100));
        }

        [Fact]
        public void Withdraw_FundsUpdates_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Withdraw(100);

            //ASSERT
            Assert.Equal(900, account.Balance);
        }
        [Fact]
        public void Withdraw_Negative_Funds_Throws()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-100));
        }

        [Fact]
        public void Transfer_FundsUpdates_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount(0);

            //ACT
            account.TransferFundsTo(otherAccount, 500);

            //ASSERT
            Assert.Equal(500, account.Balance);
            Assert.Equal(500, otherAccount.Balance);
        }
    }


}
