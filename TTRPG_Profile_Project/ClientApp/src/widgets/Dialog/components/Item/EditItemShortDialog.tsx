import { Dialog } from "primereact/dialog";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import React, { useEffect, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { Button } from "primereact/button";
import { SelectItem } from "primereact/selectitem";
import { Dropdown, DropdownChangeEvent } from "primereact/dropdown";
import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import { ItemTypeSelect } from "./ItemTypeSelect";
import { ItemDTO } from "shared/models";
import { AvailabilityTypeLoad, ItemEntityTypeLoad } from "entities/ItemFunc";
import { SourceOptionsLoad } from "entities/GeneralFunc";

interface EditItemShortDialogProps {
  data: ItemDTO;
  visible: boolean;
  header: string;
  onHide: () => void;
  onSave: () => void;
}

const EditItemShortDialog = ({
  data,
  visible,
  header,
  onHide,
  onSave,
}: EditItemShortDialogProps) => {
  const [itemTypeOptions, setItemTypeOptions] = useState<SelectItem[]>([]);
  const [availabilityTypeOptions, setAvailabilityTypeOptions] = useState<
    SelectItem[]
  >([]);
  const [sourceOptions, setSourceOptions] = useState<SelectItem[]>([]);
  const [itemTypeSelectVisible, setItemTypeSelectVisible] =
    useState<boolean>(false);

  const [itemType, setItemType] = useState<number>(undefined);

  const SaveChanges = () => {
    let dialogData = getValues();
    console.log(dialogData);

    data.name = dialogData.name;
    data.description = dialogData.description;
    data.availabilityType = dialogData.availabilityType;
    data.weight = dialogData.weight;
    data.price = dialogData.price;
    data.itemBaseEffectList = dialogData.itemBaseEffectList;
    //data.creatureRewardList = dialogData.creatureRewardList;
    data.source = dialogData.source;
    data.itemType = dialogData.itemType;
    data.accuracy = dialogData.accuracy;
    data.damage = dialogData.damage;
    data.reliability = dialogData.reliability;
    data.grip = dialogData.grip;
    data.distance = dialogData.distance;
    data.stealthType = dialogData.stealthType;
    data.amountOfEnhancements = dialogData.amountOfEnhancements;
    data.isAmmunition = dialogData.isAmmunition;
    data.skill = dialogData.skill;
    data.type = dialogData.type;
    data.complexity = dialogData.complexity;
    data.timeSpend = dialogData.timeSpend;
    data.additionalPayment = dialogData.additionalPayment;
    data.formulaSubstanceList = dialogData.formulaSubstanceList;
    data.blueprintComponentList = dialogData.blueprintComponentList;
    data.whereToFind = dialogData.whereToFind;
    data.amount = dialogData.amount;
    data.isAlchemical = dialogData.isAlchemical;
    data.substanceType = dialogData.substanceType;
    data.stiffness = dialogData.stiffness;
    console.log(data);
    onSave();
  };

  const SetValues = () => {
    setValue("name", data.name);
    setValue("description", data.description);
    setValue("availabilityType", data.availabilityType);
    setValue("weight", data.weight);
    setValue("price", data.price);
    setValue("itemBaseEffectList", data.itemBaseEffectList);
    //setValue("creatureRewardList", data.creatureRewardList);
    setValue("source", data.source);
    setValue("itemType", data.itemType);
    setValue("accuracy", data.accuracy);
    setValue("damage", data.damage);
    setValue("reliability", data.reliability);
    setValue("grip", data.grip);
    setValue("distance", data.distance);
    setValue("stealthType", data.stealthType);
    setValue("amountOfEnhancements", data.amountOfEnhancements);
    setValue("isAmmunition", data.isAmmunition);
    setValue("skill", data.skill);
    setValue("type", data.type);
    setValue("complexity", data.complexity);
    setValue("timeSpend", data.timeSpend);
    setValue("additionalPayment", data.additionalPayment);
    setValue("formulaSubstanceList", data.formulaSubstanceList);
    setValue("blueprintComponentList", data.blueprintComponentList);
    setValue("whereToFind", data.whereToFind);
    setValue("amount", data.amount);
    setValue("isAlchemical", data.isAlchemical);
    setValue("substanceType", data.substanceType);
    setValue("stiffness", data.stiffness);
  };

  const {
    register,
    setValue,
    getValues,
    control,
    formState: { errors },
    handleSubmit,
  } = useForm();

  useEffect(() => {
    ItemEntityTypeLoad({ setItems: setItemTypeOptions });
    AvailabilityTypeLoad({ setItems: setAvailabilityTypeOptions });
    SourceOptionsLoad({ setItems: setSourceOptions });
  }, []);

  useEffect(() => {
    setItemType(data.itemType);
    if (getValues("itemType") !== undefined) setItemTypeSelectVisible(true);
    else setItemTypeSelectVisible(false);

    SetValues();
  }, [visible]);

  const footerContent = (
    <div>
      <Button
        label="Отмена"
        icon="pi pi-times"
        onClick={() => onHide()}
        className="p-button-text"
      />
      <Button
        label="Сохранить"
        icon="pi pi-check"
        onClick={() => SaveChanges()}
        autoFocus
      />
    </div>
  );

  return (
    <Dialog
      visible={visible}
      onHide={() => onHide()}
      modal={false}
      maximizable
      footer={footerContent}
      header={header}
      className="p-fluid w-auto w-8"
    >
      <form>
        <div className="grid align-items-center mt-4">
          <div className="field flex flex-column mr-2">
            <span className="p-float-label">
              <Controller
                name="name"
                control={control}
                render={({ field }) => (
                  <>
                    <InputText
                      id={field.name}
                      value={field.value}
                      onChange={(e) => {
                        field.onChange(e.target.value);
                      }}
                    />
                  </>
                )}
              />
              <label>Наименование</label>
            </span>
          </div>
          <div className="field flex flex-column mr-2">
            <span className="p-float-label">
              <Controller
                name="availabilityType"
                control={control}
                render={({ field }) => (
                  <>
                    <Dropdown
                      id={field.name}
                      value={field.value}
                      onChange={(e: DropdownChangeEvent) => {
                        field.onChange(e.value);
                      }}
                      optionLabel="label"
                      options={availabilityTypeOptions}
                    />
                  </>
                )}
              />
              <label>Доступность</label>
            </span>
          </div>
          <div className="field flex flex-column mr-2">
            <span className="p-float-label">
              <Controller
                name="weight"
                control={control}
                render={({ field }) => (
                  <>
                    <InputNumber
                      id={field.name}
                      value={field.value}
                      onValueChange={(e: InputNumberValueChangeEvent) => {
                        field.onChange(e.value);
                      }}
                      suffix=" кг"
                      minFractionDigits={0}
                      maxFractionDigits={5}
                      min={0}
                      max={99999999}
                    />
                  </>
                )}
              />
              <label>Вес</label>
            </span>
          </div>
          <div className="field flex flex-column mr-2">
            <span className="p-float-label">
              <Controller
                name="price"
                control={control}
                render={({ field }) => (
                  <>
                    <InputNumber
                      id={field.name}
                      value={field.value}
                      onValueChange={(e: InputNumberValueChangeEvent) => {
                        field.onChange(e.value);
                      }}
                      suffix=" крон"
                      minFractionDigits={0}
                      maxFractionDigits={3}
                      min={0}
                      max={99999999}
                    />
                  </>
                )}
              />
              <label>Цена</label>
            </span>
          </div>
          <div className="field flex flex-column" style={{width: "-webkit-fill-available"}}>
            <span className="p-float-label">
              <Controller
                name="description"
                control={control}
                render={({ field }) => (
                  <>
                    <InputTextarea
                      id={field.name}
                      value={field.value}
                      onChange={(e) => {
                        field.onChange(e.target.value);
                      }}
                      rows={5}
                      cols={60}
                    />
                  </>
                )}
              />
              <label>Описание</label>
            </span>
          </div>
          <div className="field flex flex-column mr-2">
            <span className="p-float-label">
              <Controller
                name="source"
                control={control}
                render={({ field }) => (
                  <>
                    <Dropdown
                      id={field.name}
                      value={field.value}
                      onChange={(e: DropdownChangeEvent) => {
                        field.onChange(e.value);
                      }}
                      optionLabel="label"
                      options={sourceOptions}
                    />
                  </>
                )}
              />
              <label>Источник</label>
            </span>
          </div>
          <div className="field flex flex-column mr-2">
            <span className="p-float-label">
              <Controller
                name="itemType"
                control={control}
                render={({ field }) => (
                  <>
                    <Dropdown
                      id={field.name}
                      value={field.value}
                      onChange={(e: DropdownChangeEvent) => {
                        field.onChange(e.value);
                        setItemType(e.value);
                        if (getValues("itemType") !== undefined)
                          setItemTypeSelectVisible(true);
                        else setItemTypeSelectVisible(false);
                      }}
                      optionLabel="label"
                      options={itemTypeOptions}
                      showClear
                    />
                  </>
                )}
              />
              <label>Тип предмета</label>
            </span>
          </div>
          <div className="field flex flex-column" style={{width: "-webkit-fill-available"}}>
            <ItemTypeSelect
              data={data}
              visible={itemTypeSelectVisible}
              //itemType={getValues("itemType")}
              itemType={itemType}
              control={control}
              register={register}
              getValues={getValues}
              setValue={setValue}
            />
          </div>
        </div>
      </form>
    </Dialog>
  );
};

export { EditItemShortDialog };
