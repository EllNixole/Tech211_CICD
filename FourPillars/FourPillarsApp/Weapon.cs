

namespace FourPillarsApp;

public abstract class Weapon : IShootable
{
    private string _brand;

    public virtual string Shoot()
    {
        return $"goes the {_brand}";
    }

    public override string ToString()
    {
        return "";
    }

    public Weapon (string brand)
    {
        _brand = brand;
    }
}
