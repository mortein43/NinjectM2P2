namespace NinjectM2P2.Devices;

public class DeviceService : IDeviceService
{
    private readonly IOutputService _outputService;

    public DeviceService(IOutputService outputService)
    {
        _outputService = outputService;
    }

    public string GetDeviceInfo(string deviceName)
    {
        switch (deviceName.ToLower())
        {
            case "кавомолка":
                return "Кавомолка – відмінний побутовий прилад, що дозволяє перемелювати сухі інгредієнти у дрібний порошок.";
            case "міксер":
                return "Міксер — пристрій, що призначений для механічного перемішування, створення однорідної маси і її тимчасової підтримки різних за складом рідких і сипучих речовин.";
            case "блендер":
                return "Блендер — настільний електроприлад, призначений для подрібнення їжі, готування емульсій, пюре, збивання напоїв, мусів тощо, а також розколювання льоду.";
            default:
                return "Невідомий прилад";
        }
    }
}
