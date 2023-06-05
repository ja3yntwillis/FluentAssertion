using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;



string actual = "ABCDEFGHI";
string expected = "ABCDEFGHI";
 void normalAssertions(string text)
{
    try
    {
        Assert.AreEqual(actual, text+"df");
    }
    catch(Exception w)
    {
        Console.WriteLine(w.ToString());
    }
}

 void usingFluentAssertions(string text)
{
    try
    {
        actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EFc").And.HaveLength(9).And.Be(expected);
    }
    catch (Exception ex) { Console.WriteLine( ex.Message); }
}

normalAssertions(expected);
usingFluentAssertions(expected);




