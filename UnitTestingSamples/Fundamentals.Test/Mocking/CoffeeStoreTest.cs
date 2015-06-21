using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Mocking
{
	[TestClass]
	public class CoffeeStoreTest
	{
		[TestMethod]
		public void Checkout_CartContainsItems_CreatesOrder()
		{
			// Arrange


			// Act


			// Assert


		} 

		// Exercise 2.1: Complete the following test so that it verifies that no order
		// is placed when checking out, given that there are no items in it.
		[TestMethod]
		public void Checkout_CartIsEmpty_DoesntCreateOrder()
		{
			// Arrange


			// Act


			// Assert


		}

		// Exercise 2.2: Use mocks to simplify the test from exercise 1.2.
		[TestMethod]
		public void Checkout_CartContainsItems_EmptiesCart()
		{
			// Arrange


			// Act


			// Assert


		}
	}
}
