using Microsoft.Extensions.Configuration;

public class AppSettingsData : IAppSettingsData
{
    private readonly IConfiguration _config;

    public AppSettingsData(IConfiguration config)
    {
        _config = config;
    }
    public string TestString => _config.GetSection("TestStrings").GetSection("TestString").Value;
    public int TestInt => int.Parse(_config.GetSection("TestInts").GetSection("TestInt").Value);
}