using StringToIntegerATOI;
namespace StringToIntegerATOI.Tests;

[TestClass]
public class StringToIntegerATOI_Test
{
    private readonly StringToInteger _stringToInt;

    public StringToIntegerATOI_Test()
    {
        _stringToInt = new StringToInteger();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int result = _stringToInt.MyAtoi("42");

        Assert.AreEqual(result, 42);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int result = _stringToInt.MyAtoi("   -42");

        Assert.AreEqual(result, -42);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int result = _stringToInt.MyAtoi("4193 with words");

        Assert.AreEqual(result, 4193);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int result = _stringToInt.MyAtoi("   -2000000000000000");

        Assert.AreEqual(result, Int32.MinValue);
    }

    [TestMethod]
    public void TestMethod5()
    {
        int result = _stringToInt.MyAtoi("a couple of words and then 200");

        Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void TestMethod6()
    {
        int result = _stringToInt.MyAtoi("200000000000000");

        Assert.AreEqual(result, Int32.MaxValue);
    }
}