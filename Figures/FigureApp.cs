namespace NinjectM2P2.Figures;

public class FigureApp
{
    private readonly IFigureService _figureService;
    private readonly IOutputService _outputService;
    private readonly IFileService _fileService;

    public FigureApp(IFigureService figureService, IOutputService outputService, IFileService fileService)
    {
        _figureService = figureService;
        _outputService = outputService;
        _fileService = fileService;
    }

    public void Run()
    {
        DisplayFigureInfo("коло");
        DisplayFigureInfo("прямокутник");
        DisplayFigureInfo("трикутник");

        _fileService.WriteToFile("figure.txt", "Інформація про фігури:");
        _fileService.WriteToFile("figure.txt", "Коло:");
        _fileService.WriteToFile("figure.txt", _figureService.GetFigureInfo("коло"));
        _fileService.WriteToFile("figure.txt", "Прямокутник:");
        _fileService.WriteToFile("figure.txt", _figureService.GetFigureInfo("прямокутник"));
        _fileService.WriteToFile("figure.txt", "Трикутник:");
        _fileService.WriteToFile("figure.txt", _figureService.GetFigureInfo("трикутник"));
    }

    private void DisplayFigureInfo(string figureName)
    {
        var figureInfo = _figureService.GetFigureInfo(figureName);
        _outputService.Display($"{figureName} інформація:");
        _outputService.Display(figureInfo);
        _outputService.Display("".PadLeft(30, '='));
    }
}
