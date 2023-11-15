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
import { AvailabilityTypeLoad, ItemTypeLoad } from "entities/ItemFunc";

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

  const SaveChanges = () => {
    let dialogData = getValues();
    console.log(dialogData);

    data.name = dialogData.name;
    data.description = dialogData.description;
    data.availabilityType = dialogData.availabilityType;
    data.weight = dialogData.weight;
    data.price = dialogData.price;
    data.itemBaseEffectLists = dialogData.itemBaseEffectLists;
    data.sourceId = dialogData.sourceId;
    data.itemType = dialogData.itemType;
    data.accuracy = dialogData.accuracy;
    data.damage = dialogData.damage;
    data.reliability = dialogData.reliability;
    data.grip = dialogData.grip;
    data.distance = dialogData.distance;
    data.stealthType = dialogData.stealthType;
    data.amountOfEnhancements = dialogData.amountOfEnhancements;
    data.isAmmunition = dialogData.isAmmunition;
    data.skillId = dialogData.skillId;
    data.type = dialogData.type;
    data.complexity = dialogData.complexity;
    data.timeSpend = dialogData.timeSpend;
    data.additionalPayment = dialogData.additionalPayment;
    data.formulaComponentLists = dialogData.formulaComponentLists;
    data.blueprintComponentLists = dialogData.blueprintComponentLists;
    data.whereToFind = dialogData.whereToFind;
    data.amount = dialogData.amount;
    data.isAlchemical = dialogData.isAlchemical;
    data.substanceType = dialogData.substanceType;
    data.stiffness = dialogData.stiffness;
    console.log(data);
    //onSave();
  };

  const SetValues = () => {
    setValue("name", data.name);
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
    ItemTypeLoad({ setItems: setItemTypeOptions });
    AvailabilityTypeLoad({ setItems: setAvailabilityTypeOptions });
  }, []);

  useEffect(() => {
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
        <div className="grid align-items-center">
          <div className="field flex flex-column col-3">
            <span className="p-float-label">
              <InputText id="name" value={data.name} {...register("name")} />
              <label>Наименование</label>
            </span>
          </div>
          <div className="field flex flex-column col-3">
            <span className="p-float-label">
              <InputTextarea
                id="description"
                value={data.description}
                {...register("name")}
                rows={5}
                cols={60}
              />
              <label>Описание</label>
            </span>
          </div>
          <div className="field flex flex-column col-3">
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
          <div className="flex-auto">
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
          <div className="flex-auto">
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
          <div className="field flex flex-column col-3">
            <span className="p-float-label">
              <Controller
                name="sourceId"
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
          <div className="field flex flex-column col-3">
            <span className="p-float-label">
              <label>Выберите тип предмета</label>
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
                        if (getValues("itemType") !== null)
                          setItemTypeSelectVisible(true);
                        else setItemTypeSelectVisible(false);
                      }}
                      optionLabel="label"
                      options={itemTypeOptions}
                    />
                  </>
                )}
              />
            </span>
          </div>
          <ItemTypeSelect
            data={data}
            visible={itemTypeSelectVisible}
            itemType={getValues("itemType")}
            control={control}
            register={register}
          />
        </div>
      </form>
    </Dialog>
  );
};

export { EditItemShortDialog };
