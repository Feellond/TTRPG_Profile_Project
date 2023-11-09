export interface ItemShortDTO {
  id: number;
  name: string | null;
  description: string | null;
  availabilityType: number | null;
  weight: number | null;
  price: number | null;
  itemBaseEffectLists: ItemBaseEffect[] | null;
  creatureRewardLists: CreatureReward[] | null;
  sourceId: number;
  itemType: number;
}

export interface ItemDTO extends ItemShortDTO {
  //weapon
  accuracy: number | null;
  damage: string | null;
  reliability: number | null;
  grip: number | null;
  distance: number | null;
  stealthType: number | null;
  amountOfEnhancements: number | null;
  isAmmunition: boolean | null;
  skillId: number | null;

  //tool

  //item
  type: number | null;

  //formula
  complexity: number | null;
  timeSpend: number | null;
  additionalPayment: number | null;
  formulaComponentLists: FormulaComponentList[] | null;

  //blueprint
  //complexity: number;
  //timeSpend: number | null;
  //additionalPayment: number | null;
  blueprintComponentLists: BlueprintComponentList[] | null;

  //component
  whereToFind: string | null;
  amount: number;
  //complexity: number;
  isAlchemical: boolean;
  substanceType: number;
  //formulaComponentLists: FormulaComponentList[] | null;
  //blueprintComponentLists: BlueprintComponentList[] | null;

  //armor
  //reliability: number | null;
  //amountOfEnhancements: number | null;
  stiffness: number | null;

  //alchemicalItem
}

export interface ItemBaseEffect {
  id: number;
  itemBaseId: number;
  effectId: number;
  damage: string | null;
  chancePercent: number | null;
  isDealDamage: boolean | null;
}

export interface CreatureReward {
  id: number;
  itemBaseId: number;
  creatureId: number;
  amount: string | null;
}

export interface FormulaComponentList {
  id: number;
  formulaId: number | null;
  componentId: number | null;
  amount: number;
}

export interface BlueprintComponentList {
  id: number;
  blueprintId: number | null;
  componentId: number | null;
  amount: number;
}