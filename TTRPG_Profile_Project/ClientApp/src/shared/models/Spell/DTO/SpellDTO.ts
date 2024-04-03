import { Component } from "shared/models";
import { Effect } from "shared/models/Additional";
import { EntityDescriptionBase } from "shared/models/Base";

export interface ISpell extends EntityDescriptionBase {
    enduranceCost: number;
    distance: number;
    duration: number;
    spellSkillProtectionList: ISpellSkillProtectionList[] | null;
    isConcentration: boolean;
    concentrationEnduranceCost: number;
    spellLevel: number;
    spellComponentList: ISpellComponentList[] | null;
    checkDC: number;
    preparationTime: number;
    dangerInfo: string;
    withdrawalCondition: string;
    spellType: number;
    spellTypeDescription: string;
    sourceType: number;
    sourceTypeDescription: string;
    isPriestSpell: boolean;
    isDruidSpell: boolean;
}

export interface ISpellSkillProtectionList {
    id: number | null;
    effect: Effect;
}

export interface ISpellComponentList {
    id: number | null;
    component: Component;
    amount: number;
}