using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    //    class Infotainment
    //    {
    //        public string Name { get; set; }
    //        public bool HasMaps { get; set; }
    //        public bool HasUSB { get; set; } = true;
    //        public bool HasAuxillary { get; set; } = true;
    //        public bool HasCd { get; set; }
    //        public string CurrentPlayer { get; set; } = "CD Player";
    //    }
    //    class Car
    //    {
    //        public string ChasisNo { get; set; }
    //        public string BodyType { get; set; }
    //        public string FuelType { get; set; }
    //        public int NoOfSeats { get; set; }

    //        public Car(Infotainment infotainment)
    //        {
    //            this.Infotainment = infotainment;
    //        }

    //        public void ReplaceInfotainment(Infotainment infotainment)
    //        {
    //            this.Infotainment = infotainment;
    //        }
    //        public Infotainment Infotainment { get; private set; }

    //        public void Start()
    //        {
    //            Console.WriteLine("Car has started");
    //            Console.WriteLine("Player of the type {0} has started in {1}", Infotainment.CurrentPlayer, Infotainment.Name);
    //        }

    //    }
    //    class Constructors
    //    {

    //        static void Main(string[] args)
    //        {
    //        Car car = new Car(new Infotainment
    //        {
    //            Name = "Philips",
    //            HasMaps = false
    //        });
    //        car.Start();

    //    }
    //}

    //****************************Constructor Main Class***************************//
    class BaseClass
    {
        public BaseClass(int no)
        {
            Console.WriteLine("Base class parameterized Constructor");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass(int value) : base(value)
        {
            Console.WriteLine("Derived class Constructor");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            DerivedClass cls = new DerivedClass(123);
        }

    }
}