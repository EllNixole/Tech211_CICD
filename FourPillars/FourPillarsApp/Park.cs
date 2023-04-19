

namespace FourPillarsApp;

public class Park
{
    public int Swings { get; set; } = 0;

    public string Name { get; set; } = "";

    public string Location { get; set; } = "";

    public int Trees { get; set; } = 0;

    public int Roundabouts { get; set; } = 0;

    public List<Person> people { get; set; } = new List<Person> { };
    
    public Person parkManager { get; set; } = new Person();

    
}
