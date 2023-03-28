using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DealershipManagementSystem
{
	// Getting data from different collections of the "CarShowroomDB"
	public static class DataFromCarShowroomDB
	{
		public static List<ElectricCarCharacteristics> ElectricCarsList { get; private set; }

		static DataFromCarShowroomDB()
		{
			ElectricCarsList= new List<ElectricCarCharacteristics>();
		}

		// Getting data from "electricCars" collection
		public static void GetElectricCars()
		{
			IMongoCollection<ElectricCarCharacteristics> electicCars =
			ConnectionMongoDB.CarShowroomDB.GetCollection<ElectricCarCharacteristics>("electricCars");
			ElectricCarsList = electicCars.Find(_ => true).ToList();
		}
	}
}
