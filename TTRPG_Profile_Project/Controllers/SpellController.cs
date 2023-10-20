using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.Services.Additional;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.BL.Services.Spells;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
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
    }
}
