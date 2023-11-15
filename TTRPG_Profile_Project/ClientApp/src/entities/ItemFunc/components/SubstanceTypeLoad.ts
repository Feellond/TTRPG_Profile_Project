import { SelectItem } from "primereact/selectitem";
import { SubstanceType } from "shared/enums/ItemEnums";

interface ItemTypeLoadParams {
    setItems: React.Dispatch<React.SetStateAction<SelectItem[]>>;
  }
  
  const SubstanceTypeLoad = ({ setItems }: ItemTypeLoadParams) => {
    const itemTypeKeys = Object.keys(SubstanceType).filter((v) => isNaN(Number(v)));
    const ITOptions = itemTypeKeys.map((key) => ({
      label: key,
      value: SubstanceType[key],
    }));
    setItems(ITOptions);
    console.log(ITOptions);
  };
  
  export {SubstanceTypeLoad}