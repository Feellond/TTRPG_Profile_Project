using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [ApiController]
    [Route("api/items")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class ItemController : ControllerBase
    {
        #region Инициализация контроллера
        private readonly AlchemicalItemService _alchemicalItemService;
        private readonly ArmorService _armorService;
        private readonly BlueprintService _blueprintService;
        private readonly ComponentService _componentService;
        private readonly FormulaService _formulaService;
        private readonly ItemBaseService _itemBaseService;
        private readonly ItemService _itemService;
        private readonly ToolService _toolService;
        private readonly WeaponService _weaponService;
        private readonly IMapper _mapper;

        public ItemController(
            AlchemicalItemService alchemicalItemService,
            ArmorService armorService,
            BlueprintService blueprintService,
            ComponentService componentService,
            FormulaService formulaService,
            ItemBaseService itemBaseService,
            ItemService itemService, 
            ToolService toolService, 
            WeaponService weaponService,
            IMapper mapper
            )
        {
            _alchemicalItemService = alchemicalItemService;
            _armorService = armorService;
            _blueprintService = blueprintService;
            _componentService = componentService;
            _formulaService = formulaService;
            _itemBaseService = itemBaseService;
            _itemService = itemService;
            _toolService = toolService;
            _weaponService = weaponService;
            _mapper = mapper;
        }
        #endregion

        #region *AlchemicalItem* Алхимия (зельки и предметы)
        /// <summary>
        /// Получение всех алхимических предметов, элексиров
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("alchemicalitem")]
        public async Task<IActionResult> GetAlchemicalItems()
        {
            var result = await _alchemicalItemService.GetAllAsync();
            return Ok(result);
        }

        /// <summary>
        /// Получение алхимического предмета, элексира по его Id
        /// </summary>
        /// <param name="id">Id в БД</param>
        /// <returns></returns>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("alchemicalitem/{id}")]
        public async Task<IActionResult> GetAlchemicalItem([FromRoute] int id)
        {
            var result = await _alchemicalItemService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        /// <summary>
        /// Создание алхимического предмета, элексира
        /// </summary>
        /// <param name="alchemicalItem"></param>
        /// <remarks>
        /// Пример входных данных:
        /// 
        /// POST api/items/alchemicalitem
        /// {
        ///  "name": "Зелье скоростного умерщвления",
        ///  "availabilityType": 1,
        ///  "weight": 0.5,
        ///  "price": 100,
        ///  "itemBaseEffectLists": [
        ///    {
        ///      "effectId": 1,
        ///      "damage": "1d6+2",
        ///      "chancePercent": 10,
        ///      "isDealDamage": true
        ///    }
        ///  ],
        ///   "creatureRewardLists": [
        ///  {
        ///    "creatureId": 1,
        ///    "itemBaseId": 2,
        ///    "amount": "1d6/2"
        ///  }
        /// ]
        ///}
        /// </remarks>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("alchemicalitem")]
        public async Task<IActionResult> CreateAlchemicalItem([FromBody] AlchemicalItemRequest alchemicalItem)
        {
            if (ModelState.IsValid)
            {
                var newAlcItem = _mapper.Map<AlchemicalItem>(alchemicalItem);
                var result = await _alchemicalItemService.CreateAsync(newAlcItem);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("alchemicalitem")]
        public async Task<IActionResult> UpdateAlchemicalItem([FromBody] AlchemicalItemRequest alchemicalItem)
        {
            if (ModelState.IsValid)
            {
                var AlcItem = _mapper.Map<AlchemicalItem>(alchemicalItem);
                var result = await _alchemicalItemService.UpdateAsync(AlcItem);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("alchemicalitem")]
        public async Task<IActionResult> DeleteAlchemicalItem(int alchemicalItemId)
        {
            var item = await _alchemicalItemService.GetByIdAsync(alchemicalItemId);
            if (item is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _alchemicalItemService.DeleteAsync(item!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Armor* Броня
        [AllowAnonymous]
        [HttpGet("armor")]
        public async Task<IActionResult> GetArmors()
        {
            var result = await _armorService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("alchemicalitem/{id}")]
        public async Task<IActionResult> GetArmor([FromRoute] int id)
        {
            var result = await _armorService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("alchemicalitem")]
        public async Task<IActionResult> CreateArmor([FromBody] AlchemicalItemRequest alchemicalItem)
        {
            if (ModelState.IsValid)
            {
                var newArmor = _mapper.Map<Armor>(alchemicalItem);
                var result = await _armorService.CreateAsync(newArmor);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("alchemicalitem")]
        public async Task<IActionResult> UpdateArmor([FromBody] AlchemicalItemRequest alchemicalItem)
        {
            if (ModelState.IsValid)
            {
                var armor = _mapper.Map<Armor>(alchemicalItem);
                var result = await _armorService.UpdateAsync(armor);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("alchemicalitem")]
        public async Task<IActionResult> DeleteArmor(int alchemicalItemId)
        {
            var item = await _armorService.GetByIdAsync(alchemicalItemId);
            if (item is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            var result = await _armorService.DeleteAsync(item!);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Blueprint* Чертежи
        [AllowAnonymous]
        [HttpGet("blueprint")]
        public async Task<IActionResult> GetBlueprints()
        {
            var result = await _blueprintService.GetAllAsync();
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Components* Компоненты
        [AllowAnonymous]
        [HttpGet("component")]
        public async Task<IActionResult> GetComponents()
        {
            var result = await _componentService.GetAllAsync();
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Formulas* Формулы
        [AllowAnonymous]
        [HttpGet("formula")]
        public async Task<IActionResult> GetFormulas()
        {
            var result = await _formulaService.GetAllAsync();
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *ItemBase* Базовые предметы (абсолютно все)
        [AllowAnonymous]
        [HttpGet("base")]
        public async Task<IActionResult> GetBaseItems()
        {
            var result = await _itemBaseService.GetAllAsync();
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Items* Предметы
        [AllowAnonymous]
        [HttpGet("item")]
        public async Task<IActionResult> GetItems()
        {
            var result = await _itemService.GetAllAsync();
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Tools* Инструменты
        [AllowAnonymous]
        [HttpGet("tool")]
        public async Task<IActionResult> GetTools()
        {
            var result = await _toolService.GetAllAsync();
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *Weapons* Оружие и боеприпасы
        [AllowAnonymous]
        [HttpGet("weapon")]
        public async Task<IActionResult> GetWeapons()
        {
            var result = await _weaponService.GetAllAsync();
            return Ok(result);
        }
        #endregion
    }
}
