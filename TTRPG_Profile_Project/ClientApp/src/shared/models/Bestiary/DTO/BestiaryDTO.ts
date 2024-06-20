import { Effect } from "shared/models/Additional";
import { EntityBase, EntityDescriptionBase } from "shared/models/Base";
import { ItemDTO, ItemShortDTO } from "shared/models/Item/DTO/ItemsDTO";

export interface IAbilitiy extends EntityDescriptionBase {
  creature: ICreature | null;
  race: IRace | null;
  type: number | null;
}

export interface IAttack extends EntityDescriptionBase {
  creature: ICreature | null;
  baseAttack: number;
  attackType: number;
  damage: string;
  reliability: number;
  distance: number;
  attackSpeed: number;
  attackEffectList: IAttackEffectList[];
}

export interface IAttackEffectList {
  id: number;
  //attack?: IAttack | null;
  effect?: Effect | null;
  damage: string;
  chancePercent: number;
  isDealDamage: boolean;
}

export interface IClass extends EntityDescriptionBase {
  energy: number;
  defaultMagicAbilities: string;
  skillsTree: ISkillsTree;
}

export interface ICreature extends EntityDescriptionBase {
  race: IRace;
  additionalInformation: string;
  educationSkill: number;
  superstitionsInformation: string;
  monsterLoreSkill: number;
  monsterLoreInformation: string;
  complexity: number;
  moneyReward: number;
  armor: number;
  regeneration: number;
  // resistances: string;
  // immunities: string;
  // vulnerabilities: string;
  statsList: IStatsList | null;
  skillsList: ISkillsList | null;
  evasionBase: number;
  athleticsBase: number;
  blockBase: number;
  spellResistBase: number;
  height: number;
  weight: number;
  habitatPlace: string;
  intellect: string;
  groupSize: string;
  creatureEffects: ICreatureEffect[] | null;
  creatureAttacks: ICreatureAttack[] | null;
  creatureAbilitys: ICreatureAbilitys[];
  creatureReward: ICreatureReward[] | null;
  imageFileName: string | null;
  //Spells: Spell[];
  mutagen: IMutagen | null;
  trophy: ITrophy | null;
}

export interface ICreatureReward {
  id: number | null;
  //reward: IReward;
  itemBase: ItemShortDTO;
}

export interface ICreatureAttack {
  id: number | null;
  attack: IAttack;
}

export interface ICreatureAbilitys {
  id: number | null;
  ability: IAbilitiy;
}

export interface ICreatureEffect extends EntityBase {
  name: string | null;
  description: string | null;
  type: number;
}

export interface IMutagen extends EntityDescriptionBase {
  complexity: number;
  effect: string;
  mutation: string;
}

export interface IRace extends EntityDescriptionBase {}

export interface IReward extends EntityDescriptionBase {
  itemBase?: ItemDTO | null;
  amount: string;
}

export interface ISkill extends EntityDescriptionBase {
  isDifficult: boolean;
  isClassSkill: boolean;
  stat: IStat;
}

export interface ISkillsList {
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

  languageGeneralId: number;
  languageGeneralValue: number;

  languageHighId: number;
  languageHighValue: number;

  languageDwarfId: number;
  languageDwarfValue: number;

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

  persuasionId: number;
  persuasionValue: number;

  charismaId: number;
  charismaValue: number;

  alchemyId: number;
  alchemyValue: number;

  lockpickingId: number;
  lockpickingValue: number;

  trapKnowledgeId: number;
  trapKnowledgeValue: number;

  manufacturingId: number;
  manufacturingValue: number;

  camouflageId: number;
  camouflageValue: number;

  firstAidId: number;
  firstAidValue: number;

  forgeryId: number;
  forgeryValue: number;

  intimidationId: number;
  intimidationValue: number;

  corruptionId: number;
  corruptionValue: number;

  ritualsId: number;
  ritualsValue: number;

  magicResistanceId: number;
  magicResistanceValue: number;

  persuasionResistanceId: number;
  persuasionResistanceValue: number;

  spellcastingId: number;
  spellcastingValue: number;

  courageId: number;
  courageValue: number;

  classSkill?: number;
  classSkillValue: number;
}

export interface ISkillsTree extends EntityBase {
  class?: IClass;

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

export interface IStat extends EntityDescriptionBase {}
export interface IStatsList extends EntityBase {
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

export interface ITrophy extends EntityDescriptionBase {}
