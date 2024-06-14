import { drawSpellCategory, drawSpellLevel, drawSpellSourceType, drawSpellType } from "entities/DrawSpell";
import { OptionsParamsLoad } from "entities/Interface";
import { SpellCategory, SpellLevel, SpellSource, SpellType } from "shared/enums/SpellEnums";

export const SpellTypeOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const spellTypeKeys = Object.keys(SpellType).filter((v) => isNaN(Number(v)));
  const ITOptions = spellTypeKeys.map((key) => ({
    label: drawSpellType(SpellType[key]),
    value: SpellType[key],
  }));
  setItems(ITOptions);
};

export const SpellLevelOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
    const spellLevelKeys = Object.keys(SpellLevel).filter((v) => isNaN(Number(v)));
    const ITOptions = spellLevelKeys.map((key) => ({
      label: drawSpellLevel(SpellLevel[key]),
      value: SpellLevel[key],
    }));
    setItems(ITOptions);
  };

  export const SpellSourceOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
    const spellSourceKeys = Object.keys(SpellSource).filter((v) => isNaN(Number(v)));
    const ITOptions = spellSourceKeys.map((key) => ({
      label: drawSpellSourceType(SpellSource[key]),
      value: SpellSource[key],
    }));
    setItems(ITOptions);
  };

  export const SpellCategotyOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
    const spellCategoryKeys = Object.keys(SpellCategory).filter((v) => isNaN(Number(v)));
    const ITOptions = spellCategoryKeys.map((key) => ({
      label: drawSpellCategory(SpellCategory[key]),
      value: SpellCategory[key],
    }));
    setItems(ITOptions);
  };