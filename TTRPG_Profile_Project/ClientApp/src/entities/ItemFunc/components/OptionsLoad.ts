import { OptionsParamsLoad } from "entities/Interface";
import {
  ArmorEquipmentType,
  ArmorType,
  ItemAvailabilityType,
  ItemOriginType,
  WhereToFindEnum,
} from "shared/enums/ItemEnums";
import { ItemEntityType } from "shared/enums/ItemEnums";
import { SubstanceType } from "shared/enums/ItemEnums";
import itemService from "shared/services/item.service";

const SubstanceTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(SubstanceType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: SubstanceType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const AvailabilityTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const availabilityTypeKeys = Object.keys(ItemAvailabilityType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: key,
    value: ItemAvailabilityType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const ItemEntityTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ItemEntityType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: EntityTypeKeyToRus(key),
    value: ItemEntityType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const EntityTypeKeyToRus = (enumKey) => {
  switch(enumKey){
    case "Tool":
      return "Инструменты";
    case "AlchemicalItem":
      return "Алхимический предмет";
    case "Armor":
      return "Броня";
    case "Weapon":
      return "Оружие";
    case "Formula":
      return "Формула";
    case "Blueprint":
      return "Чертеж";
    case "Component":
      return "Компонент";
    case "Item":
      return "Обычный предмет";
    default:
      return enumKey;
  }
}

const ItemOriginTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ItemOriginType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: ItemOriginType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const ArmorTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ArmorType).filter((v) => isNaN(Number(v)));
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: ArmorType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const ArmorEquipmentTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ArmorEquipmentType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: ArmorEquipmentType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const WhereToFindTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(WhereToFindEnum).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: WhereToFindEnum[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const ComponentsTypeLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await itemService.getEntitys({itemType: 8})
    if (responce && responce.data) {
        console.log("Components responce data:");
        console.log(responce.data);

      const options = responce.data.map((data, index) => ({
        label: data.name,
        value: data,
      }));

      console.log("Components options:");
      console.log(options);

      setItems(options);
    }
  } catch (error) {
    console.error("Error fetching skills:", error);
  }
};

export {
  AvailabilityTypeLoad,
  ItemEntityTypeLoad,
  SubstanceTypeLoad,
  ItemOriginTypeLoad,
  ArmorTypeLoad,
  ArmorEquipmentTypeLoad,
  WhereToFindTypeLoad,
  ComponentsTypeLoad,
};
