namespace DealershipManagementSystem
{
    //"ElecticCars" MongoDB collection structure (.bson file)
    public class ElectricCarCharacteristics
    {
		public int Id { get; private set; }
        public string Model { get; private set; }
		public string Acceleration { get; private set; }
		public string TopSpeed { get; private set; }
		public string ElectricRange { get; private set; }
		public string TotalPower { get; private set; }
		public string TotalTorgue { get; private set; }
		public string Drive { get; private set; }
		public string NominalCapacity { get; private set; }
		public string UseableCapacity { get; private set; }
		public string BatteryType { get; private set; }
		public string NumberOfCells { get; private set; }
		public string Architecture { get; private set; }
		public string NominalVoltage { get; private set; }
		public string ChargePort { get; private set; }
		public string PortLocation { get; private set; }
	    public string ChargePower { get; private set; }
		public string ChargeTime { get; private set; }
		public string ChargeSpeed { get; private set; }
		public string FastchargePort { get; private set; }
		public string FCPortLocation { get; private set; }
		public string FastchargePowerMax { get; private set; }
		public string FastchargeTime { get; private set; }
		public string FastchargeSpeed { get; private set; }
		public string Length { get; private set; }
		public string Width { get; private set; }
		public string Height { get; private set; }
		public string Wheelbase { get; private set; }
		public string Clearance { get; private set; }
		public string WeightUnladen { get; private set; }
		public string GrossVehicleWeight { get; private set; }
		public string MaxPayload { get; private set; }
		public string CargoVolume { get; private set; }
		public string CargoVolumeMax { get; private set; }
		public string Transmission { get; private set; }
		public string GearBox { get; private set; }
		public string Seats { get; private set; }
		public string CarBody { get; private set; }
		public int YearOfIssue { get; private set; }
		public string Price { get; private set; }
		public string Manufacturer { get; private set; }
		public string OrderStatus { get; private set; }
		public bool IsReserved { get; private set; }
	}
}
