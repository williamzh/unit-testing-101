using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
	public class Bank
	{
		private readonly IAccountProvider _accountProvider;

		public Bank(IAccountProvider accountProvider)
		{
			_accountProvider = accountProvider;
		}

		public void Deposit(string accountId, int amount)
		{
			if (amount <= 0)
			{
				return;
			}

			var matchingAccount = _accountProvider.GetAccount(accountId);
			if (matchingAccount == null)
			{
				return;
			}

			matchingAccount.Balance += amount;
		}

		public void Withdraw(string accountId, int amount)
		{
			if (amount <= 0)
			{
				return;
			}

			var matchingAccount = _accountProvider.GetAccount(accountId);
			if (matchingAccount == null)
			{
				return;
			}

			matchingAccount.Balance -= amount;
		}

		public void Transfer(string targetAccount, string sourceAccount, int amount)
		{
			var matchingTargetAccount = _accountProvider.GetAccount(targetAccount);
			if (matchingTargetAccount == null)
			{
				return;
			}

			var matchingSourceAccount = _accountProvider.GetAccount(sourceAccount);
			if (matchingSourceAccount == null)
			{
				return;
			}

			matchingSourceAccount.Balance -= amount;
			matchingTargetAccount.Balance += amount;
		}
	}
}
