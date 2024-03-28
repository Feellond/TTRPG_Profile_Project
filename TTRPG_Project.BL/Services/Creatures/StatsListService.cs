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

        public async Task<bool> CreateAsync(StatsListRequest request)
        {
            StatsList statsList = new()
            {
                ConstitutionId = request.ConstitutionId,
                ConstitutionValue = request.ConstitutionValue,
                CraftsmanshipId = request.CraftsmanshipId,
                CraftsmanshipValue = request.CraftsmanshipValue,
                DexterityId = request.DexterityId,
                DexterityValue = request.DexterityValue,
                EmpathyId = request.EmpathyId,
                EmpathyValue = request.EmpathyValue,
                EnduranceId = request.EnduranceId,
                EnduranceValue = request.EnduranceValue,
                EnergyId = request.EnergyId,
                EnergyValue = request.EnergyValue,
                HandStrikeId = request.HandStrikeId,
                HandStrikeValue = request.HandStrikeValue,
                HealthPointsId = request.HealthPointsId,
                HealthPointsValue = request.HealthPointsValue,
                IntellectId = request.IntellectId,
                IntellectValue = request.IntellectValue,
                JumpingId = request.JumpingId,
                JumpingValue = request.JumpingValue,
                KickId = request.KickId,
                KickValue = request.KickValue,
                LuckId = request.LuckId,
                LuckValue = request.LuckValue,
                ReactionId = request.ReactionId,
                ReactionValue = request.ReactionValue,
                ResilienceId = request.ResilienceId,
                ResilienceValue = request.ResilienceValue,
                RestId = request.RestId,
                RestValue = request.RestValue,
                RunningId = request.RunningId,
                RunningValue = request.RunningValue,
                SpeedId = request.SpeedId,
                SpeedValue = request.SpeedValue,
                WeightId = request.WeightId,
                WeightValue = request.WeightValue,
                WillpowerId = request.WillpowerId,
                WillpowerValue = request.WillpowerValue,
            };

            await _dbContext.StatsList.AddAsync(statsList);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(StatsListRequest request)
        {
            var statsList = await _dbContext.StatsList.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (statsList is null)
                throw new CustomException("Существо не найдено!");

            statsList.ConstitutionId = request.ConstitutionId;
            statsList.ConstitutionValue = request.ConstitutionValue;
            statsList.CraftsmanshipId = request.CraftsmanshipId;
            statsList.CraftsmanshipValue = request.CraftsmanshipValue;
            statsList.DexterityId = request.DexterityId;
            statsList.DexterityValue = request.DexterityValue;
            statsList.EmpathyId = request.EmpathyId;
            statsList.EmpathyValue = request.EmpathyValue;
            statsList.EnduranceId = request.EnduranceId;
            statsList.EnduranceValue = request.EnduranceValue;
            statsList.EnergyId = request.EnergyId;
            statsList.EnergyValue = request.EnergyValue;
            statsList.HandStrikeId = request.HandStrikeId;
            statsList.HandStrikeValue = request.HandStrikeValue;
            statsList.HealthPointsId = request.HealthPointsId;
            statsList.HealthPointsValue = request.HealthPointsValue;
            statsList.IntellectId = request.IntellectId;
            statsList.IntellectValue = request.IntellectValue;
            statsList.JumpingId = request.JumpingId;
            statsList.JumpingValue = request.JumpingValue;
            statsList.KickId = request.KickId;
            statsList.KickValue = request.KickValue;
            statsList.LuckId = request.LuckId;
            statsList.LuckValue = request.LuckValue;
            statsList.ReactionId = request.ReactionId;
            statsList.ReactionValue = request.ReactionValue;
            statsList.ResilienceId = request.ResilienceId;
            statsList.ResilienceValue = request.ResilienceValue;
            statsList.RestId = request.RestId;
            statsList.RestValue = request.RestValue;
            statsList.RunningId = request.RunningId;
            statsList.RunningValue = request.RunningValue;
            statsList.SpeedId = request.SpeedId;
            statsList.SpeedValue = request.SpeedValue;
            statsList.WeightId = request.WeightId;
            statsList.WeightValue = request.WeightValue;
            statsList.WillpowerId = request.WillpowerId;
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
