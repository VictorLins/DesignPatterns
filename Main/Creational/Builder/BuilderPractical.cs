namespace Main.Builder
{
    public static class BuilderPractical
    {
        public static void Execute()
        {
            VehicleManifacturer lVehicleManifacturer = new VehicleManifacturer();

            // Building MotorCycle
            VehicleBuilder lVehicleBuilder = new MotorCycleBuilder();
            lVehicleManifacturer.Construct(lVehicleBuilder);
            Vehicle lMotorCycle = lVehicleBuilder.GetVehicle();
            Console.WriteLine("MotorCycle Builder - Product Result: ");
            lMotorCycle.GetDetails();

            // Building Car
            lVehicleBuilder = new CarBuilder();
            lVehicleManifacturer.Construct(lVehicleBuilder);
            Vehicle lCar = lVehicleBuilder.GetVehicle();
            Console.WriteLine("\n\rCar Builder - Product Result: ");
            lCar.GetDetails();
        }
    }

    public class VehicleManifacturer
    {
        public void Construct(VehicleBuilder prVehicleBuilder)
        {
            prVehicleBuilder.BuildFrame();
            prVehicleBuilder.BuildEngine();
            prVehicleBuilder.BuildWheels();
            prVehicleBuilder.BuildDoors();
        }
    }

    public abstract class VehicleBuilder
    {
        protected Vehicle _Vehicle;
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

        public Vehicle GetVehicle()
        {
            return _Vehicle;
        }
    }

    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            _Vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildFrame()
        {
            _Vehicle.Frame = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            _Vehicle.Engine = "500 cc";
        }

        public override void BuildWheels()
        {
            _Vehicle.Wheels = 2;
        }

        public override void BuildDoors()
        {
            _Vehicle.Doors = 0;
        }
    }

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            _Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            _Vehicle.Frame = "Car Frame";
        }

        public override void BuildEngine()
        {
            _Vehicle.Engine = "2500 cc";
        }

        public override void BuildWheels()
        {
            _Vehicle.Wheels = 4;
        }

        public override void BuildDoors()
        {
            _Vehicle.Doors = 4;
        }
    }

    public class Vehicle
    {
        public string VehicleType { get; set; }
        public string Frame { get; set; }
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }

        public Vehicle(string prVehicleType)
        {
            VehicleType = prVehicleType;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Engine: {Engine} | Frame: {Frame} | Wheels: {Wheels} | Doors: {Doors}");
        }
    }
}