using UnityTest;

namespace TestBankApp
{
    [TestClass]
    public class TestBankAccount
    {
        [TestMethod]
        [DataRow(10, 3, 7)]
        [DataRow(10, 10, 0)]
       // [DataRow(10, 0, 10)]

        public void TestWithdraw(int balance, int withdraw, int expected)
        {
            //int balance = 10, withdraw = 3, excpected = 7;
            BankAccount bankAccount = new("georgiy", balance);

            bankAccount.Withdraw(withdraw);


            Assert.AreEqual(expected, bankAccount.Balance, "incorrect withdraw");
        }

        [TestMethod]
        public void TestDeposit()
        {
            int balance = 10, deposit = 3, excpected = 13;
            BankAccount bankAccount = new("georgiy", balance);

            bankAccount.Deposit(deposit);

            Assert.AreEqual(excpected, bankAccount.Balance, "incorrect deposit");
        }

        [TestMethod]
        //[DataRow(10, 3)]
        //[DataRow(10, 10)]
        [DataRow(10, 0)]

        public void TestNegativeWithdraw(int balance, int withdraw)
        {
            BankAccount bankAccount = new("georgiy", balance);

           //bankAccount.Withdraw(withdraw);

            Assert.ThrowsException<InvalidOperationException>(() => bankAccount.Withdraw(withdraw), "withdraw <= 0 ");
        }

        
    }
}