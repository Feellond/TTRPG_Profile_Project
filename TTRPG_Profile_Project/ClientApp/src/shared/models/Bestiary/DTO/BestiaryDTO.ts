import { Effect } from "shared/models/Additional";
import { EntityBase, EntityDescriptionBase } from "shared/models/Base";
import { ItemShortDTO } from "shared/models/Item/DTO/ItemsDTO";

export interface Abilitiy extends EntityDescriptionBase {
  creature: Creature | null;
  race: Race | null;
  type: number | null;
}

export interface Attack extends EntityDescriptionBase {
  creature: Creature | null;
  baseAttack: number;
  attackType: number;
  damage: string;
  reliability: number;
  distance: number;
  attackSpeed: number;
  attackEffectList: AttackEffectList[];
}

export interface AttackEffectList {
  id: number;
  attack?: Attack | null;
  effect?: Effect | null;
  damage: string;
  chancePercent: number;
  isDealDamage: boolean;
}

export interface Class extends EntityDescriptionBase {
  energy: number;
  defaultMagicAbilities: string;
}

export interface Creature extends EntityDescriptionBase {
  race: Race;
  additionalInformation: string;
  educationSkill: number;
  superstitionsInformation: string;
  monsterLoreSkill: number;
  monsterLoreInformation: string;
  complexity: number;
  moneyReward: number;
  armor: number;
  regeneration: number;
  statsList: StatsList | null;
  skillsList: SkillsList | null;
  creatureEffectList: CreatureEffectList[];
  evasionBase: number;
  athleticsBase: number;
  blockBase: number;
  spellResistBase: number;
  height: number;
  weight: number;
  habitatPlace: string;
  intellect: string;
  groupSize: string;
  attacks: Attack[];
  abilities: Abilitiy[];
  creatureRewardList: CreatureRewardList[];
  //Spells: Spell[];
}

export interface CreatureEffectList {
  id: number;
  creature?: Creature | null;
  effect?: Effect | null;
  type: number;
  chancePercent: number;
}

export interface CreatureRewardList {
  id: number;
  creature?: Creature | null;
  itemBase?: ItemShortDTO | null;
  amount: string;
}

export interface Race extends EntityDescriptionBase {}

export interface Skill extends EntityDescriptionBase {
  isDifficult: boolean;
  isClassSkill: boolean;
  stat: Stat;
}

export interface SkillsList {
  attentionId: number;
  attentionValue: number;

  survivalId: number;
  survivalValue: number;

  deductionId: number;
  deductionValue: number;

  monsterologyId: number;
  monsterologyValue: number;

  educationId: number;
  educationValue: number;

  cityOrientationId: number;
  cityOrientationValue: number;

  knowledgeTransferId: number;
  knowledgeTransferValue: number;

  tacticsId: number;
  tacticsValue: number;

  tradingId: number;
  tradingValue: number;

  etiquetteId: number;
  etiquetteValue: number;

  languageId: number;
  languageValue: number;

  strengthId: number;
  strengthValue: number;

  enduranceId: number;
  enduranceValue: number;

  meleeCombatId: number;
  meleeCombatValue: number;

  wrestlingId: number;
  wrestlingValue: number;

  ridingId: number;
  ridingValue: number;

  poleWeaponMasteryId: number;
  poleWeaponMasteryValue: number;

  lightBladeMasteryId: number;
  lightBladeMasteryValue: number;

  swordsmanshipId: number;
  swordsmanshipValue: number;

  seamanshipId: number;
  seamanshipValue: number;

  evasionId: number;
  evasionValue: number;

  athleticsId: number;
  athleticsValue: number;

  manualDexterityId: number;
  manualDexterityValue: number;

  stealthId: number;
  stealthValue: number;

  crossbowMasteryId: number;
  crossbowMasteryValue: number;

  archeryId: number;
  archeryValue: number;

  gamblingId: number;
  gamblingValue: number;

  appearanceId: number;
  appearanceValue: number;

  publicSpeakingId: number;
  publicSpeakingValue: number;

  artistryId: number;
  artistryValue: number;

  leadershipId: number;
  leadershipValue: number;

  deceptionId: number;
  deceptionValue: number;

  understandingPeopleId: number;
  understandingPeopleValue: number;

  seductionId: number;
  seductionValue: number;

  persuasionResistanceId: number;
  persuasionResistanceValue: number;

  courageId: number;
  courageValue: number;

  classSkill?: number;
  classSkillValue: number;
}

export interface SkillsTree extends EntityBase {
  class?: Class;

  mainSkillId: number;
  mainSkillValue: number;

  firstLeftSkillId: number;
  secondLeftSkillId: number;
  thirdLeftSkillId: number;
  firstLeftSkillValue: number;
  secondLeftSkillValue: number;
  thirdLeftSkillValue: number;

  firstMiddleSkillId: number;
  secondMiddleSkillId: number;
  thirdMiddleSkillId: number;
  firstMiddleSkillValue: number;
  secondMiddleSkillValue: number;
  thirdMiddleSkillValue: number;

  firstRightSkillId: number;
  secondRightSkillId: number;
  thirdRightSkillId: number;
  firstRightSkillValue: number;
  secondRightSkillValue: number;
  thirdRightSkillValue: number;
}

export interface Stat extends EntityDescriptionBase {}
export interface StatsList extends EntityBase {
  intellectId: number;
  intellectValue: number;

  reactionId: number;
  reactionValue: number;

  dexterityId: number;
  dexterityValue: number;

  constitutionId: number;
  constitutionValue: number;

  speedId: number;
  speedValue: number;

  empathyId: number;
  empathyValue: number;

  craftsmanshipId: number;
  craftsmanshipValue: number;

  willpowerId: number;
  willpowerValue: number;

  luckId: number;
  luckValue: number;

  energyId: number;
  energyValue: number;

  resilienceId: number;
  resilienceValue: number;

  runningId: number;
  runningValue: number;

  jumpingId: number;
  jumpingValue: number;

  healthPointsId: number;
  healthPointsValue: number;

  enduranceId: number;
  enduranceValue: number;

  weightId: number;
  weightValue: number;

  restId: number;
  restValue: number;

  handStrikeId: number;
  handStrikeValue: number;

  kickId: number;
  kickValue: number;
}