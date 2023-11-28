import { SubstanceType } from 'shared/enums/ItemEnums';
import { Effect } from "shared/models/Additional";
import { EntityBase, EntityItemBase, Source } from "shared/models/Base";
import { CreatureReward, Skill } from "shared/models/Creature";

export interface ItemShortDTO extends EntityItemBase {
  itemBaseEffectLists: ItemBaseEffect[] | null;
  creatureRewardLists: CreatureReward[] | null;
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
  skill: Skill | null;
  //tool

  //item
  type: number | null;

  //formula
  complexity: number | null;
  timeSpend: number | null;
  additionalPayment: number | null;
  formulaSubstanceLists: FormulaComponentList[] | null;

  //blueprint
  //complexity: number;
  //timeSpend: number | null;
  //additionalPayment: number | null;
  blueprintComponentLists: BlueprintComponentList[] | null;

  //component
  whereToFind: string | null;
  amount: number | null;
  //complexity: number;
  isAlchemical: boolean | null;
  substanceType: number | null;
  //formulaComponentLists: FormulaComponentList[] | null;
  //blueprintComponentLists: BlueprintComponentList[] | null;

  //armor
  //reliability: number | null;
  //amountOfEnhancements: number | null;
  stiffness: number | null;

  //alchemicalItem
}

export interface ItemBaseEffect extends EntityBase {
  itemBase: ItemShortDTO;
  effect: Effect;
  damage: string | null;
  chancePercent: number | null;
  isDealDamage: boolean | null;
}

export interface FormulaComponentList extends EntityBase {
  //formula: Formula;
  substanceType: number;
  amount: number;
}

export interface BlueprintComponentList extends EntityBase {
  //blueprint: Blueprint;
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
  formulaComponentLists: FormulaComponentList[];
}

export interface Blueprint extends EntityItemBase {
  complexity: number;
  timeSpend: number;
  additionalPayment: number;
  blueprintComponentLists: BlueprintComponentList[];
}