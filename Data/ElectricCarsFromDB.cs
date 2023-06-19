using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DealershipManagementSystem
{
	// Getting data from "electricCars" collection of the "CarShowroomDB"
	public static class ElectricCarsFromDB
	{
		public static List<ElectricCarCharacteristics> ElectricCarsList { get; private set; }

		static ElectricCarsFromDB()
		{
			ElectricCarsList = new List<ElectricCarCharacteristics>();
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
