using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById();
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}