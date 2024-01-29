namespace NinjectM2P2.Cocktails;

public class CocktailService : ICocktailService
{
    private readonly IOutputService _outputService;
    public CocktailService(IOutputService outputService)
    {
        _outputService = outputService;
    }

    public string GetCocktailInfo(string cocktailName)
    {
        switch (cocktailName.ToLower())
        {
            case "маргарита":
                return "Маргарита: класичний коктейль, що складається з текіли, соку лайма і трипл-сек.";
            case "мохіто":
                return "Мохіто: освіжаючий коктейль, виготовлений з білого рому, соку лайма, цукру, м’яти та газованої води.";
            case "негроні":
                return "Негроні: італійський коктейль, виготовлений з джину, вермуту россо та кампарі.";
            default:
                return "Невідомий коктейль.";
        }
    }
}
