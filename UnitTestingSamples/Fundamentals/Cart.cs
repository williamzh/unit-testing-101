using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
	public class Cart : List<IStoreItem>
	{
		public decimal CalculateTotal()
		{
			return this.Sum(item => item.Price);
		}

		public decimal CalculateDiscountedTotal(int discountPercentage)
		{
			return CalculateTotal() * (discountPercentage / 100);
		}
	}
}
