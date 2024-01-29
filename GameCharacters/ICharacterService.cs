namespace NinjectM2P2.GameCharacters;

public interface ICharacterService
{
    string GetCharacterInfo(string characterType);
    void Attack(string attackerType, string targetType);
    string GetAttackInfo(string attackerType, string targetType);
}
