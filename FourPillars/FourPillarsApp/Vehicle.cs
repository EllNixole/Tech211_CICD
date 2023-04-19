

namespace FourPillarsApp;

public class Vehicle : IMovable
{
    private int _capacity;
    private int _numPassengers;

    public int NumPassengers
    {
        get { return _numPassengers; }
        set 
        {
            if (value >= 0 && value <= _capacity) _numPassengers = value;
            
        }
    }

    public int Position { get; private set; }

    public int Speed { get; init; } = 10;

    public virtual string Move()
    {
        Position = Speed;
        return "Moving along";
    }

    public virtual string Move(int times)
    {
        Position = Speed * times; 
        return $"Moving along {times} times";
    }

    public Vehicle()
    {
       _capacity = 5;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        if (speed < 0) throw new ArgumentException("Argument must be above 0");

        _capacity = capacity;
        Speed = speed;
    }
    public override string ToString()
    {
        return $"capacity: {_capacity} passengers: {NumPassengers} speed: {Speed} position {Position}";
    }
}
