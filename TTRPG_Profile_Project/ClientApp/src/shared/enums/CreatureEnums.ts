enum AbilityType {
  FullAction = 1,
  Action = 2,
  Passive = 3,
  Special = 4,
}

enum AttackType {
  Piercing = 1,
  Slashing = 2,
  Bludgeoning = 3,
  PiercingAndSlashing = 4,
  SlashingAndBludgeoning = 5,
  PiercingAndBludeoning = 6,
  PiercingAndSlashingAndBludeoning = 7,
}

enum CreatureEffectType {
  Immunity = 1,
  Resistance = 2,
  Vulnerability = 3,
}

enum Complexity {
  EasySimple = 1,
  EasyComplex = 2,
  EasyDifficult = 3,
  MediumSimple = 4,
  MediumComplex = 5,
  MediumDifficult = 6,
  HardSimple = 7,
  HardComplex = 8,
  HardDifficult = 9,
  Exceptional = 10,
}

export { AbilityType, AttackType, CreatureEffectType, Complexity };
