namespace VechiclesFleet.Services.Contracts;

public interface IAppSettingsReader
{
    string GetValue(string section, string key);
}