using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.GettingStarted
{
	[TestClass]
	public class CoffeeStoreTest
	{
		[TestMethod]
		public void AddToCart_ItemIsNull_DoesntAddToCart()
		{
			// Arrange
			var store = new CoffeeStore();

			// Act
			store.AddToCart(null);

			// Assert
			Assert.IsFalse(store.GetCartItems().Any());
		}

		// Exercise 1.1: Complete the following test so that it verifies that no item
		// is removed if the item doesn't exist in the cart.
		[TestMethod]
		public void RemoveFromCart_ItemDoesntExist_DoesntRemoveFromCart()
		{
			// Arrange


			// Act


			// Assert


		}

		// Exercise 1.2: Complete the following test so that it verifies that the cart
		// is emptied when checking out, given that there are items in it.
		[TestMethod]
		public void Checkout_CartContainsItems_EmptiesCart()
		{
			// Arrange


			// Act


			// Assert


		}
	}
}
