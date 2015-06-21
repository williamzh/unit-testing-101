using System.Collections.Generic;

namespace Fundamentals
{
	public interface ISuppy
	{
		IEnumerable<IStoreItem> GetAllItems();
	}
}
