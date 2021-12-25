using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;

namespace SafCos.UnitTest
{
    public class ProductServiceTest
    {
        private Mock<IProductRepo> _prodRepoMock;

        public ProductServiceTest()
        {
            _prodRepoMock = new Mock<IProductRepo>();


            [TestMethod]
            public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
            {
                // Arrange
                double beginningBalance = 11.99;
                double debitAmount = -100.00;
                BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

                // Act and assert
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
            }
        }
}
