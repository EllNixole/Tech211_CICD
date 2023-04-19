

namespace FourPillarsApp;

public class Bazooka : Weapon
{
    public Bazooka(string brand) : base(brand){}

    public override string Shoot()
    {
        return $"BOOM!! {base.Shoot()}";
    }
}
