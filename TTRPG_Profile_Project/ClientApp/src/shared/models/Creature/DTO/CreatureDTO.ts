import { EntityBase, EntityDescriptionBase } from "shared/models/Base";

interface Creature extends EntityDescriptionBase{
  RaceId: number;
  AdditionalInformation: string;
  EducationSkill: number;
  SuperstitionsInformation: string;
  MonsterLoreSkill: number;
  MonsterLoreInformation: string;
  Complexity: number;
  MoneyReward: number;
  Armor: number;
  Regeneration: number;
  StatsListId?: number;
  StatsList?: StatsList;
  SkillsListId?: number;
  SkillsList?: SkillsList;
  CreatureEffectList: CreatureEffectList[];
  EvasionBase: number;
  AthleticsBase: number;
  BlockBase: number;
  SpellResistBase: number;
  Height: number;
  Weight: number;
  HabitatPlace: string;
  Intellect: string;
  GroupSize: string;
  Attacks: Attack[];
  Abilities: Abilitiy[];
  CreatureRewardList: CreatureRewardList[];
  //Spells: Spell[];
}

export interface StatsList {
  // Define the properties for StatsList here
}

export interface SkillsList {
  // Define the properties for SkillsList here
}

export interface CreatureEffectList {
  // Define the properties for CreatureEffectList here
}

export interface Attack {
  // Define the properties for Attack here
}

export interface Abilitiy {
  // Define the properties for Abilitiy here
}

export interface CreatureRewardList {
  // Define the properties for CreatureRewardList here
}

export interface Stat extends EntityDescriptionBase {}

export interface Skill extends EntityDescriptionBase {
  isDifficult: boolean;
  isClassSkill: boolean;
  statId: number;
  stat: Stat;
}

export interface CreatureReward extends EntityBase {
  itemBaseId: number;
  creatureId: number;
  amount: string | null;
}
