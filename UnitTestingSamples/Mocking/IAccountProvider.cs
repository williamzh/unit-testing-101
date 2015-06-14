using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
	public interface IAccountProvider
	{
		IEnumerable<Account> GetAccounts();
		Account GetAccount(string id);
	}
}
