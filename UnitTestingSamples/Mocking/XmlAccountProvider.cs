using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mocking
{
	public class XmlAccountProvider : IAccountProvider
	{
		private XDocument _xmlDoc;

		public XmlAccountProvider()
		{
			_xmlDoc = XDocument.Load(@"D:\GitRepos\unit-testing-101\UnitTestingSamples\Mocking\accounts.xml");
		}

		public IEnumerable<Account> GetAccounts()
		{
			var accounts = _xmlDoc.Root.Descendants("Account").Select(d => new Account 
			{ 
				AccountId = d.Attribute("id").Value, 
				Balance = int.Parse(d.Value)
			});
			return accounts;
		}

		public Account GetAccount(string id)
		{
			return GetAccounts().FirstOrDefault(a => a.AccountId == id);
		}
	}
}
