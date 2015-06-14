using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Common;

namespace Foundations.Test
{
	[TestClass]
	public class BankTest
	{
		private List<Account> _testAccounts = new List<Account>
		{
			new Account { AccountId = "123456", Balance = 20000 },
			new Account { AccountId = "654321", Balance = 7000 }
		};

		// Example
		[TestMethod]
		public void Deposit_AmountIsInvalid_DoesntUpdateBalance()
		{
			// Arrange
			

			// Act
			

			// Assert
			
		}

		// Exercise 1.1
		// Complete the following unit test for the Deposit method that verifies 
		// that the balance isn't updated when there is no matching account.
		[TestMethod]
		public void Deposit_NoMatchingAccount_DoesntUpdateBalance()
		{
			// Arrange
			

			// Act
			

			// Assert
			
		}

		// Exercise 1.2
		// Complete the following unit test for the Transfer method that verifies 
		// that balances are updated when transferring between two valid accounts.
		[TestMethod]
		public void Deposit_AccountsAreValid_UpdatesBalances()
		{
			// Arrange


			// Act


			// Assert

		}
	}
}
