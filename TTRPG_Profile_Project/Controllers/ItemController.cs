using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [ApiController]
    [Route("api/items")]
    //[Produces("application/json")]
    //[Consumes("application/json")]
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

        public ItemController(
            AlchemicalItemService alchemicalItemService,
            ArmorService armorService,
            BlueprintService blueprintService,
            ComponentService componentService,
            FormulaService formulaService,
            ItemBaseService itemBaseService,
            ItemService itemService, 
            ToolService toolService, 
            WeaponService weaponService
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
        ///  "itemBaseEffectList": [
        ///    {
        ///      "effectId": 1,
        ///      "damage": "1d6+2",
        ///      "chancePercent": 10,
        ///      "isDealDamage": true
        ///    }
        ///  ],
        ///   "creatureRewardList": [
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
        public async Task<IActionResult> CreateAlchemicalItem([FromBody] AlchemicalItemRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _alchemicalItemService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("alchemicalitem")]
        public async Task<IActionResult> UpdateAlchemicalItem([FromBody] AlchemicalItemRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _alchemicalItemService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("alchemicalitem/{Id}")]
        public async Task<IActionResult> DeleteAlchemicalItem(int Id)
        {
            var result = await _alchemicalItemService.DeleteAsync(Id);
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
        [HttpGet("armor/{id}")]
        public async Task<IActionResult> GetArmor([FromRoute] int id)
        {
            var result = await _armorService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("armor")]
        public async Task<IActionResult> CreateArmor([FromBody] ArmorRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _armorService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("armor")]
        public async Task<IActionResult> UpdateArmor([FromBody] ArmorRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _armorService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("armor/{Id}")]
        public async Task<IActionResult> DeleteArmor(int Id)
        {
            var result = await _armorService.DeleteAsync(Id);
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

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("blueprint/{id}")]
        public async Task<IActionResult> GetBlueprint([FromRoute] int id)
        {
            var result = await _blueprintService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("blueprint")]
        public async Task<IActionResult> CreateBlueprint([FromBody] BlueprintRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _blueprintService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("blueprint")]
        public async Task<IActionResult> UpdateBlueprint([FromBody] BlueprintRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _blueprintService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("blueprint/{Id}")]
        public async Task<IActionResult> DeleteBlueprint(int Id)
        {
            var result = await _blueprintService.DeleteAsync(Id);
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

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("component/{id}")]
        public async Task<IActionResult> GetComponent([FromRoute] int id)
        {
            var result = await _blueprintService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("component")]
        public async Task<IActionResult> CreateComponent([FromBody] ComponentRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _componentService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("component")]
        public async Task<IActionResult> UpdateComponent([FromBody] ComponentRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _componentService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("component/{Id}")]
        public async Task<IActionResult> DeleteComponent(int Id)
        {
            var result = await _componentService.DeleteAsync(Id);
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

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("formula/{id}")]
        public async Task<IActionResult> GetFormula([FromRoute] int id)
        {
            var result = await _formulaService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("formula")]
        public async Task<IActionResult> CreateFormula([FromBody] FormulaRequest request)
        {
            if (ModelState.IsValid)
            {
                //var newFormula = _mapper.Map<Formula>(request);               
                var result = await _formulaService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("formula")]
        public async Task<IActionResult> UpdateFormula([FromBody] FormulaRequest request)
        {
            if (ModelState.IsValid)
            {
                //var formula = _mapper.Map<Formula>(request);
                var result = await _formulaService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("formula/{Id}")]
        public async Task<IActionResult> DeleteFormula(int Id)
        {
            var result = await _formulaService.DeleteAsync(Id);
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

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("item/{id}")]
        public async Task<IActionResult> GetItem([FromRoute] int id)
        {
            var result = await _itemService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("item")]
        public async Task<IActionResult> CreateItem([FromBody] ItemRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _itemService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("item")]
        public async Task<IActionResult> UpdateItem([FromBody] ItemRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _itemService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("item/{Id}")]
        public async Task<IActionResult> DeleteItem(int Id)
        {
            var result = await _itemService.DeleteAsync(Id);
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

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("tool/{id}")]
        public async Task<IActionResult> GetTool([FromRoute] int id)
        {
            var result = await _toolService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("tool")]
        public async Task<IActionResult> CreateTool([FromBody] ToolRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _toolService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("tool")]
        public async Task<IActionResult> UpdateTool([FromBody] ToolRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _toolService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("tool/{Id}")]
        public async Task<IActionResult> DeleteTool(int Id)
        {
            var result = await _toolService.DeleteAsync(Id);
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

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("weapon/{id}")]
        public async Task<IActionResult> GetWeapon([FromRoute] int id)
        {
            var result = await _weaponService.GetByIdAsync(id);
            if (result is null)
                return NotFound(new ErrorResponse { Message = "Сущность не найдена!" });

            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("weapon")]
        public async Task<IActionResult> CreateWeapon([FromBody] WeaponRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _weaponService.CreateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("weapon")]
        public async Task<IActionResult> UpdateWeapon([FromBody] WeaponRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = await _weaponService.UpdateAsync(request);
                return Ok(result);
            }
            else return BadRequest(new ErrorResponse { Message = "Не правильно заполнены данные!" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("weapon/{Id}")]
        public async Task<IActionResult> DeleteWeapon(int Id)
        {
            var result = await _weaponService.DeleteAsync(Id);
            return Ok(result);
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////

        #region *ItemBase* Базовые предметы (абсолютно все)
        [AllowAnonymous]
        [HttpGet("base")]
        public async Task<IActionResult> GetBaseItems([FromQuery] ItemFilter filter)
        {
            filter.InitFilter();
            var result = await _itemBaseService.GetAllAsync(filter);

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("baseSimple")]
        public async Task<IActionResult> GetBaseItemsSimple()
        {
            var result = await _itemBaseService.GetAllSimpleAsync();

            return Ok(result);
        }
        #endregion
    }
}
