using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.ObjectModelRemoting;
using Parcial0220200043.API.Models;

namespace Parcial0220200043.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ControllerBase
    {
        private readonly ITerritoryRepository _territoryRepository;
        public TerritoryController(ITerritoryRepository territoryRepository)
        {
            _territoryRepository = territoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var territory = await _territoryRepository.GetTerritory()
            return Ok(territory);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] Territory territory)
        {
            var result = await _territoryRepository.Insert(territory);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, [FromBody] Territory territory)
        {
            if (id != territory.Id)
                return BadRequest();

            var result = await _territoryRepository.Update(territory);
            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _territoryRepository.Delete(id);
            return Ok(result);
        }

    }
}
