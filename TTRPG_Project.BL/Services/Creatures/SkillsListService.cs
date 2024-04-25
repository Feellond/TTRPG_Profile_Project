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
    public class SkillsListService : BaseService<SkillsList, int>
    {
        public SkillsListService(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }

        public async Task<SkillsListResponce> GetAllAsync()
        {
            var skillsLists = await _dbContext.SkillsList.AsNoTracking().ToListAsync();

            SkillsListResponce responce = new()
            {
                Count = skillsLists.Count(),
                SkillsLists = skillsLists,
            };

            return responce;
        }

        public async Task<SkillsListResponce> GetByIdAsync(int id)
        {
            var skillsList = await _dbContext.SkillsList.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();

            if (skillsList is null)
                throw new CustomException("Существа с таким id не существует");

            SkillsListResponce responce = new()
            {
                Count = 1,
                SkillsLists = new List<SkillsList>() { skillsList },
            };

            return responce;
        }

        public async Task<SkillsList> CreateAsync(SkillsListRequest request)
        {
            SkillsList skillsList = new()
            {
                AlchemyValue = request.AlchemyValue,
                AppearanceValue = request.AppearanceValue,
                ArcheryValue = request.ArcheryValue,
                ArtistryValue = request.ArtistryValue,
                AthleticsValue = request.AthleticsValue,
                AttentionValue = request.AttentionValue,
                CamouflageValue = request.CamouflageValue,
                CharismaValue = request.CharismaValue,
                CityOrientationValue = request.CityOrientationValue,
                CourageValue = request.CourageValue,
                CrossbowMasteryValue = request.CrossbowMasteryValue,
                DeceptionValue = request.DeceptionValue,
                DeductionValue = request.DeductionValue,
                EducationValue = request.EducationValue,
                EnduranceValue = request.EnduranceValue,
                EtiquetteValue = request.EtiquetteValue,
                EvasionValue = request.EvasionValue,
                FirstAidValue = request.FirstAidValue,
                ForgeryValue = request.ForgeryValue,
                GamblingValue = request.GamblingValue,
                IntimidationValue = request.IntimidationValue,
                KnowledgeTransferValue = request.KnowledgeTransferValue,
                LanguageGeneralValue = request.LanguageGeneralValue,
                LanguageHighValue = request.LanguageHighValue,
                LanguageDwarfValue = request.LanguageDwarfValue,
                LeadershipValue = request.LeadershipValue,
                LightBladeMasteryValue = request.LightBladeMasteryValue,
                LockpickingValue = request.LockpickingValue,
                MagicResistanceValue = request.MagicResistanceValue,
                ManualDexterityValue = request.ManualDexterityValue,
                ManufacturingValue = request.ManufacturingValue,
                MeleeCombatValue = request.MeleeCombatValue,
                MonsterologyValue = request.MonsterologyValue,
                PersuasionResistanceValue = request.PersuasionResistanceValue,
                PersuasionValue = request.PersuasionValue,
                PoleWeaponMasteryValue = request.PoleWeaponMasteryValue,
                PublicSpeakingValue = request.PublicSpeakingValue,
                RidingValue = request.RidingValue,
                RitualsValue = request.RitualsValue,
                SeamanshipValue = request.SeamanshipValue,
                SeductionValue = request.SeductionValue,
                SpellcastingValue = request.SpellcastingValue,
                StealthValue = request.StealthValue,
                StrengthValue = request.StrengthValue,
                SurvivalValue = request.SurvivalValue,
                SwordsmanshipValue = request.SwordsmanshipValue,
                TacticsValue = request.TacticsValue,
                TradingValue = request.TradingValue,
                TrapKnowledgeValue = request.TrapKnowledgeValue,
                UnderstandingPeopleValue = request.UnderstandingPeopleValue,
                WrestlingValue = request.WrestlingValue,
            };

            await _dbContext.SkillsList.AddAsync(skillsList);
            var result = await SaveAsync();
            if (result)
                return skillsList;
            else
                throw new CustomException("Ошибка создания списка способностей!");
        }

        public async Task<bool> UpdateAsync(SkillsListRequest request)
        {
            var skillsList = await _dbContext.SkillsList.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (skillsList is null)
                throw new CustomException("Существо не найдено!");

            skillsList.AlchemyValue = request.AlchemyValue;
            skillsList.AppearanceValue = request.AppearanceValue;
            skillsList.ArcheryValue = request.ArcheryValue;
            skillsList.ArtistryValue = request.ArtistryValue;
            skillsList.AthleticsValue = request.AthleticsValue;
            skillsList.AttentionValue = request.AttentionValue;
            skillsList.CamouflageValue = request.CamouflageValue;
            skillsList.CharismaValue = request.CharismaValue;
            skillsList.CityOrientationValue = request.CityOrientationValue;
            skillsList.CourageValue = request.CourageValue;
            skillsList.CrossbowMasteryValue = request.CrossbowMasteryValue;
            skillsList.DeceptionValue = request.DeceptionValue;
            skillsList.DeductionValue = request.DeductionValue;
            skillsList.EducationValue = request.EducationValue;
            skillsList.EnduranceValue = request.EnduranceValue;
            skillsList.EtiquetteValue = request.EtiquetteValue;
            skillsList.EvasionValue = request.EvasionValue;
            skillsList.FirstAidValue = request.FirstAidValue;
            skillsList.ForgeryValue = request.ForgeryValue;
            skillsList.GamblingValue = request.GamblingValue;
            skillsList.IntimidationValue = request.IntimidationValue;
            skillsList.KnowledgeTransferValue = request.KnowledgeTransferValue;
            skillsList.LanguageGeneralValue = request.LanguageGeneralValue;
            skillsList.LanguageHighValue = request.LanguageHighValue;
            skillsList.LanguageDwarfValue = request.LanguageDwarfValue;
            skillsList.LeadershipValue = request.LeadershipValue;
            skillsList.LightBladeMasteryValue = request.LightBladeMasteryValue;
            skillsList.LockpickingValue = request.LockpickingValue;
            skillsList.MagicResistanceValue = request.MagicResistanceValue;
            skillsList.ManualDexterityValue = request.ManualDexterityValue;
            skillsList.ManufacturingValue = request.ManufacturingValue;
            skillsList.MeleeCombatValue = request.MeleeCombatValue;
            skillsList.MonsterologyValue = request.MonsterologyValue;
            skillsList.PersuasionResistanceValue = request.PersuasionResistanceValue;
            skillsList.PersuasionValue = request.PersuasionValue;
            skillsList.PoleWeaponMasteryValue = request.PoleWeaponMasteryValue;
            skillsList.PublicSpeakingValue = request.PublicSpeakingValue;
            skillsList.RidingValue = request.RidingValue;
            skillsList.RitualsValue = request.RitualsValue;
            skillsList.SeamanshipValue = request.SeamanshipValue;
            skillsList.SeductionValue = request.SeductionValue;
            skillsList.SpellcastingValue = request.SpellcastingValue;
            skillsList.CorruptionValue = request.CorruptionValue;
            skillsList.StealthValue = request.StealthValue;
            skillsList.StrengthValue = request.StrengthValue;
            skillsList.SurvivalValue = request.SurvivalValue;
            skillsList.SwordsmanshipValue = request.SwordsmanshipValue;
            skillsList.TacticsValue = request.TacticsValue;
            skillsList.TradingValue = request.TradingValue;
            skillsList.TrapKnowledgeValue = request.TrapKnowledgeValue;
            skillsList.UnderstandingPeopleValue = request.UnderstandingPeopleValue;
            skillsList.WrestlingValue = request.WrestlingValue;
            skillsList.UpdateDate = DateTime.Now;

            _dbContext.Entry(skillsList).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var skillsList = await _dbContext.SkillsList.FindAsync(id);
            if (skillsList is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(skillsList);
            return await SaveAsync();
        }
    }
}
