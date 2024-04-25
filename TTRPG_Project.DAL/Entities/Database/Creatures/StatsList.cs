using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("StatsList")]
    public class StatsList : EntityBase
    {
        public int IntellectId { get; set; } = 1;
        public int IntellectValue { get; set; } = 0;

        public int ReactionId { get; set; } = 2;
        public int ReactionValue { get; set; } = 0;

        public int DexterityId { get; set; } = 3;
        public int DexterityValue { get; set; } = 0;

        public int ConstitutionId { get; set; } = 4;
        public int ConstitutionValue { get; set; } = 0;

        public int SpeedId { get; set; } = 5;
        public int SpeedValue { get; set; } = 0;

        public int EmpathyId { get; set; } = 6;
        public int EmpathyValue { get; set; } = 0;

        public int CraftsmanshipId { get; set; } = 7;
        public int CraftsmanshipValue { get; set; } = 0;

        public int WillpowerId { get; set; } = 8;
        public int WillpowerValue { get; set; } = 0;

        public int LuckId { get; set; } = 9;
        public int LuckValue { get; set; } = 0;

        public int EnergyId { get; set; } = 10;
        public int EnergyValue { get; set; } = 0;

        public int ResilienceId { get; set; } = 11;
        public int ResilienceValue { get; set; } = 0;

        public int RunningId { get; set; } = 12;
        public int RunningValue { get; set; } = 0;

        public int JumpingId { get; set; } = 13;
        public int JumpingValue { get; set; } = 0;

        public int HealthPointsId { get; set; } = 14;
        public int HealthPointsValue { get; set; } = 0;

        public int EnduranceId { get; set; } = 15;
        public int EnduranceValue { get; set; } = 0;

        public int WeightId { get; set; } = 16;
        public int WeightValue { get; set; } = 0;

        public int RestId { get; set; } = 17;
        public int RestValue { get; set; } = 0;

        public int HandStrikeId { get; set; } = 18;
        public int HandStrikeValue { get; set; } = 0;

        public int KickId { get; set; } = 19;
        public int KickValue { get; set; } = 0;
    }
}
