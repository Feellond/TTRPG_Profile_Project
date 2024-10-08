import {
  IAbilitiy,
  IAttack,
  IAttackEffectList,
  IClass,
  ICreature,
  IRace,
  IReward,
  ISkill,
  ISkillsList,
  ISkillsTree,
  IStat,
  IStatsList,
} from "./BestiaryDTO";

export const emptyAbilitiy: IAbilitiy = {
  id: 0,
  name: null,
  description: null,
  source: null,
  creature: null,
  race: null,
  type: null,
  imageFileName: "",
};

export const emptyAttack: IAttack = {
  id: 0,
  name: null,
  description: null,
  source: null,
  creature: null,
  baseAttack: 0,
  attackType: 0,
  damage: "",
  reliability: 0,
  distance: 0,
  attackSpeed: 0,
  attackEffectList: [],
  imageFileName: "",
};

export const emptyAttackEffectList: IAttackEffectList = {
  id: 0,
  //attack: null,
  effect: null,
  damage: "",
  chancePercent: 0,
  isDealDamage: false,
};

export const emptyClass: IClass = {
  id: 0,
  name: null,
  description: null,
  source: null,
  energy: 0,
  defaultMagicAbilities: "",
  skillsTree: null,
  imageFileName: "",
};

export const emptyCreature: ICreature = {
  id: 0,
  name: null,
  description: "",
  source: null,
  race: null,
  additionalInformation: "",
  educationSkill: 0,
  superstitionsInformation: "",
  monsterLoreSkill: 0,
  monsterLoreInformation: "",
  complexity: 0,
  moneyReward: 0,
  armor: 0,
  regeneration: 0,
  statsList: null,
  skillsList: null,
  evasionBase: 0,
  athleticsBase: 0,
  blockBase: 0,
  spellResistBase: 0,
  height: 0,
  weight: 0,
  habitatPlace: "",
  // immunities: "",
  // resistances: "",
  // vulnerabilities: "",
  intellect: "",
  groupSize: "",
  creatureEffects: [],
  creatureAttacks: [],
  creatureAbilitys: [],
  creatureReward: [],
  imageFileName: "",
  mutagen: null,
  trophy: null,
};

export const emptyReward: IReward = {
  id: 0,
  name: null,
  description: null,
  source: null,
  itemBase: null,
  amount: "",
  imageFileName: "",
};

export const emptyRace: IRace = {
  id: 0,
  name: null,
  description: null,
  source: null,
  imageFileName: "",
};

export const emptySkill: ISkill = {
  id: 0,
  name: null,
  description: null,
  source: null,
  isDifficult: false,
  isClassSkill: false,
  stat: null,
  imageFileName: "",
};

export const emptySkillsList: ISkillsList = {
  attentionId: 0,
  attentionValue: 0,
  survivalId: 0,
  survivalValue: 0,
  deductionId: 0,
  deductionValue: 0,
  monsterologyId: 0,
  monsterologyValue: 0,
  educationId: 0,
  educationValue: 0,
  cityOrientationId: 0,
  cityOrientationValue: 0,
  knowledgeTransferId: 0,
  knowledgeTransferValue: 0,
  tacticsId: 0,
  tacticsValue: 0,
  tradingId: 0,
  tradingValue: 0,
  etiquetteId: 0,
  etiquetteValue: 0,
  languageDwarfId: 0,
  languageDwarfValue: 0,
  languageGeneralId: 0,
  languageGeneralValue: 0,
  languageHighId: 0,
  languageHighValue: 0,
  strengthId: 0,
  strengthValue: 0,
  enduranceId: 0,
  enduranceValue: 0,
  meleeCombatId: 0,
  meleeCombatValue: 0,
  wrestlingId: 0,
  wrestlingValue: 0,
  ridingId: 0,
  ridingValue: 0,
  poleWeaponMasteryId: 0,
  poleWeaponMasteryValue: 0,
  lightBladeMasteryId: 0,
  lightBladeMasteryValue: 0,
  swordsmanshipId: 0,
  swordsmanshipValue: 0,
  seamanshipId: 0,
  seamanshipValue: 0,
  evasionId: 0,
  evasionValue: 0,
  athleticsId: 0,
  athleticsValue: 0,
  manualDexterityId: 0,
  manualDexterityValue: 0,
  stealthId: 0,
  stealthValue: 0,
  crossbowMasteryId: 0,
  crossbowMasteryValue: 0,
  archeryId: 0,
  archeryValue: 0,
  gamblingId: 0,
  gamblingValue: 0,
  appearanceId: 0,
  appearanceValue: 0,
  publicSpeakingId: 0,
  publicSpeakingValue: 0,
  artistryId: 0,
  artistryValue: 0,
  leadershipId: 0,
  leadershipValue: 0,
  deceptionId: 0,
  deceptionValue: 0,
  understandingPeopleId: 0,
  understandingPeopleValue: 0,
  seductionId: 0,
  seductionValue: 0,
  persuasionResistanceId: 0,
  persuasionResistanceValue: 0,
  charismaId: 0,
  charismaValue: 0,
  alchemyId: 0,
  alchemyValue: 0,
  lockpickingId: 0,
  lockpickingValue: 0,
  trapKnowledgeId: 0,
  trapKnowledgeValue: 0,
  forgeryId: 0,
  forgeryValue: 0,
  camouflageId: 0,
  camouflageValue: 0,
  firstAidId: 0,
  firstAidValue: 0,
  manufacturingId: 0,
  manufacturingValue: 0,
  intimidationId: 0,
  intimidationValue: 0,
  corruptionId: 0,
  corruptionValue: 0,
  ritualsId: 0,
  ritualsValue: 0,
  magicResistanceId: 0,
  magicResistanceValue: 0,
  persuasionId: 0,
  persuasionValue: 0,
  spellcastingId: 0,
  spellcastingValue: 0,
  courageId: 0,
  courageValue: 0,
  classSkill: 0,
  classSkillValue: 0,
};

export const emptySkillsTree: ISkillsTree = {
  id: 0,
  class: null,

  leftBranchName: "",
  middleBranchName: "",
  rightBranchName: "",

  mainSkill: null,
  mainSkillId: 0,
  mainSkillValue: 0,
  firstLeftSkill: null,
  firstLeftSkillId: 0,
  firstLeftSkillValue: 0,
  secondLeftSkill: null,
  secondLeftSkillId: 0,
  secondLeftSkillValue: 0,
  thirdLeftSkill: null,
  thirdLeftSkillId: 0,
  thirdLeftSkillValue: 0,
  firstMiddleSkill: null,
  firstMiddleSkillId: 0,
  firstMiddleSkillValue: 0,
  secondMiddleSkill: null,
  secondMiddleSkillId: 0,
  secondMiddleSkillValue: 0,
  thirdMiddleSkill: null,
  thirdMiddleSkillId: 0,
  thirdMiddleSkillValue: 0,
  firstRightSkill: null,
  firstRightSkillId: 0,
  firstRightSkillValue: 0,
  secondRightSkill: null,
  secondRightSkillId: 0,
  secondRightSkillValue: 0,
  thirdRightSkill: null,
  thirdRightSkillId: 0,
  thirdRightSkillValue: 0,
};

export const emptyStat: IStat = {
  id: 0,
  name: null,
  description: null,
  source: null,
  imageFileName: "",
};

export const emptyStatsList: IStatsList = {
  id: 0,
  intellectId: 0,
  intellectValue: 0,
  reactionId: 0,
  reactionValue: 0,
  dexterityId: 0,
  dexterityValue: 0,
  constitutionId: 0,
  constitutionValue: 0,
  speedId: 0,
  speedValue: 0,
  empathyId: 0,
  empathyValue: 0,
  craftsmanshipId: 0,
  craftsmanshipValue: 0,
  willpowerId: 0,
  willpowerValue: 0,
  luckId: 0,
  luckValue: 0,
  energyId: 0,
  energyValue: 0,
  resilienceId: 0,
  resilienceValue: 0,
  runningId: 0,
  runningValue: 0,
  jumpingId: 0,
  jumpingValue: 0,
  healthPointsId: 0,
  healthPointsValue: 0,
  enduranceId: 0,
  enduranceValue: 0,
  weightId: 0,
  weightValue: 0,
  restId: 0,
  restValue: 0,
  handStrikeId: 0,
  handStrikeValue: 0,
  kickId: 0,
  kickValue: 0,
};
