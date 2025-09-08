
namespace Coupling
{
    interface IEngine
    {
        void Start();
    }

    // First engine type
    class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol engine starting...");
        }
    }

    class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine starting silently...");
        }
    }

    class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is driving!");
        }
    }
}