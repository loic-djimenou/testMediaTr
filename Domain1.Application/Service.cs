namespace Domain1.Application;

public class Service: IService
{
    public string[] GetSummaries(string someParams)
    {
        return new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Lava Hot", "Iceland beach"
        };
    }
}