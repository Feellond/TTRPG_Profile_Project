import { Component } from "shared/models";
import { Effect } from "shared/models/Additional";
import { EntityDescriptionBase } from "shared/models/Base";

export interface Spell extends EntityDescriptionBase {
    enduranceCost: number;
    distance: number;
    duration: number;
    spellSkillProtectionList: SpellSkillProtectionList[] | null;
    isConcentration: boolean;
    concentrationEnduranceCost: number;
    spellLevel: number;
    spellComponentList: SpellComponentList[] | null;
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

export interface SpellSkillProtectionList {
    id: number | null;
    effect: Effect;
}

export interface SpellComponentList {
    id: number | null;
    component: Component;
    amount: number;
}