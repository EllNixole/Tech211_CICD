

namespace FourPillarsApp;

public class Knife : Weapon
{
    public Knife(string brand): base(brand){}

    public override string Shoot()
    {
        return $"Shling Shling {base.Shoot()}";
    }
}
