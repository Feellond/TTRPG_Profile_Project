using Azure.Core;
using IdentityModel;
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
    public class FormulaService : BaseService<Formula, int>
    {
        public FormulaService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var formulas = await _dbContext.Formulas.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(fcl => fcl.FormulaSubstanceList)
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
                    ItemType = (int)ItemEntityType.Formula,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    FormulaSubstanceList = item.FormulaSubstanceList,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = formulas
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var formula = _dbContext.Formulas.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(fcl => fcl.FormulaSubstanceList)
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
                    ItemType = (int)ItemEntityType.Formula,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    FormulaSubstanceList = item.FormulaSubstanceList,
                    ImageFileName = item.ImageFileName,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { formula },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(FormulaRequest request)
        {
            Formula newFormula = new Formula()
            {
                AdditionalPayment = request.AdditionalPayment,
                AvailabilityType = request.AvailabilityType,
                Complexity = request.Complexity,
                Description = request.Description,
                FormulaSubstanceList = request.FormulaSubstanceList?.Select(dto => new FormulaSubstanceList
                {
                    SubstanceType = dto.SubstanceType,
                    Amount = dto.Amount,
                }).ToList() ?? new List<FormulaSubstanceList>(),
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Formula,
                Name = request.Name,
                Price = request.Price,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
                TimeSpend = request.TimeSpend,
                Weight = request.Weight,
                ImageFileName = request.ImageFileName,
            };

            await _dbContext.Formulas.AddAsync(newFormula);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(FormulaRequest request)
        {
            var formula = _dbContext.Formulas.Where(x => x.Id == request.Id).FirstOrDefault();
            if (formula is null)
                throw new CustomException("Формула не найдена!");

            formula.Name = request.Name;
            formula.UpdateDate = DateTime.Now;
            formula.TimeSpend = request.TimeSpend;
            formula.Weight = request.Weight;
            formula.Price = request.Price;
            formula.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            formula.AdditionalPayment = request.AdditionalPayment;
            formula.Complexity = request.Complexity;
            formula.Description = request.Description;
            formula.AvailabilityType = request.AvailabilityType;
            formula.ImageFileName = request.ImageFileName;

            var fsList = await _dbContext.FormulaComponentList.Where(x => x.FormulaId == formula.Id).ToListAsync();
            _dbContext.FormulaComponentList.RemoveRange(fsList);

            formula.FormulaSubstanceList = request.FormulaSubstanceList?.Select(dto => new FormulaSubstanceList
            {
                Id = dto.Id ?? 0,
                FormulaId = formula.Id,
                SubstanceType = dto.SubstanceType,
                Amount = dto.Amount,
            }).ToList() ?? new List<FormulaSubstanceList>();

            _dbContext.Entry(formula).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var formula = await _dbContext.Formulas.Include(x => x.FormulaSubstanceList).Include(x => x.ItemBaseEffectList).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (formula is null)
                throw new CustomException("Формула не найдена");

            formula.FormulaSubstanceList = new List<FormulaSubstanceList>();
            formula.ItemBaseEffectList = new List<ItemBaseEffectList>();

            _dbContext.Remove(formula);
            return await SaveAsync();
        }
    }
}
