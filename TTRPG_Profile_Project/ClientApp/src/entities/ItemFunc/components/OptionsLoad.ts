import { OptionsParamsLoad } from "entities/Interface";
import { AttackType } from "shared/enums/CreatureEnums";
import {
  ArmorEquipmentType,
  ArmorType,
  ItemAvailabilityType,
  ItemOriginType,
  WeaponEquipmentType,
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
    label: SubstanceTypeKeyToString(key),
    value: SubstanceType[key],
  }));
  setItems(ITOptions);
};

const SubstanceTypeKeyToString = (enumKey: string) => {
  switch(enumKey) {
    case "Caelum":
      return "Аэр";
    case "Hydragenium":
      return "Гидраген";
    case "Quebrith":
      return "Квебрит";
    case "Vermilion":
      return "Киноварь";
    case "Vitriol":
      return "Купорос";
    case "Rebis":
      return "Рэбис";
    case "Sol":
      return "Солнце";
    case "Fulgur":
      return "Фульгор";
    case "Aether":
      return "Эфир";
    default:
      return enumKey;
  }
}

const AvailabilityTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const availabilityTypeKeys = Object.keys(ItemAvailabilityType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: AvailabilityTypeToString(key),
    value: ItemAvailabilityType[key],
  }));
  setItems(ITOptions);
};

const AvailabilityTypeToString = (enumKey: string) => {
  switch(enumKey) {
    case "None":
      return "Без сложности";
    case "Everywhere":
      return "Повсеместное";
    case "Common":
      return "Обычное";
    case "Poor":
      return "Редкое";
    case "Rare":
      return "Уникальное";
    default:
      return enumKey;
  }
}

const ItemEntityTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ItemEntityType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: EntityTypeKeyToRus(key),
    value: ItemEntityType[key],
  }));
  setItems(ITOptions);
};

const EntityTypeKeyToRus = (enumKey: string) => {
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
    case "ComponentRem":
      return "Компонент ремесла"
    case "ComponentAlc":
      return "Компонент алхимии"
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
    label: ItemOriginTypeToString(key),
    value: ItemOriginType[key],
  }));
  setItems(ITOptions);
};

const ItemOriginTypeToString = (enumKey: string) => {
  switch (enumKey) {
    case "Human":
      return "Люди";
    case "ElderFolk":
      return "Старший народ";
    case "WitcherGear":
      return "Ведьмаки";
    case "Relic":
      return "Реликт";
    default:
      return enumKey;
  }
}

const ArmorTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ArmorType).filter((v) => isNaN(Number(v)));
  const ITOptions = itemTypeKeys.map((key) => ({
    label: ArmorTypeToString(key),
    value: ArmorType[key],
  }));
  setItems(ITOptions);
};

const ArmorTypeToString = (enumKey: string) => {
  switch (enumKey) {
    case "Light":
      return "Легкий";
    case "Medium":
      return "Средний";
    case "Heavy":
      return "Тяжелый";
    default:
      return enumKey;
  }
}

const ArmorEquipmentTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(ArmorEquipmentType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: ArmorEquipmentTypeToString(key),
    value: ArmorEquipmentType[key],
  }));
  setItems(ITOptions);
};

const ArmorEquipmentTypeToString = (enumKey: string) => {
  switch (enumKey) {
    case "None":
      return "Нет типа";
    case "Head":
      return "Голова";
    case "Body":
      return "Тело";
    case "Legs":
      return "Ноги";
    case "Shields":
      return "Щиты";
    case "Witcher":
      return "Ведьмачье";
    default:
      return enumKey;
  }
}

const WhereToFindTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(WhereToFindEnum).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: WhereToFindEnum[key],
  }));
  setItems(ITOptions);
};

const WeaponAttackTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(AttackType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: WeaponAttackTypeToString(key),
    value: AttackType[key],
  }));
  setItems(ITOptions);
};

const WeaponAttackTypeToString = (enumKey: string) => {
  switch (enumKey) {
    case "Piercing": 
        return "Колющий";
      case "Slashing":
        return "Рубящий";
      case "Bludgeoning":
        return "Дробящий";
      case "PiercingAndSlashing":
        return "Колющий/Рубящий";
      case "SlashingAndBludgeoning":
        return "Рубящий/Дробящий";
      case "PiercingAndBludeoning":
        return "Колющий/Дробящий";
      case "PiercingAndSlashingAndBludeoning":
        return "Колющий/Рубящий/Дробящий";
    default:
      return enumKey;
  }
}

const WeaponEquipmentTypeLoad = ({ setItems }: OptionsParamsLoad) => {
  const itemTypeKeys = Object.keys(WeaponEquipmentType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = itemTypeKeys.map((key) => ({
    label: WeaponEquipmentTypeToString(WeaponEquipmentType[key]),
    value: WeaponEquipmentType[key],
  }));
  setItems(ITOptions);
};

const WeaponEquipmentTypeToString = (key: number) => {
  switch (key) {
    case 1:
      return "Мечи";
    case 2:
      return "Кинжалы";
    case 3:
      return "Топоры";
    case 4:
      return "Дробящее";
    case 5:
      return "Копья";
    case 6:
      return "Посохи";
    case 7:
      return "Метательное";
    case 8:
      return "Луки";
    case 9:
      return "Арбалеты";
    case 10:
      return "Боеприпас";
    case 11:
      return "Без типа";
    default:
      return "";
  }
};

const ComponentsTypeLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await itemService.getEntitys({itemType: 9})
    if (responce && responce.data) {

      const options = responce.data.entitys.map((data, index) => ({
        label: data.name,
        value: data,
      }));

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
  WeaponAttackTypeLoad,

  SubstanceTypeKeyToString,
  AvailabilityTypeToString,
  ItemOriginTypeToString,
  ArmorTypeToString,
  ArmorEquipmentTypeToString,
  WeaponAttackTypeToString,
  WeaponEquipmentTypeLoad,
};
