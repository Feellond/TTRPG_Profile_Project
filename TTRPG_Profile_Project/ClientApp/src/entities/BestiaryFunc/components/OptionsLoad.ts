import { OptionsParamsLoad } from "entities/Interface";
import { Complexity } from "shared/enums/CreatureEnums";

export const ComplexityLoad = ({ setItems }: OptionsParamsLoad) => {
  const complexityKeys = Object.keys(Complexity).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = complexityKeys.map((key) => ({
    label: ComplexityKeyToRus(key) + String(" [" + Complexity[key] + "]"),
    value: Complexity[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
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
