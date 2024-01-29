namespace NinjectM2P2.GameCharacters;

public class GameCharactersApp
{
    private readonly ICharacterService _characterService;
    private readonly IOutputService _outputService;
    private readonly IFileService _fileService;

    public GameCharactersApp(ICharacterService characterService, IOutputService outputService, IFileService fileService)
    {
        _characterService = characterService;
        _outputService = outputService;
        _fileService = fileService;
    }

    public void Run()
    {
        DisplayCharacterInfo("Піхотинець");
        DisplayCharacterInfo("Лучник");
        DisplayCharacterInfo("Копійщик");

        Console.WriteLine("Бійка:");
        Attack("Піхотинець", "Лучника");
        Attack("Копійщик", "Піхотинця");


        _fileService.WriteToFile("character.txt", "Інформація про персонажів:");
        _fileService.WriteToFile("character.txt", _characterService.GetCharacterInfo("Піхотинець"));
        _fileService.WriteToFile("character.txt", _characterService.GetCharacterInfo("Лучник"));
        _fileService.WriteToFile("character.txt", _characterService.GetCharacterInfo("Копійщик"));

        _fileService.WriteToFile("character.txt", "Бійка:");
        _fileService.WriteToFile("character.txt", _characterService.GetAttackInfo("Піхотинець", "Лучника"));
        _fileService.WriteToFile("character.txt", _characterService.GetAttackInfo("Копійщик", "Піхотинця"));
    }

    private void DisplayCharacterInfo(string characterType)
    {
        var characterInfo = _characterService.GetCharacterInfo(characterType);
        _outputService.Display($"{characterType} інформація:");
        _outputService.Display(characterInfo);
        _outputService.Display("".PadLeft(30, '='));
    }

    public void Attack(string attackerType, string targetType)
    {
        _characterService.Attack(attackerType, targetType);
    }


}
