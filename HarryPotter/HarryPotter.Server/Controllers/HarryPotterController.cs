using Microsoft.AspNetCore.Mvc;
using HarryPotter.Server.Interfaces;
using HarryPotter.Server.Models;

namespace HarryPotter.Server.Controllers
{
    [ApiController]
    [Route("harrypotter/")]
    public class HarryPotterController : ControllerBase
    {
        private readonly IHarryPotterService _harryPotterService;

        public HarryPotterController(IHarryPotterService harryPotterService)
        {
            _harryPotterService = harryPotterService;
        }

        [HttpGet("characters")]
        public async Task<IActionResult> GetCharacters()
        {
            List<Character> characters = await _harryPotterService.GetCharactersAsync();
            return Ok(characters);
        }

        [HttpGet("spells")]
        public async Task<IActionResult> GetSpells()
        {
            List<Spell> spells = await _harryPotterService.GetSpellsAsync();
            return Ok(spells);
        }
    }
}
