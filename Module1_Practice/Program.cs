class Vehicle
{
    string mark;
    string model;
    string date;

    void EngineStart()
    {
        Console.WriteLine("Engine Start");
    }
    void EngineStop()
    {
        Console.WriteLine("Engine Stop");
    }
}

class Car: Vehicle
{
    int doorCount;
    string TransmissionType;

    public Car() { }

    public Car(int doorCount, string TransmissionType)
    { 
        this.doorCount = doorCount;
        this.TransmissionType = TransmissionType;
    }
}


class Motorcycle: Vehicle
{
    string koozovType;
    bool haveBox;

    public Motorcycle() { }
    public Motorcycle(string koozovType, bool haveBox)
    {
        this.koozovType = koozovType;
        this.haveBox = haveBox;
    }
}

class Garage
{
    List<Vehicle> vehicles = new List<Vehicle>();

    public void addVehicle(Vehicle vehicle)
    { 
        vehicles.Add(vehicle);
    }
    public void removeVehicle(Vehicle vehicle) 
    {
        vehicles.Remove(vehicle);
    }
    public void checkVehicles()
    {
        Console.WriteLine("Vehicle count in Garage: " + vehicles.Count);
    }

    public Garage() { }
}

class Fleet
{
    List<Garage> garages = new List<Garage>();

    public void addGarage(Garage garage)
    { 
        garages.Add(garage);
    }
    public void removeGarage(Garage garage)
    { 
        garages.Remove(garage);
    }

    public void checkFleet()
    {
        Console.WriteLine("Garage count in Fleet: " + garages.Count);
    }

    public Fleet() { }
}

class Program
{
    static void Main(string[] args)
    
    {
        Car supra = new Car(2, "MT");
        Car rx7 = new Car(2, "MT");

        Motorcycle dugati = new Motorcycle("1 person", false);

        Garage garage = new Garage();

        garage.addVehicle(supra);
        garage.addVehicle(rx7);
        garage.addVehicle(dugati);
        garage.checkVehicles();

        garage.removeVehicle(rx7);
        garage.checkVehicles();

        Fleet fleet = new Fleet();
        fleet.addGarage(garage);
        fleet.checkFleet();
        fleet.removeGarage(garage);
        fleet.checkFleet();
    }
}