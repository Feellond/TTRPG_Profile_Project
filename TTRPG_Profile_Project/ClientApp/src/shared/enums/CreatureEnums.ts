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
  Resistance = 1,
  Immunity = 2,
  Vulnerability = 3,
}

export { AbilityType, AttackType, CreatureEffectType };
