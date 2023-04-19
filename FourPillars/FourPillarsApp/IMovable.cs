namespace FourPillarsApp;

public interface IMovable
{

    public virtual string Move()
    {
        return "Going Along";
    }
    public virtual string Move(int times)
    {
        return $"Moving along {times} times";
    }

}