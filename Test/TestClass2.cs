public class TestClass2 : ITestClass
{
private readonly IAppSettingsData _appsettingsData;

    public TestClass2(IAppSettingsData appSettingsData)
    {
        _appsettingsData = appSettingsData;
    }

    public void TestMethode()
    {
        System.Console.WriteLine(_appsettingsData.TestInt);
        System.Console.WriteLine(_appsettingsData.TestString);
    }

}