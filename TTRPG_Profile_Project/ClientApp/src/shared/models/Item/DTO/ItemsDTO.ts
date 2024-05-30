import { ISkill } from "shared/models";
import { Effect } from "shared/models/Additional";
import { EntityBase, EntityItemBase } from "shared/models/Base";

export interface ItemShortDTO extends EntityItemBase {
  itemBaseEffectList: ItemBaseEffect[] | null;
  //creatureRewardList: ICreatureReward[] | null;
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
  skill: ISkill | null;
  //tool

  //item
  type: number | null;

  //formula
  complexity: number | null;
  timeSpend: number | null;
  additionalPayment: number | null;
  formulaSubstanceList: FormulaComponentList[] | null;

  //blueprint
  //complexity: number;
  //timeSpend: number | null;
  //additionalPayment: number | null;
  blueprintComponentList: BlueprintComponentList[] | null;

  //component
  whereToFind: string | null;
  amount: string | null;
  //complexity: number;
  isAlchemical: boolean | null;
  substanceType: number | null;
  //formulaComponentList: FormulaComponentList[] | null;
  //blueprintComponentList: BlueprintComponentList[] | null;

  //armor
  //reliability: number | null;
  //amountOfEnhancements: number | null;
  stiffness: number | null;
  equipmentType: number | null;
  itemOriginType: number | null;

  //alchemicalItem
}

export interface ItemBaseEffect extends EntityBase {
  //itemBase: ItemShortDTO;
  effect: Effect;
  damage: string | null;
  chancePercent: number | null;
  isDealDamage: boolean | null;
}

export interface FormulaComponentList extends EntityBase {
  //formula: Formula;
  id: number | null;
  substanceType: number;
  amount: number;
}

export interface BlueprintComponentList extends EntityBase {
  id: number | null;
  component: Component;
  amount: number;
}

///////////////////////////////////////

export interface Component extends EntityItemBase {
  whereToFind: string;
  amount: number;
  complexity: number;
  isAlchemical: boolean;
  substanceType: number;
}

export interface Formula extends EntityItemBase {
  complexity: number;
  timeSpend: number;
  additionalPayment: number;
  formulaComponentList: FormulaComponentList[];
}

export interface Blueprint extends EntityItemBase {
  complexity: number;
  timeSpend: number;
  additionalPayment: number;
  blueprintComponentList: BlueprintComponentList[];
}