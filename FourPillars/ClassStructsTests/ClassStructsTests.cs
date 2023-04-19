using FourPillarsApp;
namespace ClassStructsTests;

public class Tests
{
    private Person _sut;

    #region PersonTests

    [SetUp]
    public void SetUp()
    {
        _sut = new Person("Danielle", "Massey");
        _sut.Height = 150;
        _sut.Age = 24;
    }

    [Test]
    public void GivenNames_FieldsThroughGetFullName_ReturnsCorrectNames()
    {
        Assert.That(_sut.GetFullName(), Is.EqualTo("Danielle Massey"));
    }
    [Test]
    public void GivenNamesAndTitle_FieldsThroughGetFullName_ReturnsCorrectName()
    {
        Assert.That(_sut.GetFullName("Miss"), Is.EqualTo("Miss Danielle Massey"));
    }

    [Test]
    public void GivenIncorrectKey_GetSecret_ReturnsInvalid()
    {
        Assert.That(_sut.GetSecret("123"), Is.EqualTo("Invalid Key"));
    }
    [Test]
    public void GivenCorrectKey_GetSecret_ReturnsValid()
    {
        Assert.That(_sut.GetSecret("potatoes"), Is.EqualTo("password123"));
    }
    [Test]
    public void GivenString_SetSecret_ReturnsNewString()
    {
        _sut.SetSecret("newpassword");
        Assert.That(_sut.GetSecret("potatoes"), Is.EqualTo("newpassword"));
    }
    [Test]
    public void Height_ReturnsCorrectInt()
    {

        Assert.That(_sut.Height, Is.EqualTo(150));
    }
    [Test]
    public void SetHeight_SetsNewInt()
    {
        _sut.Height = 200;
        Assert.That(_sut.Height, Is.EqualTo(200));
    }
    [Test]
    public void GetAge_ReturnsCorrectInt()
    {
        Assert.That(_sut.Age, Is.EqualTo(24));
    }
    [Test]
    public void GivenNegative_SetAge_ReturnsNoChange()
    {
        _sut.Age = -12;
        Assert.That(_sut.Age, Is.EqualTo(24));
    }
    [Test]
    public void GivenValid_SetAge_HasNewValue()
    {
        _sut.Age = 25;
        Assert.That(_sut.Age, Is.EqualTo(25));
    }
    [Test]
    public void PersonObject()
    {
        var jenny = new Person("Jennifer", "Coolidge");
        Assert.Pass();
    }
    #endregion


    #region VehicleTests
    [Test]
    public void VehicleObject()
    {
        var bmw = new Vehicle();
        Assert.Pass();
    }
    [Test] 
    public void WhenADefaultVehicle_MovesTwice_ItsPositionIs20() 
    { 
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.That(v.Position, Is.EqualTo(20));
        Assert.That(result, Is.EqualTo("Moving along 2 times")); 
    }
    [Test] 
    public void WhenAVehicleWithSpeed40_IsMovedOnce_ItsPositionIs40() 
    { 
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.That(v.Position, Is.EqualTo(40)); 
        Assert.That(result, Is.EqualTo("Moving along")); 
    }
    [Test]
    public void GivenNegativeSpeed_NewVehicle_ThrowsException()
    {
        
        Assert.That(() => new Vehicle(5, -10), Throws.TypeOf<ArgumentException>().With.Message.Contain("Argument must be above 0"));
    }
    [Test]
    public void TestGetNumPassengers()
    {
        var v = new Vehicle(7, 20);
        Assert.That(v.NumPassengers, Is.EqualTo(0));
    }
    [Test]
    public void TestSetNumPassengers()
    {
        var v = new Vehicle(7, 20);
        v.NumPassengers = 7;
        Assert.That(v.NumPassengers, Is.EqualTo(7));
    }
    [Test]
    public void GivenNumPassengersAboveCapacity_NumPassengers_Unchanged()
    {
        var v = new Vehicle();
        v.NumPassengers = 7;
        Assert.That(v.NumPassengers, Is.EqualTo(0));
        
    }
    [Test]
    public void GivenNegativeNumber_NumPassengers_Unchanged()
    {
        var v = new Vehicle();
        v.NumPassengers = -4;
        Assert.That(v.NumPassengers, Is.EqualTo(0));
    }
    [Test]
    public void TestGetPosition()
    {
        var v = new Vehicle(7, 20);
        Assert.That(v.Position, Is.EqualTo(0));
    }
    [Test]
    public void TestSetPosition_ThroughMoveMethod()
    {
        var v = new Vehicle(7, 30);
        v.Move(2);
        Assert.That(v.Position, Is.EqualTo(60));
    }
    [Test]
    public void TestDefaultSpeed_NoParamConstructor()
    {
        var v = new Vehicle();
        Assert.That(v.Speed, Is.EqualTo(10));
    }
    [Test]
    public void GetSpeed_ParamConstructor()
    {
        var v = new Vehicle(7, 55);
        Assert.That(v.Speed, Is.EqualTo(55));
    }
    [TestCase(0, 0)]
    [TestCase(5, 5)]
    [TestCase(6, 0)]
    public void TestDefaultCapacity_NoParamConstructor(int input, int expResult)
    {
        var v = new Vehicle();
        v.NumPassengers = input;
        Assert.That(v.NumPassengers, Is.EqualTo(expResult));
    }
    [TestCase(0, 0)]
    [TestCase(7, 7)]
    [TestCase(8, 0)]
    public void TestCapacity_ParamConstructor(int input, int expResult)
    {
        var v = new Vehicle(7, 20);
        v.NumPassengers = input;
        Assert.That(v.NumPassengers, Is.EqualTo(expResult));
    }
    #endregion

    #region AirplaneTests

    [Test]
    public void CreateAirplaneObjectTest()
    {
        Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        Assert.Pass();
    }
    [Test]
    public void GivenParams_Move_Test()
    {
        Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        Assert.That(a.Move(5), Does.Contain("Moving along 5 times at an altitude of 0 metres."));
    }
    [Test]
    public void ToString_Test()
    {
        Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        Assert.That(a.ToString(), Is.EqualTo("Thank you for flying JetsRUs capacity: 200 " +
            "passengers: 150 speed: 100 position 0 altitude: 0"));
    }

    #endregion

    [Test]
    public void SillyTest()
    {
        Assert.Fail();
    }
}