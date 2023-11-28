import { SelectItem } from "primereact/selectitem";

interface ItemEntityTypeLoadParams {
  setItems: React.Dispatch<React.SetStateAction<SelectItem[]>>;
}

const ItemEntityTypeLoad = ({ setItems }: ItemEntityTypeLoadParams) => {
  const itemTypeKeys = Object.keys(ItemEntityTypeLoad).filter((v) => isNaN(Number(v)));
  const ITOptions = itemTypeKeys.map((key) => ({
    label: key,
    value: ItemEntityTypeLoad[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

export {ItemEntityTypeLoad}