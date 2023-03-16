// https://ev-database.org/car/1204/Hyundai-Kona-Electric-64-kWh

db.electricCars.insertOne(
    {
        _id: 0,
        Model: "Hyundai Kona Electric",
        Acceleration: "7.9 sec (0 -> 100 km/h)",
        TopSpeed: "167 km/h",
        ElectricRange: "395 km",
        TotalPower: "150 kW (204 FS)",
        TotalTorgue: "395 Nm",
        Drive: "Front",
        NominalCapacity: "67.5 kWh",
        UseableCapacity: "64 kWh",
        BatteryType: "Lithium-ion",
        NumberOfCells: "4416",
        Architecture: "400 V",
        NominalVoltage: "356 V",
        ChargePort: "Type 2",
        PortLocation: "Front-Middle",
        ChargePower: "11 kW AC",
        ChargeTime: "7 hours (0 -> 395 km)",
        ChargeSpeed: "58 km/h",
        FastchargePort: "CCS",
        FCPortLocation: "Front-Middle",
        FastchargePowerMax: "77 kW DC",
        FastchargeTime: "44 min (40 -> 316 km)",
        FastchargeSpeed: "370 km/h",
        Length: "4180 mm",
        Width: "1800 mm",
        Height: "1570 mm",
        Wheelbase: "2600 mm",
        Clearance: "158 mm",
        WeightUnladen: "1760 kg",
        GrossVehicleWeight: "2170 kg",
        MaxPayload: "485 kg",
        CargoVolume: "361 L",
        CargoVolumeMax: "1143 L",
        Transmission: "reducer",
        GearBox: "automatic",
        Seats: "5 people",
        CarBody: "SUV",
        YearOfIssue: 2021,
        Price: "41850 €",
        Manufacturer: "Hyundai Motor Group",
        OrderStatus: "Are available",
        IsReserved: false,
    }
)

db.electricCars.insertOne(
    {
        _id: 1,
        Model: "Chevrolet Bolt EV",
        Manufacturer: "General Motors",
        BodyType: "Hatchback",
        Power_hp: 204,
        Battery_kW: 60,
        Range_km: 380,
        MaxSpeed_kmh: 150,
        YearOfIssue: 2017,
        IsReserved: false
    }
)

db.electricCars.insertOne(
    {
        _id: 2,
        Model: "Volkswagen e-Golf",
        Manufacturer: "Volkswagen Group",
        BodyType: "Hatchback",
        Power_hp: 134,
        Battery_kW: 36,
        Range_km: 190,
        MaxSpeed_kmh: 140,
        YearOfIssue: 2020,
        IsReserved: false
    }
)

db.electricCars.insertOne(
    {
        _id: 3,
        Model: "Nissan Leaf",
        Manufacturer: "Nissan Motor Corporation",
        BodyType: "Hatchback",
        Power_hp: 109,
        Battery_kW: 24,
        Range_km: 117,
        MaxSpeed_kmh: 145,
        YearOfIssue: 2011,
        IsReserved: true
    }
)

db.electricCars.insertOne(
    {
        _id: 4,
        Model: "JAC iEVS4",
        Manufacturer: "JAC Motors",
        BodyType: "Crossover",
        Power_hp: 150,
        Battery_kW: 63,
        Range_km: 402,
        MaxSpeed_kmh: 150,
        YearOfIssue: 2019,
        IsReserved: false
    }
)