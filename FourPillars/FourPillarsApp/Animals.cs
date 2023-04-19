

namespace FourPillarsApp;

public abstract class Animal : ISpeakable
{
    private string _name;

    public string Kingdom { get; set; }

    public int Legs { get; set; }

    public DateTime Age { get; set; }

    public bool hasTail { get; set; }

    public abstract string Speak();
    
    public virtual double  Move()
    {
        return 0d;
    }

    public Animal()
    {
        _name = "Bob";
        Kingdom = "Mammal";
    }

}
public class Dog : Animal
{
    public int Speed { get; set; } = 10;

    public Dog() : base()
    {

    }

    public override string Speak()
    {
        return "Bark Bark";
    }

    public override sealed double Move()
    {
        return Speed;  
    }
}
public class Cat : Animal
{
    public override string Speak()
    {
        return "Meow";
    }
}
public class Bird : Animal
{
    public override string Speak()
    {
        return "Cheep cheep";
    }
}

