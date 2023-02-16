using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MongoDB.Bson;
using DealershipManagementSystem.Data;

namespace DealershipManagementSystem
{
	public class GetCarsFromDatabase
	{
		private MongoClient _connection;
		private IMongoDatabase _database;

		public List<ElectricCarCharacteristics> ElectricCars { get; private set; } =
			new List<ElectricCarCharacteristics>();

		public GetCarsFromDatabase()
		{
			_connection = ConnectToMongoDB.Connection;
			_database = _connection.GetDatabase("CarWarehouseDB");
		}

		public void GetElectricCars()
		{
			IMongoCollection<ElectricCarCharacteristics> collection =
				_database.GetCollection<ElectricCarCharacteristics>("electricCars");

			ElectricCars = collection.Find(_ => true).ToList();
		}
	}
}
