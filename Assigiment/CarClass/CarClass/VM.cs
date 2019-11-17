using System.ComponentModel;

namespace CarClass
{


    public class VM
    {
        const int CHANGESPEED = 5;
        public BindingList<Car> Cars { get; set; } = new BindingList<Car>();
        public int Speed { get; set; }
        public uint Year { get; set; }
        public string Make { get; set; }
        public Car SelectCar { get; set; }

        public void VMadd()
        {
            Car p = new Car(Make, Year, Speed);
            Cars.Add(p);
        }
        public void AddSpeed(Car car)
        {
            car.Speed += CHANGESPEED;
        }
        public void SlowDown(Car car)
        {
            car.Speed -= CHANGESPEED;
        }
    }
}
