namespace NinjectM2P2.Devices;

public class DeviceApp
{
    private readonly IDeviceService _deviceService;
    private readonly IOutputService _outputService;
    private readonly IFileService _fileService;

    public DeviceApp(IDeviceService deviceService, IOutputService outputService, IFileService fileService)
    {
        _deviceService = deviceService;
        _outputService = outputService;
        _fileService = fileService;
    }

    public void Run()
    {
        DisplayDeviceInfo("Кавомолка");
        DisplayDeviceInfo("Міксер");
        DisplayDeviceInfo("Блендер");

        _fileService.WriteToFile("device.txt", "Інформація про прилади:");
        _fileService.WriteToFile("device.txt", _deviceService.GetDeviceInfo("Кавомолка"));
        _fileService.WriteToFile("device.txt", _deviceService.GetDeviceInfo("Міксер"));
        _fileService.WriteToFile("device.txt", _deviceService.GetDeviceInfo("Блендер"));
    }

    private void DisplayDeviceInfo(string deviceName)
    {
        var deviceInfo = _deviceService.GetDeviceInfo(deviceName);

        _outputService.Display($"{deviceName} інформація:");
        _outputService.Display(deviceInfo);
        _outputService.Display("".PadLeft(30, '='));
    }
}
