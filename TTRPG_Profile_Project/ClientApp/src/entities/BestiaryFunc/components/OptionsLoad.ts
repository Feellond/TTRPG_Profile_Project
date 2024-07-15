import { OptionsParamsLoad } from "entities/Interface";
import { AbilityType, AttackType, Complexity } from "shared/enums/CreatureEnums";
import bestiaryService from "shared/services/bestiary.service";
import { AttackTypeToString } from "..";

export const ComplexityLoad = ({ setItems }: OptionsParamsLoad) => {
  const complexityKeys = Object.keys(Complexity).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = complexityKeys.map((key) => ({
    label: ComplexityKeyToRus(key) + String(" [" + Complexity[key] + "]"),
    value: Complexity[key],
  }));
  setItems(ITOptions);
};

export const AbilityTypeOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const abilityTypeKeys = Object.keys(AbilityType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = abilityTypeKeys.map((key) => ({
    label: AbilityTypeToString(AbilityType[key]),
    value: AbilityType[key],
  }));
  setItems(ITOptions);
};

export const AbilityTypeToString = (type: number) => {
  switch (type) {
    case 1: 
      return "Полное действие";
    case 2:
      return "Действие";
    case 3:
      return "Пассивное";
    case 4:
      return "Специальное";
  }
}

export const AttackTypeOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const attackTypeKeys = Object.keys(AttackType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = attackTypeKeys.map((key) => ({
    label: AttackTypeToString(AttackType[key]),
    value: AttackType[key],
  }));
  setItems(ITOptions);
};

export const RaceLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await bestiaryService.getRaces({params: {}})
    if (responce && responce.data) {

      const options = responce.data.entitys.map((data, index) => ({
        label: data.name,
        value: data,
      }));

      console.log("race options:", options);
      setItems(options);
    }
  } catch (error) {
    console.error("Error fetching skills:", error);
  }
};

const ComplexityKeyToRus = (enumValue) => {
  switch (enumValue) {
    case "EasySimple":
      return "Простые обычные";
    case "EasyComplex":
      return "Простые незаурядные";
    case "EasyDifficult":
      return "Простые трудные";
    case "MediumSimple":
      return "Средние обычные";
    case "MediumComplex":
      return "Средние незаурядные";
    case "MediumDifficult":
      return "Средние трудные";
    case "HardSimple":
      return "Сложные обычные";
    case "HardComplex":
      return "Сложные незаурядные";
    case "HardDifficult":
      return "Сложные трудные";
    case "Exceptional":
      return "Уникальные";
    default:
      return enumValue;
  }
};
