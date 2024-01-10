using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO.Additional.Request;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.Services.Additional;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.BL.Services.Spells;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.DAL.Entities.Database.Spells;
using TTRPG_Project.BL.DTO.Entities.Spells.Request;

namespace TTRPG_Project.Web.Controllers
{
    //[Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [AllowAnonymous]
    [ApiController]
    [Route("api/spells")]
    [Produces("application/json")]
    public class SpellController : ControllerBase
    {
        #region Инициализация контроллера
        private readonly SpellService _spellService;
        private readonly IMapper _mapper;

        public SpellController(SpellService spellService, IMapper mapper)
        {
            _spellService = spellService;
            _mapper = mapper;
        }
        #endregion

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetSpells()
        {
            var responce = await _spellService.GetAllAsync();
            return Ok(responce);
        }

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpell([FromRoute] int id)
        {
            var responce = await _spellService.GetByIdAsync(id);
            return Ok(responce);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpell([FromBody] SpellRequest request)
        {
            if (ModelState.IsValid)
            {
                var newSpell = _mapper.Map<Spell>(request);
                var result = await _spellService.CreateAsync(newSpell);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut]
        public async Task<IActionResult> EditSpell([FromBody] SpellRequest request)
        {
            if (ModelState.IsValid)
            {
                var spell = _mapper.Map<Spell>(request);
                var result = await _spellService.UpdateAsync(spell);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSpell(int spellId)
        {
            var spell = await _spellService.GetByIdAsync(spellId);
            if (spell is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _spellService.DeleteAsync(spell!);
            return Ok(result);
        }
    }
}
