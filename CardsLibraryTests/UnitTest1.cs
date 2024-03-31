namespace CardsLibraryTests;
using CardsLibrary;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Class1 class1 = new Class1();
        string input = "Hello World";
        string expected = "Hello World";
        string actual = class1.Method1(input);

        Assert.AreEqual(expected, actual);
    }
}