using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DealershipManagementSystem
{
	public class CarsFromDatabase
	{
		private MongoClient _connection;
		private IMongoDatabase _database;

		public List<ElectricCarCharacteristics> Characteristics { get; private set; } =
			new List<ElectricCarCharacteristics>();

		public CarsFromDatabase()
		{
			_connection = ConnectToMongoDB.Connection;
			_database = _connection.GetDatabase("CarShowroomDB");
		}

		public void GetElectricCars()
		{
			IMongoCollection<ElectricCarCharacteristics> collection =
				_database.GetCollection<ElectricCarCharacteristics>("electricCars");

			Characteristics = collection.Find(_ => true).ToList();
		}
	}
}
