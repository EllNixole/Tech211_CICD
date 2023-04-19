

namespace FourPillarsApp;

public class Person : IMovable,ISpeakable
{
    private string _firstName = "";
    private string _lastName = "";

    //private backing field
    private string _secret = "password123";

    // getter - method that returns that data
    public string GetSecret(string key)
    {
        if (key == "potatoes") return _secret;
        else return "Invalid Key";
    }

    // setter - a method that puts some new data into that data
    public void SetSecret(string inputValue)
    {
        _secret = inputValue;
    }
    
    private int _age = 18;

    public int Age
    {
        get { return _age; }
        set { if (value >= 0) _age = value; }
    }

    public int Height { get; set; } = 0;

    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }

    public Person (string fName, string lName, int age) : this (fName, lName)
    {
        _firstName = fName;
        _lastName = lName;
        Age = age;
    }

    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public string GetFullName(string title)
    {
        return $"{title} {GetFullName()}";
    }

    public Person() { }

    public override string ToString()
    {
        return $"First Name: {_firstName}, Last Name: {_lastName}, Age: {Age}";
    }
     
    public string Move()
    {
        return "Walking along";
    }
    public string Move(int times)
    {
        return $"Walking along {times} times";
    }

}