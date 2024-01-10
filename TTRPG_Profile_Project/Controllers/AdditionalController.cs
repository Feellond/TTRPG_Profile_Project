using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Additional.Request;
using TTRPG_Project.BL.DTO.Entities.Additional.Request;
using TTRPG_Project.BL.Services.Additional;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.Web.Controllers
{
    //[Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [AllowAnonymous]
    [ApiController]
    [Route("api/additionals")]
    [Produces("application/json")]
    public class AdditionalController : ControllerBase
    {
        #region Инициализация контроллера
        private readonly EffectService _effectService;
        private readonly SourceService _sourceService;
        private readonly ServicePriceService _servicePriceService;
        private readonly IMapper _mapper;

        public AdditionalController(EffectService effectService, SourceService sourceService, ServicePriceService servicePriceService, IMapper mapper)
        {
            _effectService = effectService;
            _sourceService = sourceService;
            _servicePriceService = servicePriceService;
            _mapper = mapper;
        }
        #endregion

        #region *Effect* Эффекты, состояния
        [HttpGet("effect")]
        public async Task<IActionResult> GetEffects()
        {
            var result = await _effectService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("effect/{id}")]
        public async Task<IActionResult> GetEffect([FromRoute] int id)
        {
            var result = await _effectService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("effect")]
        public async Task<IActionResult> CreateEffect([FromBody] EffectRequest request)
        {
            if (ModelState.IsValid)
            {
                var newEffect = _mapper.Map<Effect>(request);
                var result = await _effectService.CreateAsync(newEffect);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("effect")]
        public async Task<IActionResult> EditEffect([FromBody] EffectRequest request)
        {
            if (ModelState.IsValid)
            {
                var effect = _mapper.Map<Effect>(request);
                var result = await _effectService.UpdateAsync(effect);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("effect")]
        public async Task<IActionResult> DeleteEffect(int effectId)
        {
            var item = await _effectService.GetByIdAsync(effectId);
            if (item is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _effectService.DeleteAsync(item!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////        

        #region *Effect* Эффекты, состояния
        [HttpGet("source")]
        public async Task<IActionResult> GetSources()
        {
            var result = await _sourceService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("source/{id}")]
        public async Task<IActionResult> GetSource([FromRoute] int id)
        {
            var result = await _sourceService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [HttpPost("source")]
        public async Task<IActionResult> CreateSource([FromBody] SourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var newSource = _mapper.Map<Source>(request);
                var result = await _sourceService.CreateAsync(newSource);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpPut("source")]
        public async Task<IActionResult> EditSource([FromBody] SourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var source = _mapper.Map<Source>(request);
                var result = await _sourceService.UpdateAsync(source);

                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [HttpDelete("source/{id}")]
        public async Task<IActionResult> DeleteSource(int id)
        {
            var item = await _sourceService.GetByIdAsync(id);
            if (item is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _sourceService.DeleteAsync(item!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *ServicePrice* Платные сервисы
        #endregion
    }
}
