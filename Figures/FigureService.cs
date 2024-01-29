namespace NinjectM2P2.Figures;

public class FigureService : IFigureService
{
    private readonly IOutputService _outputService;

    public FigureService(IOutputService outputService)
    {
        _outputService = outputService;
    }

    public string GetFigureInfo(string figureName)
    {
        switch (figureName.ToLower())
        {
            case "коло":
                return "\n  ***\n *   *\n *   *\n  ***";
            case "прямокутник":
                return "\t\t\t\n******\t\t\t\n*    *\t\t\t\n******";
            case "трикутник":
                return "  *\n ***\n*****";
            default:
                return "Невідома фігура.";
        }
    }
}
