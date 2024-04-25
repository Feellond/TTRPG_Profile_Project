using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("SkillsList")]
    public class SkillsList : EntityBase
    {
        public int? AttentionId { get; set; } = 1;
        public int? AttentionValue { get; set; } = 0;

        public int? SurvivalId { get; set; } = 2;
        public int? SurvivalValue { get; set; } = 0;

        public int? DeductionId { get; set; } = 3;
        public int? DeductionValue { get; set; } = 0;

        public int? MonsterologyId { get; set; } = 4;
        public int? MonsterologyValue { get; set; } = 0;

        public int? EducationId { get; set; } = 5;
        public int? EducationValue { get; set; } = 0;

        public int? CityOrientationId { get; set; } = 6;
        public int? CityOrientationValue { get; set; } = 0;

        public int? KnowledgeTransferId { get; set; } = 7;
        public int? KnowledgeTransferValue { get; set; } = 0;

        public int? TacticsId { get; set; } = 8;
        public int? TacticsValue { get; set; } = 0;

        public int? TradingId { get; set; } = 9;
        public int? TradingValue { get; set; } = 0;

        public int? EtiquetteId { get; set; } = 10;
        public int? EtiquetteValue { get; set; } = 0;

        public int? LanguageGeneralId { get; set; } = 11;
        public int? LanguageGeneralValue { get; set; } = 0;

        public int? LanguageHighId { get; set; } = 12;
        public int? LanguageHighValue { get; set; } = 0;

        public int? LanguageDwarfId { get; set; } = 13;
        public int? LanguageDwarfValue { get; set; } = 0;

        public int? StrengthId { get; set; } = 14;
        public int? StrengthValue { get; set; } = 0;

        public int? EnduranceId { get; set; } = 15;
        public int? EnduranceValue { get; set; } = 0;

        public int? MeleeCombatId { get; set; } = 16;
        public int? MeleeCombatValue { get; set; } = 0;

        public int? WrestlingId { get; set; } = 17;
        public int? WrestlingValue { get; set; } = 0;

        public int? RidingId { get; set; } = 18;
        public int? RidingValue { get; set; } = 0;

        public int? PoleWeaponMasteryId { get; set; } = 19;
        public int? PoleWeaponMasteryValue { get; set; } = 0;

        public int? LightBladeMasteryId { get; set; } = 20;
        public int? LightBladeMasteryValue { get; set; } = 0;

        public int? SwordsmanshipId { get; set; } = 21;
        public int? SwordsmanshipValue { get; set; } = 0;

        public int? SeamanshipId { get; set; } = 22;
        public int? SeamanshipValue { get; set; } = 0;

        public int? EvasionId { get; set; } = 23;
        public int? EvasionValue { get; set; } = 0;

        public int? AthleticsId { get; set; } = 24;
        public int? AthleticsValue { get; set; } = 0;

        public int? ManualDexterityId { get; set; } = 25;
        public int? ManualDexterityValue { get; set; } = 0;

        public int? StealthId { get; set; } = 26;
        public int? StealthValue { get; set; } = 0;

        public int? CrossbowMasteryId { get; set; } = 27;
        public int? CrossbowMasteryValue { get; set; } = 0;

        public int? ArcheryId { get; set; } = 28;
        public int? ArcheryValue { get; set; } = 0;

        public int? GamblingId { get; set; } = 29;
        public int? GamblingValue { get; set; } = 0;

        public int? AppearanceId { get; set; } = 30;
        public int? AppearanceValue { get; set; } = 0;

        public int? PublicSpeakingId { get; set; } = 31;
        public int? PublicSpeakingValue { get; set; } = 0;

        public int? ArtistryId { get; set; } = 32;
        public int? ArtistryValue { get; set; } = 0;

        public int? LeadershipId { get; set; } = 33;
        public int? LeadershipValue { get; set; } = 0;

        public int? DeceptionId { get; set; } = 34;
        public int? DeceptionValue { get; set; } = 0;

        public int? UnderstandingPeopleId { get; set; } = 35;
        public int? UnderstandingPeopleValue { get; set; } = 0;

        public int? SeductionId { get; set; } = 36;
        public int? SeductionValue { get; set; } = 0;

        public int? PersuasionId { get; set; } = 37;
        public int? PersuasionValue { get; set; } = 0;

        public int? CharismaId { get; set; } = 38;
        public int? CharismaValue { get; set; } = 0;

        public int? AlchemyId { get; set; } = 39;
        public int? AlchemyValue { get; set; } = 0;

        public int? LockpickingId { get; set; } = 40;
        public int? LockpickingValue { get; set; } = 0;

        public int? TrapKnowledgeId { get; set; } = 41;
        public int? TrapKnowledgeValue { get; set; } = 0;

        public int? ManufacturingId { get; set; } = 42;
        public int? ManufacturingValue { get; set; } = 0;

        public int? CamouflageId { get; set; } = 43;
        public int? CamouflageValue { get; set; } = 0;

        public int? FirstAidId { get; set; } = 44;
        public int? FirstAidValue { get; set; } = 0;

        public int? ForgeryId { get; set; } = 45;
        public int? ForgeryValue { get; set; } = 0;

        public int? IntimidationId { get; set; } = 46;
        public int? IntimidationValue { get; set; } = 0;

        public int? CorruptionId { get; set; } = 47;
        public int? CorruptionValue { get; set; } = 0;

        public int? RitualsId { get; set; } = 48;
        public int? RitualsValue { get; set; } = 0;

        public int? MagicResistanceId { get; set; } = 49;
        public int? MagicResistanceValue { get; set; } = 0;

        public int? PersuasionResistanceId { get; set; } = 50;
        public int? PersuasionResistanceValue { get; set; } = 0;

        public int? SpellcastingId { get; set; } = 51;
        public int? SpellcastingValue { get; set; } = 0;

        public int? CourageId { get; set; } = 52;
        public int? CourageValue { get; set; } = 0;
    }
}
