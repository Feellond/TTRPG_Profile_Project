using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class StatsListRequest : BaseDescriptionDTO
    {
        public int IntellectId { get; set; }
        public int IntellectValue { get; set; }

        public int ReactionId { get; set; }
        public int ReactionValue { get; set; }

        public int DexterityId { get; set; }
        public int DexterityValue { get; set; }

        public int ConstitutionId { get; set; }
        public int ConstitutionValue { get; set; }

        public int SpeedId { get; set; }
        public int SpeedValue { get; set; }

        public int EmpathyId { get; set; }
        public int EmpathyValue { get; set; }

        public int CraftsmanshipId { get; set; }
        public int CraftsmanshipValue { get; set; }

        public int WillpowerId { get; set; }
        public int WillpowerValue { get; set; }

        public int LuckId { get; set; }
        public int LuckValue { get; set; }

        public int EnergyId { get; set; }
        public int EnergyValue { get; set; }

        public int ResilienceId { get; set; }
        public int ResilienceValue { get; set; }

        public int RunningId { get; set; }
        public int RunningValue { get; set; }

        public int JumpingId { get; set; }
        public int JumpingValue { get; set; }

        public int HealthPointsId { get; set; }
        public int HealthPointsValue { get; set; }

        public int EnduranceId { get; set; }
        public int EnduranceValue { get; set; }

        public int WeightId { get; set; }
        public int WeightValue { get; set; }

        public int RestId { get; set; }
        public int RestValue { get; set; }

        public int HandStrikeId { get; set; }
        public int HandStrikeValue { get; set; }

        public int KickId { get; set; }
        public int KickValue { get; set; }
    }
}
