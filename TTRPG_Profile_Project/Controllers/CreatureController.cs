using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO.Additional.Request;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.Services.Creatures;
using AutoMapper;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.BL.DTO.Creatures.Request;
using System.Diagnostics;

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
        private readonly SkillsListService _skillsListService;
        private readonly SkillsTreeService _skillsTreeService;
        private readonly StatService _statService;
        private readonly StatsListService _statsListService;
        private readonly IMapper _mapper;

        public CreatureController(
            AbilityService abilityService, 
            AttackService attackService, 
            ClassService classService, 
            CreatureService creatureService, 
            RaceService raceService, 
            SkillService skillService, 
            StatService statService,
            SkillsListService skillsListService,
            SkillsTreeService skillsTreeService,
            StatsListService statsListService,
            IMapper mapper)
        {
            _abilityService = abilityService;
            _attackService = attackService;
            _classService = classService;
            _creatureService = creatureService;
            _raceService = raceService;
            _skillService = skillService;
            _skillsListService = skillsListService;
            _skillsTreeService = skillsTreeService;
            _statService = statService;
            _statsListService = statsListService;
            _mapper = mapper;
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Ability* Способности
        [HttpGet("ability")]
        public async Task<IActionResult> GetAbilities()
        {
            var result = await _abilityService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("ability/{id}")]
        public async Task<IActionResult> GetAbility([FromRoute] int id)
        {
            var result = await _abilityService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("ability")]
        public async Task<IActionResult> CreateAbility([FromBody] AbilitiyRequest request)
        {
            if (ModelState.IsValid)
            {
                var newAbility = _mapper.Map<Abilitiy>(request);
                var result = await _abilityService.CreateAsync(newAbility);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("ability")]
        public async Task<IActionResult> EditAbility([FromBody] AbilitiyRequest request)
        {
            if (ModelState.IsValid)
            {
                var ability = _mapper.Map<Abilitiy>(request);
                var result = await _abilityService.UpdateAsync(ability);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("ability")]
        public async Task<IActionResult> DeleteAbility(int abilityId)
        {
            var ability = await _abilityService.GetByIdAsync(abilityId);
            if (ability is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _abilityService.DeleteAsync(ability!);
            return Ok(result);
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Attack* Атака
        [HttpGet("attack")]
        public async Task<IActionResult> GetAttacks()
        {
            var result = await _attackService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("attack/{id}")]
        public async Task<IActionResult> GetAttack([FromRoute] int id)
        {
            var result = await _attackService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("attack")]
        public async Task<IActionResult> CreateAttack([FromBody] AttackRequest request)
        {
            if (ModelState.IsValid)
            {
                var newAttack = _mapper.Map<Attack>(request);
                var result = await _attackService.CreateAsync(newAttack);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("attack")]
        public async Task<IActionResult> EditAttack([FromBody] AttackRequest request)
        {
            if (ModelState.IsValid)
            {
                var attack = _mapper.Map<Attack>(request);
                var result = await _attackService.UpdateAsync(attack);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("attack")]
        public async Task<IActionResult> DeleteAttack(int attackId)
        {
            var attack = await _attackService.GetByIdAsync(attackId);
            if (attack is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _attackService.DeleteAsync(attack!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Class* Класс
        [HttpGet("class")]
        public async Task<IActionResult> GetClasses()
        {
            var result = await _classService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("class/{id}")]
        public async Task<IActionResult> GetClass([FromRoute] int id)
        {
            var result = await _classService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("class")]
        public async Task<IActionResult> CreateClass([FromBody] ClassRequest request)
        {
            if (ModelState.IsValid)
            {
                var newClass = _mapper.Map<Class>(request);
                var result = await _classService.CreateAsync(newClass);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("class")]
        public async Task<IActionResult> EditClass([FromBody] ClassRequest request)
        {
            if (ModelState.IsValid)
            {
                var editClass = _mapper.Map<Class>(request);
                var result = await _classService.UpdateAsync(editClass);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("class")]
        public async Task<IActionResult> DeleteClass(int classId)
        {
            var deleteClass = await _classService.GetByIdAsync(classId);
            if (deleteClass is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _classService.DeleteAsync(deleteClass!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Creature* Существо, Бестия, Монстр
        [HttpGet("creature")]
        public async Task<IActionResult> GetCreatures()
        {
            var result = await _creatureService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("creature/{id}")]
        public async Task<IActionResult> GetCreature([FromRoute] int id)
        {
            var result = await _creatureService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("creature")]
        public async Task<IActionResult> CreateCreature([FromBody] CreatureRequest request)
        {
            if (ModelState.IsValid)
            {
                var newCreature = _mapper.Map<Creature>(request);
                var result = await _creatureService.CreateAsync(newCreature);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("creature")]
        public async Task<IActionResult> EditCreature([FromBody] CreatureRequest request)
        {
            if (ModelState.IsValid)
            {
                var creature = _mapper.Map<Creature>(request);
                var result = await _creatureService.UpdateAsync(creature);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("creature")]
        public async Task<IActionResult> DeleteCreature(int creatureId)
        {
            var creature = await _creatureService.GetByIdAsync(creatureId);
            if (creature is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _creatureService.DeleteAsync(creature!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Race* Раса существа, монстра
        [HttpGet("race")]
        public async Task<IActionResult> GetRaces()
        {
            var result = await _raceService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("race/{id}")]
        public async Task<IActionResult> GetRace([FromRoute] int id)
        {
            var result = await _raceService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("race")]
        public async Task<IActionResult> CreateRace([FromBody] RaceRequest request)
        {
            if (ModelState.IsValid)
            {
                var newRace = _mapper.Map<Race>(request);
                var result = await _raceService.CreateAsync(newRace);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("race")]
        public async Task<IActionResult> EditRace([FromBody] RaceRequest request)
        {
            if (ModelState.IsValid)
            {
                var race = _mapper.Map<Race>(request);
                var result = await _raceService.UpdateAsync(race);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("race")]
        public async Task<IActionResult> DeleteRace(int raceId)
        {
            var race = await _raceService.GetByIdAsync(raceId);
            if (race is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _raceService.DeleteAsync(race!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Skill* Навыки
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
        public async Task<IActionResult> DeleteSkill(int skillId)
        {
            var item = await _skillService.GetByIdAsync(skillId);
            if (item is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _skillService.DeleteAsync(item!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *SkillList* Список навыков
        [HttpGet("skillList")]
        public async Task<IActionResult> GetSkillsList()
        {
            var result = await _skillsListService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("skillList/{id}")]
        public async Task<IActionResult> GetSkillList([FromRoute] int id)
        {
            var result = await _skillsListService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("skillList")]
        public async Task<IActionResult> CreateSkillList([FromBody] SkillsListRequest request)
        {
            if (ModelState.IsValid)
            {
                var newSkillList = _mapper.Map<SkillsList>(request);
                var result = await _skillsListService.CreateAsync(newSkillList);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("skillList")]
        public async Task<IActionResult> EditSkillList([FromBody] SkillsListRequest request)
        {
            if (ModelState.IsValid)
            {
                var skillList = _mapper.Map<SkillsList>(request);
                var result = await _skillsListService.UpdateAsync(skillList);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("skillList")]
        public async Task<IActionResult> DeleteSkillList(int skillListId)
        {
            var skillList = await _skillsListService.GetByIdAsync(skillListId);
            if (skillList is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _skillsListService.DeleteAsync(skillList!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *SkillTree* Дерево навыков
        [HttpGet("skillTree")]
        public async Task<IActionResult> GetSkillsTree()
        {
            var result = await _skillsTreeService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("skillTree/{id}")]
        public async Task<IActionResult> GetSkillTree([FromRoute] int id)
        {
            var result = await _skillsTreeService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("skillTree")]
        public async Task<IActionResult> CreateSkillTree([FromBody] SkillsTreeRequest request)
        {
            if (ModelState.IsValid)
            {
                var newSkillTree = _mapper.Map<SkillsTree>(request);
                var result = await _skillsTreeService.CreateAsync(newSkillTree);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("skillTree")]
        public async Task<IActionResult> EditSkillTree([FromBody] SkillsTreeRequest request)
        {
            if (ModelState.IsValid)
            {
                var skillTree = _mapper.Map<SkillsTree>(request);
                var result = await _skillsTreeService.UpdateAsync(skillTree);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("skillTree")]
        public async Task<IActionResult> DeleteSkillTree(int skillTreeId)
        {
            var skillTree = await _skillsTreeService.GetByIdAsync(skillTreeId);
            if (skillTree is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _skillsTreeService.DeleteAsync(skillTree!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Stat* Характеристика
        [HttpGet("stat")]
        public async Task<IActionResult> GetStats()
        {
            var result = await _statService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("stat/{id}")]
        public async Task<IActionResult> GetStat([FromRoute] int id)
        {
            var result = await _statService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("stat")]
        public async Task<IActionResult> CreateStat([FromBody] StatRequest request)
        {
            if (ModelState.IsValid)
            {
                var newStat = _mapper.Map<Stat>(request);
                var result = await _statService.CreateAsync(newStat);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("stat")]
        public async Task<IActionResult> EditStat([FromBody] SkillsListRequest request)
        {
            if (ModelState.IsValid)
            {
                var stat = _mapper.Map<Stat>(request);
                var result = await _statService.UpdateAsync(stat);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("stat")]
        public async Task<IActionResult> DeleteStat(int statId)
        {
            var stat = await _statService.GetByIdAsync(statId);
            if (stat is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _statService.DeleteAsync(stat!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *StatList* Список характеристик
        [HttpGet("statList")]
        public async Task<IActionResult> GetStatsList()
        {
            var result = await _statsListService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("statList/{id}")]
        public async Task<IActionResult> GetStatList([FromRoute] int id)
        {
            var result = await _statsListService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("statList")]
        public async Task<IActionResult> CreateStatList([FromBody] StatsListRequest request)
        {
            if (ModelState.IsValid)
            {
                var newStatList = _mapper.Map<StatsList>(request);
                var result = await _statsListService.CreateAsync(newStatList);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("statList")]
        public async Task<IActionResult> EditStatList([FromBody] StatsListRequest request)
        {
            if (ModelState.IsValid)
            {
                var statList = _mapper.Map<StatsList>(request);
                var result = await _statsListService.UpdateAsync(statList);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("statList")]
        public async Task<IActionResult> DeleteStatList(int statListId)
        {
            var statList = await _statsListService.GetByIdAsync(statListId);
            if (statList is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _statsListService.DeleteAsync(statList!);
            return Ok(result);
        }
        #endregion
    }
}
