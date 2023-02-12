using Microsoft.Extensions.Configuration;

public class AppSettingsData : IAppSettingsData
{
    public string TestString => _testString;
    public int TestInt => _testInt;

    private readonly IConfiguration _config;
    private readonly string _testString;
    private readonly int _testInt;

    public AppSettingsData(IConfiguration config)
    {
        _config = config;

        _testString = GetString(_config.GetSection("TestStrings").GetSection("TestString").Value);
        _testInt = GetInt(_config.GetSection("TestInts").GetSection("TestInt").Value);
        
    }

    private string GetString(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Value is null or empty");
        }
        return value;
    }

    private int GetInt(string toInt)
    {
        try
        {
           return Convert.ToInt32(toInt);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine($"Cant convert {toInt} to int. New Value is set to 0" + e);
            return 0;
        }
    }
}