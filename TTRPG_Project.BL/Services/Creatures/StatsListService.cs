using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class StatsListService : BaseService<StatsList, int>
    {
        public StatsListService(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }

        public async Task<StatsListResponce> GetAllAsync()
        {
            var statsLists = await _dbContext.StatsList.AsNoTracking().ToListAsync();

            StatsListResponce responce = new()
            {
                Count = statsLists.Count(),
                StatsLists = statsLists,
            };

            return responce;
        }

        public async Task<StatsListResponce> GetByIdAsync(int id)
        {
            var statsList = await _dbContext.StatsList.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();

            if (statsList is null)
                throw new CustomException("Существа с таким id не существует");

            StatsListResponce responce = new()
            {
                Count = 1,
                StatsLists = new List<StatsList>() { statsList },
            };

            return responce;
        }

        public async Task<StatsList> CreateAsync(StatsListRequest request)
        {
            StatsList statsList = new()
            {
                ConstitutionValue = request.ConstitutionValue,
                CraftsmanshipValue = request.CraftsmanshipValue,
                DexterityValue = request.DexterityValue,
                EmpathyValue = request.EmpathyValue,
                EnduranceValue = request.EnduranceValue,
                EnergyValue = request.EnergyValue,
                HandStrikeValue = request.HandStrikeValue,
                HealthPointsValue = request.HealthPointsValue,
                IntellectValue = request.IntellectValue,
                JumpingValue = request.JumpingValue,
                KickValue = request.KickValue,
                LuckValue = request.LuckValue,
                ReactionValue = request.ReactionValue,
                ResilienceValue = request.ResilienceValue,
                RestValue = request.RestValue,
                RunningValue = request.RunningValue,
                SpeedValue = request.SpeedValue,
                WeightValue = request.WeightValue,
                WillpowerValue = request.WillpowerValue,
            };

            await _dbContext.StatsList.AddAsync(statsList);
            var result = await SaveAsync();
            if (result)
                return statsList;
            else
                throw new CustomException("Существо не найдено!");
        }

        public async Task<bool> UpdateAsync(StatsListRequest request)
        {
            var statsList = await _dbContext.StatsList.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (statsList is null)
                throw new CustomException("Существо не найдено!");

            statsList.ConstitutionValue = request.ConstitutionValue;
            statsList.CraftsmanshipValue = request.CraftsmanshipValue;
            statsList.DexterityValue = request.DexterityValue;
            statsList.EmpathyValue = request.EmpathyValue;
            statsList.EnduranceValue = request.EnduranceValue;
            statsList.EnergyValue = request.EnergyValue;
            statsList.HandStrikeValue = request.HandStrikeValue;
            statsList.HealthPointsValue = request.HealthPointsValue;
            statsList.IntellectValue = request.IntellectValue;
            statsList.JumpingValue = request.JumpingValue;
            statsList.KickValue = request.KickValue;
            statsList.LuckValue = request.LuckValue;
            statsList.ReactionValue = request.ReactionValue;
            statsList.ResilienceValue = request.ResilienceValue;
            statsList.RestValue = request.RestValue;
            statsList.RunningValue = request.RunningValue;
            statsList.SpeedValue = request.SpeedValue;
            statsList.WeightValue = request.WeightValue;
            statsList.WillpowerValue = request.WillpowerValue;
            statsList.UpdateDate = DateTime.Now;

            _dbContext.Entry(statsList).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var statsList = await _dbContext.StatsList.FindAsync(id);
            if (statsList is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(statsList);
            return await SaveAsync();
        }
    }
}
