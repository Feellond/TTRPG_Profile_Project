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

        public async Task<bool> CreateAsync(SkillsListRequest request)
        {
            SkillsList skillsList = new()
            {
                AlchemyId = request.AlchemyId,
                AlchemyValue = request.AlchemyValue,
                AppearanceId = request.AppearanceId,
                AppearanceValue = request.AppearanceValue,
                ArcheryId = request.ArcheryId,
                ArcheryValue = request.ArcheryValue,
                ArtistryId = request.ArtistryId,
                ArtistryValue = request.ArtistryValue,
                AthleticsId = request.AthleticsId,
                AthleticsValue = request.AthleticsValue,
                AttentionId = request.AttentionId,
                AttentionValue = request.AttentionValue,
                CamouflageId = request.CamouflageId,
                CamouflageValue = request.CamouflageValue,
                CharismaId = request.CharismaId,
                CharismaValue = request.CharismaValue,
                CityOrientationId = request.CityOrientationId,
                CityOrientationValue = request.CityOrientationValue,
                CourageId = request.CourageId,
                CourageValue = request.CourageValue,
                CrossbowMasteryId = request.CrossbowMasteryId,
                CrossbowMasteryValue = request.CrossbowMasteryValue,
                DeceptionId = request.DeceptionId,
                DeceptionValue = request.DeceptionValue,
                DeductionId = request.DeductionId,
                DeductionValue = request.DeductionValue,
                EducationId = request.EducationId,
                EducationValue = request.EducationValue,
                EnduranceId = request.EnduranceId,
                EnduranceValue = request.EnduranceValue,
                EtiquetteId = request.EtiquetteId,
                EtiquetteValue = request.EtiquetteValue,
                EvasionId = request.EvasionId,
                EvasionValue = request.EvasionValue,
                FirstAidId = request.FirstAidId,
                FirstAidValue = request.FirstAidValue,
                ForgeryId = request.ForgeryId,
                ForgeryValue = request.ForgeryValue,
                GamblingId = request.GamblingId,
                GamblingValue = request.GamblingValue,
                IntimidationId = request.IntimidationId,
                IntimidationValue = request.IntimidationValue,
                KnowledgeTransferId = request.KnowledgeTransferId,
                KnowledgeTransferValue = request.KnowledgeTransferValue,
                LanguageGeneralId = request.LanguageGeneralId,
                LanguageGeneralValue = request.LanguageGeneralValue,
                LanguageHighId = request.LanguageHighId,
                LanguageHighValue = request.LanguageHighValue,
                LanguageDwarfId = request.LanguageDwarfId,
                LanguageDwarfValue = request.LanguageDwarfValue,
                LeadershipId = request.LeadershipId,
                LeadershipValue = request.LeadershipValue,
                LightBladeMasteryId = request.LightBladeMasteryId,
                LightBladeMasteryValue = request.LightBladeMasteryValue,
                LockpickingId = request.LockpickingId,
                LockpickingValue = request.LockpickingValue,
                MagicResistanceId = request.MagicResistanceId,
                MagicResistanceValue = request.MagicResistanceValue,
                ManualDexterityId = request.ManualDexterityId,
                ManualDexterityValue = request.ManualDexterityValue,
                ManufacturingId = request.ManufacturingId,
                ManufacturingValue = request.ManufacturingValue,
                MeleeCombatId = request.MeleeCombatId,
                MeleeCombatValue = request.MeleeCombatValue,
                MonsterologyId = request.MonsterologyId,
                MonsterologyValue = request.MonsterologyValue,
                PersuasionId = request.PersuasionId,
                PersuasionResistanceId = request.PersuasionResistanceId,
                PersuasionResistanceValue = request.PersuasionResistanceValue,
                PersuasionValue = request.PersuasionValue,
                PoleWeaponMasteryId = request.PoleWeaponMasteryId,
                PoleWeaponMasteryValue = request.PoleWeaponMasteryValue,
                PublicSpeakingId = request.PublicSpeakingId,
                PublicSpeakingValue = request.PublicSpeakingValue,
                RidingId = request.RidingId,
                RidingValue = request.RidingValue,
                RitualsId = request.RitualsId,
                RitualsValue = request.RitualsValue,
                SeamanshipId = request.SeamanshipId,
                SeamanshipValue = request.SeamanshipValue,
                SeductionId = request.SeductionId,
                SeductionValue = request.SeductionValue,
                SpellcastingId = request.SpellcastingId,
                SpellcastingValue = request.SpellcastingValue,
                StealthId = request.StealthId,
                StealthValue = request.StealthValue,
                StrengthId = request.StrengthId,
                StrengthValue = request.StrengthValue,
                SurvivalId = request.SurvivalId,
                SurvivalValue = request.SurvivalValue,
                SwordsmanshipId = request.SwordsmanshipId,
                SwordsmanshipValue = request.SwordsmanshipValue,
                TacticsId = request.TacticsId,
                TacticsValue = request.TacticsValue,
                TradingId = request.TradingId,
                TradingValue = request.TradingValue,
                TrapKnowledgeId = request.TrapKnowledgeId,
                TrapKnowledgeValue = request.TrapKnowledgeValue,
                UnderstandingPeopleId = request.UnderstandingPeopleId,
                UnderstandingPeopleValue = request.UnderstandingPeopleValue,
                WrestlingId = request.WrestlingId,
                WrestlingValue = request.WrestlingValue,
            };

            await _dbContext.SkillsList.AddAsync(skillsList);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(SkillsListRequest request)
        {
            var skillsList = await _dbContext.SkillsList.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (skillsList is null)
                throw new CustomException("Существо не найдено!");

            skillsList.AlchemyId = request.AlchemyId;
            skillsList.AlchemyValue = request.AlchemyValue;
            skillsList.AppearanceId = request.AppearanceId;
            skillsList.AppearanceValue = request.AppearanceValue;
            skillsList.ArcheryId = request.ArcheryId;
            skillsList.ArcheryValue = request.ArcheryValue;
            skillsList.ArtistryId = request.ArtistryId;
            skillsList.ArtistryValue = request.ArtistryValue;
            skillsList.AthleticsId = request.AthleticsId;
            skillsList.AthleticsValue = request.AthleticsValue;
            skillsList.AttentionId = request.AttentionId;
            skillsList.AttentionValue = request.AttentionValue;
            skillsList.CamouflageId = request.CamouflageId;
            skillsList.CamouflageValue = request.CamouflageValue;
            skillsList.CharismaId = request.CharismaId;
            skillsList.CharismaValue = request.CharismaValue;
            skillsList.CityOrientationId = request.CityOrientationId;
            skillsList.CityOrientationValue = request.CityOrientationValue;
            skillsList.CourageId = request.CourageId;
            skillsList.CourageValue = request.CourageValue;
            skillsList.CrossbowMasteryId = request.CrossbowMasteryId;
            skillsList.CrossbowMasteryValue = request.CrossbowMasteryValue;
            skillsList.DeceptionId = request.DeceptionId;
            skillsList.DeceptionValue = request.DeceptionValue;
            skillsList.DeductionId = request.DeductionId;
            skillsList.DeductionValue = request.DeductionValue;
            skillsList.EducationId = request.EducationId;
            skillsList.EducationValue = request.EducationValue;
            skillsList.EnduranceId = request.EnduranceId;
            skillsList.EnduranceValue = request.EnduranceValue;
            skillsList.EtiquetteId = request.EtiquetteId;
            skillsList.EtiquetteValue = request.EtiquetteValue;
            skillsList.EvasionId = request.EvasionId;
            skillsList.EvasionValue = request.EvasionValue;
            skillsList.FirstAidId = request.FirstAidId;
            skillsList.FirstAidValue = request.FirstAidValue;
            skillsList.ForgeryId = request.ForgeryId;
            skillsList.ForgeryValue = request.ForgeryValue;
            skillsList.GamblingId = request.GamblingId;
            skillsList.GamblingValue = request.GamblingValue;
            skillsList.IntimidationId = request.IntimidationId;
            skillsList.IntimidationValue = request.IntimidationValue;
            skillsList.KnowledgeTransferId = request.KnowledgeTransferId;
            skillsList.KnowledgeTransferValue = request.KnowledgeTransferValue;
            skillsList.LanguageGeneralId = request.LanguageGeneralId;
            skillsList.LanguageGeneralValue = request.LanguageGeneralValue;
            skillsList.LanguageHighId = request.LanguageHighId;
            skillsList.LanguageHighValue = request.LanguageHighValue;
            skillsList.LanguageDwarfId = request.LanguageDwarfId;
            skillsList.LanguageDwarfValue = request.LanguageDwarfValue;
            skillsList.LeadershipId = request.LeadershipId;
            skillsList.LeadershipValue = request.LeadershipValue;
            skillsList.LightBladeMasteryId = request.LightBladeMasteryId;
            skillsList.LightBladeMasteryValue = request.LightBladeMasteryValue;
            skillsList.LockpickingId = request.LockpickingId;
            skillsList.LockpickingValue = request.LockpickingValue;
            skillsList.MagicResistanceId = request.MagicResistanceId;
            skillsList.MagicResistanceValue = request.MagicResistanceValue;
            skillsList.ManualDexterityId = request.ManualDexterityId;
            skillsList.ManualDexterityValue = request.ManualDexterityValue;
            skillsList.ManufacturingId = request.ManufacturingId;
            skillsList.ManufacturingValue = request.ManufacturingValue;
            skillsList.MeleeCombatId = request.MeleeCombatId;
            skillsList.MeleeCombatValue = request.MeleeCombatValue;
            skillsList.MonsterologyId = request.MonsterologyId;
            skillsList.MonsterologyValue = request.MonsterologyValue;
            skillsList.PersuasionId = request.PersuasionId;
            skillsList.PersuasionResistanceId = request.PersuasionResistanceId;
            skillsList.PersuasionResistanceValue = request.PersuasionResistanceValue;
            skillsList.PersuasionValue = request.PersuasionValue;
            skillsList.PoleWeaponMasteryId = request.PoleWeaponMasteryId;
            skillsList.PoleWeaponMasteryValue = request.PoleWeaponMasteryValue;
            skillsList.PublicSpeakingId = request.PublicSpeakingId;
            skillsList.PublicSpeakingValue = request.PublicSpeakingValue;
            skillsList.RidingId = request.RidingId;
            skillsList.RidingValue = request.RidingValue;
            skillsList.RitualsId = request.RitualsId;
            skillsList.RitualsValue = request.RitualsValue;
            skillsList.SeamanshipId = request.SeamanshipId;
            skillsList.SeamanshipValue = request.SeamanshipValue;
            skillsList.SeductionId = request.SeductionId;
            skillsList.SeductionValue = request.SeductionValue;
            skillsList.SpellcastingId = request.SpellcastingId;
            skillsList.SpellcastingValue = request.SpellcastingValue;
            skillsList.StealthId = request.StealthId;
            skillsList.StealthValue = request.StealthValue;
            skillsList.StrengthId = request.StrengthId;
            skillsList.StrengthValue = request.StrengthValue;
            skillsList.SurvivalId = request.SurvivalId;
            skillsList.SurvivalValue = request.SurvivalValue;
            skillsList.SwordsmanshipId = request.SwordsmanshipId;
            skillsList.SwordsmanshipValue = request.SwordsmanshipValue;
            skillsList.TacticsId = request.TacticsId;
            skillsList.TacticsValue = request.TacticsValue;
            skillsList.TradingId = request.TradingId;
            skillsList.TradingValue = request.TradingValue;
            skillsList.TrapKnowledgeId = request.TrapKnowledgeId;
            skillsList.TrapKnowledgeValue = request.TrapKnowledgeValue;
            skillsList.UnderstandingPeopleId = request.UnderstandingPeopleId;
            skillsList.UnderstandingPeopleValue = request.UnderstandingPeopleValue;
            skillsList.WrestlingId = request.WrestlingId;
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
