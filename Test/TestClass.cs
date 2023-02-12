
using Microsoft.Extensions.Configuration;

public class TestClass : ITestClass
{
    private readonly IConfiguration _config;
    public TestClass(IConfiguration config)
    {
        _config = config;
    }

    public void TestMethode()
    {
        System.Console.WriteLine("Test hat jefunzt");
        System.Console.WriteLine($"appsettings: {_config.GetSection("TestStrings").GetSection("TestString").Value}");
    }
}