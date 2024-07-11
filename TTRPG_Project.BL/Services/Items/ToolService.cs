using Microsoft.EntityFrameworkCore;
using TTRPG_Project.BL.DTO.Entities.Items;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Items
{
    public class ToolService : BaseService<Tool, int>
    {
        public ToolService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var tools = await _dbContext.Tools.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Select(item => new ItemBaseInfo
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = item.Source,
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.Tool,
                    StealthType = item.StealthType,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = tools,
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var tool = _dbContext.Tools.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Select(item => new ItemBaseInfo
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = item.Source,
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.Tool,
                    StealthType = item.StealthType,
                    ImageFileName = item.ImageFileName,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { tool },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(ToolRequest request)
        {
            Tool newTool = new()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Tool,
                ItemBaseEffectList = request.ItemBaseEffectList?.Select(dto => new ItemBaseEffectList
                {
                    ChancePercent = dto.ChancePercent,
                    Damage = dto.Damage,
                    EffectId = dto.Effect?.Id ?? 0,
                    IsDealDamage = dto.IsDealDamage,
                }).ToList() ?? new List<ItemBaseEffectList>(),
                Name = request.Name,
                Price = request.Price,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
                Weight = request.Weight,
                StealthType = request.StealthType,
                ImageFileName = request.ImageFileName,
            };

            await _dbContext.Tools.AddAsync(newTool);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(ToolRequest request)
        {
            var tool = _dbContext.Tools.Where(x => x.Id == request.Id).FirstOrDefault();
            if (tool is null)
                throw new CustomException("Предмет не не найден!");

            tool.Name = request.Name;
            tool.UpdateDate = DateTime.Now;
            tool.Weight = request.Weight;
            tool.Price = request.Price;
            tool.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            tool.Description = request.Description;
            tool.AvailabilityType = request.AvailabilityType;
            tool.StealthType = request.StealthType;
            tool.ImageFileName = request.ImageFileName;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == tool.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            tool.ItemBaseEffectList = request.ItemBaseEffectList?.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = tool.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList() ?? new List<ItemBaseEffectList>();

            _dbContext.Entry(tool).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var tool = await _dbContext.Tools.FindAsync(id);
            if (tool is null)
                throw new CustomException("Предмет не найден");

            _dbContext.Remove(tool);
            return await SaveAsync();
        }
    }
}
