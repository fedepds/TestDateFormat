
using TestDateFormat;
using NUnit.Framework;


namespace LibraryTest;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestRightDateFormat()
    {
        const string input = "17/11/2023";
        const string expected = "2023-11-17";
        Assert.That(DateFormatter.ChangeFormat(input), Is.EqualTo(expected));
        
    }
    [Test]
    public void TestWrongDateFormat()
    {
        const string input = "17/011/2023";
        const string expected = "";
        Assert.That(DateFormatter.ChangeFormat(input), Is.EqualTo(expected));
    }
    [Test]
    public void TestWhiteDate()
    {
        const string input = "";
        const string expected = "";
        Assert.That(DateFormatter.ChangeFormat(input), Is.EqualTo(expected));
    }

}
