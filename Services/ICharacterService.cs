using System.Collections.Generic;
namespace DotNet7_Project.Services
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);

    }
}
