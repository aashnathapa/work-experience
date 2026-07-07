using HarryPotter.Server.Models;

namespace HarryPotter.Server.Interfaces
{
    public interface IHarryPotterService
    {
        Task<List<Character>> GetCharactersAsync();
    }
}

namespace HarryPotter.Server.Interfaces
{
    public interface IHarryPotterService
    {
        Task<List<Spells>> GetSpellsAsync();
    }
}
