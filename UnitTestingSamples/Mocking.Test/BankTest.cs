using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Common;

namespace Mocking.Test
{
	[TestClass]
	public class BankTest
	{
		private List<Account> _testAccounts = new List<Account>
		{
			new Account { AccountId = "123456", Balance = 20000 },
			new Account { AccountId = "654321", Balance = 7000 }
		};

		// Example - DON'T: Implicit dependencies 
		[TestMethod]
		public void DepositWithUntestableBank_AmountIsInvalid_DoesntUpdateBalance()
		{
			// Arrange

			// Act

			// Assert
			
		}

		// Example - DO: Explicit dependencies (i.e.Dependency Injection)
		[TestMethod]
		public void Deposit_AmountIsInvalid_DoesntUpdateBalance()
		{
			// Arrange


			// Act


			// Assert

		}

		// Exercise 2.1
		// Update the test from Exercise 1.1 to mock out the dependency to IAccountProvider.
		[TestMethod]
		public void Deposit_NoMatchingAccount_DoesntUpdateBalance()
		{
			// Arrange


			// Act


			// Assert

		}

		// Exercise 2.2
		// Update the test from Exercise 1.2 to mock out the dependency to IAccountProvider.
		[TestMethod]
		public void Deposit_AccountsAreValid_UpdatesBalances()
		{
			// Arrange


			// Act


			// Assert

		}
	}
}
