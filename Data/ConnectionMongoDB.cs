using MongoDB.Driver;

namespace DealershipManagementSystem
{
	// Establishing a connection with MongoDB
	public static class ConnectionMongoDB
	{
		private static MongoClient _connection;
		public static IMongoDatabase CarShowroomDB { get; private set; }

		// Getting databases from MongoDB
		static ConnectionMongoDB()
		{
			_connection = new MongoClient("mongodb://localhost:27017");
			CarShowroomDB = _connection.GetDatabase("CarShowroomDB");
		}
	}
}
