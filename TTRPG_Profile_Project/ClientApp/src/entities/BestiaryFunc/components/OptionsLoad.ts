import { OptionsParamsLoad } from "entities/Interface";
import { Complexity } from "shared/enums/CreatureEnums";
import bestiaryService from "shared/services/bestiary.service";

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

export const RaceLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await bestiaryService.getRaces()
    if (responce && responce.data) {

      const options = responce.data.races.map((data, index) => ({
        label: data.name,
        value: data,
      }));

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
