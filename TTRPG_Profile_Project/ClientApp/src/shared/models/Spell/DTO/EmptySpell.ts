import { ISpell } from "./SpellDTO";

const emptySpell: ISpell = {
    id: 0,
    name: null,
    description: null,
    source: null,
    enduranceCost: 0,
    distance: 0,
    duration: "",
    spellSkillProtectionList: null,
    isConcentration: false,
    concentrationEnduranceCost: 0,
    spellLevel: 0,
    spellComponentList: null,
    checkDC: 0,
    preparationTime: 0,
    dangerInfo: "",
    withdrawalCondition: "",
    spellType: 0,
    spellTypeDescription: "",
    sourceType: 0,
    sourceTypeDescription: "",
    isPriestSpell: false,
    isDruidSpell: false
};

export {emptySpell}