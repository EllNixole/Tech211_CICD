

namespace FourPillarsApp;

public class Hunter : Person, IShootable
{
    

    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;
    }

    public IShootable Shooter { get; set; }

    public string Shoot()
    {
        return $"{GetFullName()} shoots! {Shooter.Shoot()}";
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Camera: {Shooter.Shoot()}";
    }
}
