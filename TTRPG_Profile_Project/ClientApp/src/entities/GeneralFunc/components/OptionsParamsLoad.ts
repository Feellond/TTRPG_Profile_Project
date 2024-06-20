import { OptionsParamsLoad } from "entities/Interface";
import {
  ItemStealthType,
  SubstanceType,
  WhereToFindEnum,
} from "shared/enums/ItemEnums";
import generalService from "shared/services/general.service";

const SubstanceOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const availabilityTypeKeys = Object.keys(SubstanceType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: key,
    value: SubstanceType[key],
  }));
  setItems(ITOptions);
};

const WhereToFindOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const availabilityTypeKeys = Object.keys(WhereToFindEnum).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: key,
    value: WhereToFindEnum[key],
  }));
  setItems(ITOptions);
};

const StealthOptionsLoad = ({ setItems }: OptionsParamsLoad) => {
  const availabilityTypeKeys = Object.keys(ItemStealthType).filter((v) =>
    isNaN(Number(v))
  );
  const ITOptions = availabilityTypeKeys.map((key) => ({
    label: key,
    value: ItemStealthType[key],
  }));
  setItems(ITOptions);
};

const SourceOptionsLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await generalService.sourceListLoad();
    if (responce && responce.data) {
      // console.log("Source responce data:");
      // console.log(responce.data);

      const options = responce.data.map((data, index) => ({
        label: data.name,
        value: data,
      }));

      setItems(options);
    }
  } catch (error) {
    console.error("Error fetching skills:", error);
  }
};

const EffectOptionsLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await generalService.effectListLoad();
    if (responce && responce.data) {
      // console.log("Source responce data:");
      //console.log("Effects:", responce.data);

      const options = responce.data.effects.map((data, index) => ({
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
  WhereToFindOptionsLoad,
  StealthOptionsLoad,
  SourceOptionsLoad,
  EffectOptionsLoad,
};
