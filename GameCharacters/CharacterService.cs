namespace NinjectM2P2.GameCharacters;

public class CharacterService : ICharacterService
{
    private readonly IOutputService _outputService;

    public CharacterService(IOutputService outputService)
    {
        _outputService = outputService;
    }

    public string GetCharacterInfo(string characterType)
    {
        switch (characterType.ToLower())
        {
            case "піхотинець":
                return "Піхота: піший солдат, озброєний холодною зброєю.";
            case "лучник":
                return "Лучник: нападник дальньої дії, озброєний луком і стрілами.";
            case "копійщик":
                return "Копійщик: вправний воїн, що володіє списом.";
            default:
                return "Невідомий персонаж.";
        }
    }

    public void Attack(string attackerType, string targetType)
    {
        _outputService.Display($"{attackerType} атакує {targetType}");
    }

    public string GetAttackInfo(string attackerType, string targetType)
    {
        return $"{attackerType} атакує {targetType}!";
    }
}
