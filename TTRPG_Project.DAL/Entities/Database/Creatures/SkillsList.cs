using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("SkillsList")]
    public class SkillsList : EntityBase
    {
        public int? AttentionId { get; set; }
        public int? AttentionValue { get; set; } = 0;

        public int? SurvivalId { get; set; }
        public int? SurvivalValue { get; set; } = 0;

        public int? DeductionId { get; set; }
        public int? DeductionValue { get; set; } = 0;

        public int? MonsterologyId { get; set; }
        public int? MonsterologyValue { get; set; } = 0;

        public int? EducationId { get; set; }
        public int? EducationValue { get; set; } = 0;

        public int? CityOrientationId { get; set; }
        public int? CityOrientationValue { get; set; } = 0;

        public int? KnowledgeTransferId { get; set; }
        public int? KnowledgeTransferValue { get; set; } = 0;

        public int? TacticsId { get; set; }
        public int? TacticsValue { get; set; } = 0;

        public int? TradingId { get; set; }
        public int? TradingValue { get; set; } = 0;

        public int? EtiquetteId { get; set; }
        public int? EtiquetteValue { get; set; } = 0;

        public int? LanguageGeneralId { get; set; }
        public int? LanguageGeneralValue { get; set; } = 0;

        public int? LanguageHighId { get; set; }
        public int? LanguageHighValue { get; set; } = 0;

        public int? LanguageDwarfId { get; set; }
        public int? LanguageDwarfValue { get; set; } = 0;

        public int? StrengthId { get; set; }
        public int? StrengthValue { get; set; } = 0;

        public int? EnduranceId { get; set; }
        public int? EnduranceValue { get; set; } = 0;

        public int? MeleeCombatId { get; set; }
        public int? MeleeCombatValue { get; set; } = 0;

        public int? WrestlingId { get; set; }
        public int? WrestlingValue { get; set; } = 0;

        public int? RidingId { get; set; }
        public int? RidingValue { get; set; } = 0;

        public int? PoleWeaponMasteryId { get; set; }
        public int? PoleWeaponMasteryValue { get; set; } = 0;

        public int? LightBladeMasteryId { get; set; }
        public int? LightBladeMasteryValue { get; set; } = 0;

        public int? SwordsmanshipId { get; set; }
        public int? SwordsmanshipValue { get; set; } = 0;

        public int? SeamanshipId { get; set; }
        public int? SeamanshipValue { get; set; } = 0;

        public int? EvasionId { get; set; }
        public int? EvasionValue { get; set; } = 0;

        public int? AthleticsId { get; set; }
        public int? AthleticsValue { get; set; } = 0;

        public int? ManualDexterityId { get; set; }
        public int? ManualDexterityValue { get; set; } = 0;

        public int? StealthId { get; set; }
        public int? StealthValue { get; set; } = 0;

        public int? CrossbowMasteryId { get; set; }
        public int? CrossbowMasteryValue { get; set; } = 0;

        public int? ArcheryId { get; set; }
        public int? ArcheryValue { get; set; } = 0;

        public int? GamblingId { get; set; }
        public int? GamblingValue { get; set; } = 0;

        public int? AppearanceId { get; set; }
        public int? AppearanceValue { get; set; } = 0;

        public int? PublicSpeakingId { get; set; }
        public int? PublicSpeakingValue { get; set; } = 0;

        public int? ArtistryId { get; set; }
        public int? ArtistryValue { get; set; } = 0;

        public int? LeadershipId { get; set; }
        public int? LeadershipValue { get; set; } = 0;

        public int? DeceptionId { get; set; }
        public int? DeceptionValue { get; set; } = 0;

        public int? UnderstandingPeopleId { get; set; }
        public int? UnderstandingPeopleValue { get; set; } = 0;

        public int? SeductionId { get; set; }
        public int? SeductionValue { get; set; } = 0;

        public int? PersuasionId { get; set; }
        public int? PersuasionValue { get; set; } = 0;

        public int? CharismaId { get; set; }
        public int? CharismaValue { get; set; } = 0;

        public int? AlchemyId { get; set; }
        public int? AlchemyValue { get; set; } = 0;

        public int? LockpickingId { get; set; }
        public int? LockpickingValue { get; set; } = 0;

        public int? TrapKnowledgeId { get; set; }
        public int? TrapKnowledgeValue { get; set; } = 0;

        public int? ManufacturingId { get; set; }
        public int? ManufacturingValue { get; set; } = 0;

        public int? CamouflageId { get; set; }
        public int? CamouflageValue { get; set; } = 0;

        public int? FirstAidId { get; set; }
        public int? FirstAidValue { get; set; } = 0;

        public int? ForgeryId { get; set; }
        public int? ForgeryValue { get; set; } = 0;

        public int? IntimidationId { get; set; }
        public int? IntimidationValue { get; set; } = 0;

        public int? SpellcastingId { get; set; }
        public int? SpellcastingValue { get; set; } = 0;

        public int? RitualsId { get; set; }
        public int? RitualsValue { get; set; } = 0;

        public int? MagicResistanceId { get; set; }
        public int? MagicResistanceValue { get; set; } = 0;

        public int? PersuasionResistanceId { get; set; }
        public int? PersuasionResistanceValue { get; set; } = 0;

        public int? CourageId { get; set; }
        public int? CourageValue { get; set; } = 0;

        public int? ClassSkill { get; set; }
        public int? ClassSkillValue { get; set; } = 0;
    }
}
