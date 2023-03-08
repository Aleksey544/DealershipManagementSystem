using MongoDB.Driver;

namespace DealershipManagementSystem
{
	public static class ConnectToMongoDB
	{
		public static MongoClient Connection { get; private set; }

		static ConnectToMongoDB()
		{
			Connection = new MongoClient("mongodb://localhost:27017");
		}
	}
}
