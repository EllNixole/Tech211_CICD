
namespace FourPillarsApp
{
    public class Airplane : Vehicle
    {
        private string _airline;

        public int Altitude { get; set; }

        public Airplane(int capacity) : base(capacity)
        {
            _airline = "";
        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            if (Altitude < 0) { Altitude = 0; }
            Altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline} {base.ToString()} altitude: {Altitude}";
        }
    }
}
