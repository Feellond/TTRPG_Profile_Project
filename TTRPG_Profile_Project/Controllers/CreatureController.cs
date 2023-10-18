using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO.Additional.Request;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.Services.Creatures;
using AutoMapper;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.BL.DTO.Creatures.Request;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [ApiController]
    [Route("api/creatures")]
    [Produces("application/json")]
    public class CreatureController : ControllerBase
    {
        #region Инициализация контроллера
        private readonly AbilityService _abilityService;
        private readonly AttackService _attackService;
        private readonly ClassService _classService;
        private readonly CreatureService _creatureService;
        private readonly RaceService _raceService;
        private readonly SkillService _skillService;
        private readonly StatService _statService;
        private readonly IMapper _mapper;

        public CreatureController(
            AbilityService abilityService, 
            AttackService attackService, 
            ClassService classService, 
            CreatureService creatureService, 
            RaceService raceService, 
            SkillService skillService, 
            StatService statService,
            IMapper mapper)
        {
            _abilityService = abilityService;
            _attackService = attackService;
            _classService = classService;
            _creatureService = creatureService;
            _raceService = raceService;
            _skillService = skillService;
            _statService = statService;
            _mapper = mapper;
        }
        #endregion

        [HttpGet("skill")]
        public async Task<IActionResult> GetSkills()
        {
            var result = await _skillService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("skill/{id}")]
        public async Task<IActionResult> GetSkill([FromRoute] int id)
        {
            var result = await _skillService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("skill")]
        public async Task<IActionResult> CreateSkill([FromBody] SkillRequest request)
        {
            if (ModelState.IsValid)
            {
                var newSkill = _mapper.Map<Skill>(request);
                var result = await _skillService.CreateAsync(newSkill);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("skill")]
        public async Task<IActionResult> EditSkill([FromBody] SkillRequest request)
        {
            if (ModelState.IsValid)
            {
                var skill = _mapper.Map<Skill>(request);
                var result = await _skillService.UpdateAsync(skill);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("skill")]
        public async Task<IActionResult> DeleteSkill(int effectId)
        {
            var item = await _skillService.GetByIdAsync(effectId);
            if (item is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _skillService.DeleteAsync(item!);
            return Ok(result);
        }
    }
}
