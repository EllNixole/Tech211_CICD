namespace FourPillarsApp;

public class Program
{
    static void Main()
    {
        ////Instantiation
        //var danielle = new Person("Danielle", "Massey");
        //danielle.Age = 24;

        //var talal = new Person("Talal", "Hassan", 22);

        //Console.WriteLine(talal.GetFullName("Mr"));


        ////object initialisers
        //var patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };
        //var array = new int[] { 1, 2, 3 };
        //var list = new List<int> { 1, 2, 3 };

        //var park = new Park() { Roundabouts = 1, Swings = 5, parkManager = new Person("Dave", "Davidson")};

        //Point3D point = new Point3D(1,2);
        //Point3D empty;

        //DoThis(point, danielle);

        //var danyal = new Hunter("Danyal", "Saleh", "Kodak");
        //Console.WriteLine(danyal.Shoot());

        //Console.WriteLine(danyal);

        //var idris = new Hunter("Idris", "Ahmed", "Cannon");

        //Console.WriteLine($"idris Equals danielle? {idris.Equals(danielle)}");
        //Console.WriteLine($"idris HashCode: {idris.GetHashCode()}");
        //Console.WriteLine($"idris Type: {idris.GetType()}");
        //Console.WriteLine($"idris ToString: {idris}");


        //var myDog = new Dog();
        //var myCat = new Cat();
        //var myBird = new Bird();

        //Console.WriteLine(myDog.Speak());
        //Console.WriteLine(myCat.Speak());
        //Console.WriteLine(myBird.Speak() + "\n");

        //Console.WriteLine("Polymorphism demo\n");

        //List<Animal> animals = new List<Animal>() { myDog, myCat, myBird };
        //foreach (var animal in animals)
        //{
        //    Console.WriteLine(animal.Speak());
        //}

        //Console.WriteLine();

        //Animal? myAnimal;
        //Console.WriteLine("Choose dog, cat or bird");
        //string input = Console.ReadLine();

        //switch (input.ToLower())
        //{
        //    case "dog":
        //        myAnimal = new Dog();
        //        break;
        //    case "cat":
        //        myAnimal = new Cat();
        //        break;
        //    case "bird":
        //        myAnimal = new Bird();
        //        break;
        //    default:
        //        Console.WriteLine("Not an Animal");
        //        myAnimal = null;
        //        break;
        //}

        //if (myAnimal != null) Console.WriteLine(myAnimal.Speak());

        //Console.WriteLine();

        //List<Object> gameObjects = new List<Object>()
        //{
        //    new Airplane(25),
        //    new Dog(),
        //    new Cat(),
        //    new Park(),
        //    new Person("Jacob", "Banyard"),
        //    new Hunter ("Majid", "Laklouk", "Nikon"),
        //    new Vehicle()
        //};

        //foreach(var obj in gameObjects)
        //{
        //    SpartaWrite($"Objects hashcode is {obj.GetHashCode()}");
        //    if (obj is Animal)
        //    {
        //        Animal a = (Animal)obj;
        //        SpartaWrite(a.Speak());
        //    }
        //}

        //Console.WriteLine();

        //List<ISpeakable> speakables = new()
        //{
        //    new Person("Jacob", "Banyard"),
        //    new Person ("Majid", "Laklouk"),
        //    new Dog(),
        //    new Cat()
        //};
        //foreach(var s in speakables)
        //{
        //    SpartaWrite(s.Speak());
        //}

        var bazooka1 = new Bazooka("Zute Bazooka");
        var jacob = new Hunter("Jacob", "Banyard", bazooka1);
        var knife1 = new Knife("Babish Knife");
        var hunterMajid = new Hunter("Majid", "Laklouk", knife1);
        var bazooka2 = new Bazooka("military grade bazooka");
        var camera1 = new Camera();
        var knife2 = new Knife("Asda Knife");

        var shootables = new List<IShootable>()
        {
            bazooka1,
            jacob,
            knife1,
            hunterMajid,
            bazooka2,
            camera1,
            knife2
        };

        foreach(var w in shootables)
        {
            Console.WriteLine(w.Shoot());
        }


    }
    public static void DoThis(Point3D p, Person person)
    {
        p.x = 1000;
        person.Age = 99;
    }
    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine($"Sparta says: {obj}");
    }
}