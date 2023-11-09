import { SelectItem } from "primereact/selectitem";
import { ItemType } from "shared/enums/ItemEnums";

interface ItemTypeLoadParams {
  setItems: React.Dispatch<React.SetStateAction<SelectItem[]>>;
}

const ItemTypeLoad = ({ setItems }: ItemTypeLoadParams) => {
  const itemTypeKeys = Object.keys(ItemType).filter((v) => isNaN(Number(v)));
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: ItemType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

export {ItemTypeLoad}