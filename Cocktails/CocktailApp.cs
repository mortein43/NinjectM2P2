namespace NinjectM2P2.Cocktails;

public class CocktailApp
{
    private readonly ICocktailService _cocktailService;
    private readonly IOutputService _outputService;
    private readonly IFileService _fileService;

    public CocktailApp(ICocktailService cocktailService, IOutputService outputService, IFileService fileService)
    {
        _cocktailService = cocktailService;
        _outputService = outputService;
        _fileService = fileService;
    }

    public void Run()
    {
        DisplayCocktailInfo("Маргарита");
        DisplayCocktailInfo("Мохіто");
        DisplayCocktailInfo("Негроні");

        _fileService.WriteToFile("cocktail.txt", "Інформація про коктейлі:");
        _fileService.WriteToFile("cocktail.txt", _cocktailService.GetCocktailInfo("Маргарита"));
        _fileService.WriteToFile("cocktail.txt", _cocktailService.GetCocktailInfo("Мохіто"));
        _fileService.WriteToFile("cocktail.txt", _cocktailService.GetCocktailInfo("Негроні"));
    }
    private void DisplayCocktailInfo(string cocktailName)
    {
        var cocktailInfo = _cocktailService.GetCocktailInfo(cocktailName);
        _outputService.Display($"{cocktailName} інформація:");
        _outputService.Display(cocktailInfo);
        _outputService.Display("".PadLeft(30, '='));
    }
}
