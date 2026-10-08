using CalcLib;

namespace CalcLib.Tests;

[TestClass]
public class CalculatorTests
{
    private Calculator calc = null!;

    [TestInitialize]
    public void Setup()
    {
        calc = new Calculator();
    }

    [TestCleanup]
    public void Cleanup()
    {
        calc = null!;
    }

    [TestMethod]
    public void Add_TwoNumbers_ReturnsSum()
    {
        int result = calc.Add(2, 3);
        Assert.AreEqual(5, result);
    }

    [DataTestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(-5, 5, 0)]
    [DataRow(10, -20, -10)]
    public void Add_DataRows_ReturnsSum(int a, int b, int expected)
    {
        Assert.AreEqual(expected, calc.Add(a, b));
    }

    [TestMethod]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        Assert.AreEqual(2.5, calc.Divide(5, 2), 0.0001);
    }

    [TestMethod]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(10, 0));
    }

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(2)]
    [DataRow(-4)]
    public void IsEven_EvenNumbers_ReturnsTrue(int n)
    {
        Assert.IsTrue(calc.IsEven(n));
    }

    [TestMethod]
    public void FindName_Existing_ReturnsSameObject()
    {
        string anna = "Anna";
        string[] names = { "Ivan", anna, "Petr" };
        string? result = calc.FindName(names, "Anna");
        Assert.AreSame(anna, result);
    }

    [TestMethod]
    public void FindName_NotFound_ReturnsNull()
    {
        string[] names = { "Ivan", "Petr" };
        Assert.IsNull(calc.FindName(names, "Olga"));
    }

    [TestMethod]
    public void Calculator_Created_IsCalculatorType()
    {
        Assert.IsInstanceOfType(calc, typeof(Calculator));
    }
}
