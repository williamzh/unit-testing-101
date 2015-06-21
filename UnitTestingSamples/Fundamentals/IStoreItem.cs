namespace Fundamentals
{
	public interface IStoreItem
	{
		string ProductId { get; set; }
		string ProductName { get; set; }
		decimal Price { get; set; }
		string CategoryId { get; set; }
		bool IsInStock { get; set; }
	}
}
