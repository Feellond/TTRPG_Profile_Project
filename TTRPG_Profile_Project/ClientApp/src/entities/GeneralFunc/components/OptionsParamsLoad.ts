import { OptionsParamsLoad } from "entities/Interface";
import { ItemStealthType } from "shared/enums/ItemEnums";
import generalService from "shared/services/general.service";

const StealthOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const availabilityTypeKeys = Object.keys(ItemStealthType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: key,
    value: ItemStealthType[key],
  }));
  setItems(ITOptions);
  console.log(ITOptions);
};

const SourceOptionsLoad = async ({ setItems }: OptionsParamsLoad) => {
    try {
        let responce = await generalService.sourceListLoad();
        if (responce && responce.data) {
            console.log("Source responce data:");
            console.log(responce.data);
    
          const options = responce.data.map((data, index) => ({
            label: data.name,
            value: data,
          }));
    
          console.log("Source options:");
          console.log(options);
    
          setItems(options);
        }
      } catch (error) {
        console.error("Error fetching skills:", error);
      }
  };

  export {StealthOptionsLoad, SourceOptionsLoad}