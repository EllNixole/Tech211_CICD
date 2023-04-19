
namespace FourPillarsApp;

public class Camera : IShootable
{
    private string _brand;

    public Camera() { _brand = ""; }

    public Camera(string brand)
    {
        _brand = brand;
    }
    public string Shoot()
    {
        if (_brand == "") { return "Click Click goes a camera"; }
        else return $"{_brand}, click click!";
    }
    
}
