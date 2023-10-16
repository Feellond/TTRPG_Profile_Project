using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [ApiController]
    [Route("api/items")]
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

        #region Алхимия (зельки и предметы)
        [AllowAnonymous]
        [HttpGet("alchemicalitem")]
        public async Task<IActionResult> GetAlchemicalItems()
        {
            var result = await _alchemicalItemService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("alchemicalitem/{id}")]
        public async Task<IActionResult> GetAlchemicalItem([FromRoute] int id)
        {
            var result = await _alchemicalItemService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("alchemicalitem")]
        public async Task<IActionResult> CreateAlchemicalItem(AlchemicalItem alchemicalItem)
        {
            var result = await _alchemicalItemService.CreateAsync(alchemicalItem);
            return Ok(result);
        }

        [HttpPut("alchemicalitem")]
        public async Task<IActionResult> UpdateAlchemicalItem(AlchemicalItem alchemicalItem)
        {
            var result = await _alchemicalItemService.UpdateAsync(alchemicalItem);
            return Ok(result);
        }

        [HttpDelete("alchemicalitem")]
        public async Task<IActionResult> DeleteAlchemicalItem(int alchemicalItemId)
        {
            var item = await _alchemicalItemService.GetByIdAsync(alchemicalItemId);
            var result = await _alchemicalItemService.DeleteAsync(item);
            return Ok(result);
        }
        #endregion

        [AllowAnonymous]
        [HttpGet("armor")]
        public async Task<IActionResult> GetArmors()
        {
            var result = await _armorService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("blueprint")]
        public async Task<IActionResult> GetBlueprints()
        {
            var result = await _blueprintService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("component")]
        public async Task<IActionResult> GetComponents()
        {
            var result = await _componentService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("formula")]
        public async Task<IActionResult> GetFormulas()
        {
            var result = await _formulaService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("base")]
        public async Task<IActionResult> GetBaseItems()
        {
            var result = await _itemBaseService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("item")]
        public async Task<IActionResult> GetItems()
        {
            var result = await _itemService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("tool")]
        public async Task<IActionResult> GetTools()
        {
            var result = await _toolService.GetAllAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("weapon")]
        public async Task<IActionResult> GetWeapons()
        {
            var result = await _weaponService.GetAllAsync();
            return Ok(result);
        }
    }
}
