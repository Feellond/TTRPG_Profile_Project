import { SelectItem } from "primereact/selectitem";
import { ItemAvailabilityType } from "shared/enums/ItemEnums";


interface AvailabilityTypeParams {
  setItems: React.Dispatch<React.SetStateAction<SelectItem[]>>;
}

const AvailabilityTypeLoad = ({ setItems }: AvailabilityTypeParams) => {
  const availabilityTypeKeys = Object.keys(ItemAvailabilityType).filter((v) => isNaN(Number(v)));
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: key,
    value: ItemAvailabilityType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

export {AvailabilityTypeLoad}