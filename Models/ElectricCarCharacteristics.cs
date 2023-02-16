namespace DealershipManagementSystem
{
    //"ElecticCars" MongoDB collection structure (.bson file)
    public class ElectricCarCharacteristics
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public string BodyType { get; private set; }
        public int Power_hp { get; private set; }
        public int Battery_kW { get; private set; }
        public int Range_km { get; private set; }
        public int MaxSpeed_kmh { get; private set; }
        public int YearOfIssue { get; private set; }
        public bool IsReserved { get; private set; }
    }
}
