using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundations
{
	public class Bank
	{
		public IEnumerable<Account> Accounts { get; set; }

		public Bank(IEnumerable<Account> accounts)
		{
			Accounts = accounts;
		}

		public void Deposit(string accountId, int amount)
		{
			if (amount <= 0)
			{
				return;
			}

			var matchingAccount = Accounts.FirstOrDefault(a => a.AccountId == accountId);
			if (matchingAccount == null)
			{
				return;
			}

			matchingAccount.Balance += amount;
		}

		public void Withdraw(string accountId, int amount)
		{
			if(amount <= 0)
			{
				return;
			}

			var matchingAccount = Accounts.FirstOrDefault(a => a.AccountId == accountId);
			if (matchingAccount == null)
			{
				return;
			}

			matchingAccount.Balance -= amount;
		}

		public void Transfer(string targetAccount, string sourceAccount, int amount)
		{
			var matchingTargetAccount = Accounts.FirstOrDefault(a => a.AccountId == targetAccount);
			if (matchingTargetAccount == null)
			{
				return;
			}

			var matchingSourceAccount = Accounts.FirstOrDefault(a => a.AccountId == sourceAccount);
			if (matchingSourceAccount == null)
			{
				return;
			}

			matchingSourceAccount.Balance -= amount;
			matchingTargetAccount.Balance += amount;
		}
	}
}
