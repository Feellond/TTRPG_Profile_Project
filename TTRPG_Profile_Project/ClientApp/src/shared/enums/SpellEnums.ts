enum SpellLevel {
  Novice = 1,
  Journeyman = 2,
  Master = 3,
  ArchPriest = 4,
}

enum SpellType {
  Spell = 1,
  Invocation = 2,
  Sign = 3,
  Ritual = 4,
  Hex = 5,
}

enum SpellSource {
  Mixed = 1,
  Earth = 2,
  Fire = 3,
  Air = 4,
  Water = 5,
}

enum SpellCategory {
  Magic = 1,
  Necromancy = 2,
  Goethia = 3,
  PriestInvocation = 4,
  DruidInvocation = 5,
}

export {SpellLevel, SpellType, SpellSource, SpellCategory}