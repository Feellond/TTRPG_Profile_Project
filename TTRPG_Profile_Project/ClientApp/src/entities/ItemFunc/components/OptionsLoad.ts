import { OptionsParamsLoad } from "entities/Interface";
import {
  ArmorEquipmentType,
  ArmorType,
  ItemAvailabilityType,
  ItemOriginType,
} from "shared/enums/ItemEnums";
import { ItemEntityType } from "shared/enums/ItemEnums";
import { SubstanceType } from "shared/enums/ItemEnums";

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
    label: key,
    value: ItemEntityType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

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

export {
  AvailabilityTypeLoad,
  ItemEntityTypeLoad,
  SubstanceTypeLoad,
  ItemOriginTypeLoad,
  ArmorTypeLoad,
  ArmorEquipmentTypeLoad,
};
