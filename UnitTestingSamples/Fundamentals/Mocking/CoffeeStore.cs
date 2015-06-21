using System.Collections.Generic;
using System.Linq;

namespace Fundamentals.Mocking
{
    public class CoffeeStore
    {
		private readonly Cart _cart;
		private readonly IOrderHandler _orderHandler;
		private readonly ISuppy _supply;

	    public CoffeeStore(IOrderHandler orderHandler, ISuppy supply)
	    {
			_cart = new Cart();
			_orderHandler = orderHandler;
			_supply = supply;
	    }

		public IEnumerable<IStoreItem> GetAllItems()
		{
			return _supply.GetAllItems();
		}

	    public void AddToCart(IStoreItem item)
	    {
		    if (item == null)
		    {
				return;
		    }

			_cart.Add(item);
	    }

	    public IEnumerable<IStoreItem> GetCartItems()
	    {
			return _cart;
	    }

	    public IStoreItem GetCartItem(string productId)
	    {
			return _cart.FirstOrDefault(i => i.ProductId == productId);
	    }

	    public void RemoveFromCart(IStoreItem item)
	    {
		    if (!_cart.Any(i => i.ProductId == item.ProductId))
		    {
				return;
		    }

			var itemToRemove = _cart.First(i => i.ProductId == item.ProductId);
			_cart.Remove(itemToRemove);
	    }

	    public void Checkout()
	    {
		    if (!_cart.Any())
		    {
				return;
		    }

			_orderHandler.CreateOrder();
			_cart.Clear();
	    }
    }
}
