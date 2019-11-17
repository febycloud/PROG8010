namespace CarClass
{
    public class Car
    {

        public int Speed { get; set; }
        public uint Year { get; set; }
        public string Make { get; set; }

        public Car(string make, uint year, int speed)
        {
            this.Make = make;
            this.Year = year;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return Make + " | " + Year + " | Speed now is  " + Speed;
        }

    }
}
