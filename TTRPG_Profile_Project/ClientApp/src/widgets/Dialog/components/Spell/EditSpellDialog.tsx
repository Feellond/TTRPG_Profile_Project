import { SourceOptionsLoad } from "entities/GeneralFunc";
import { Button } from "primereact/button";
import { Dialog } from "primereact/dialog";
import { Dropdown, DropdownChangeEvent } from "primereact/dropdown";
import { InputNumber } from "primereact/inputnumber";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import { SelectItem } from "primereact/selectitem";
import React, { useEffect, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { ISpell } from "shared/models";
import { SpellTypeSelect } from "./SpellTypeSelect";
import { SpellTypeOptionsLoad } from "entities/SpellFunc";

interface IEditSpellDialog {
  data: ISpell;
  visible: boolean;
  header: string;
  onHide: () => void;
  onSave: () => void;
}

const EditSpellDialog = ({
  data,
  visible,
  header,
  onHide,
  onSave,
}: IEditSpellDialog) => {
  const [sourceOptions, setSourceOptions] = useState<SelectItem[]>([]);
  const [spellTypeOptions, setSpellTypeOptions] = useState<SelectItem[]>([]);

  const [spellTypeSelectVisible, setSpellTypeSelectVisible] =
    useState<boolean>(false);

  const [spellType, setSpellType] = useState<number>(undefined);

  const {
    register,
    setValue,
    getValues,
    control,
    formState: { errors },
    handleSubmit,
  } = useForm();

  const SaveChanges = () => {
    let dialogData = getValues();
    console.log("dialogData: ", dialogData);

    data.name = dialogData.name;
    data.description = dialogData.description;
    data.source = dialogData.source;
    data.enduranceCost = dialogData.enduranceCost;
    data.distance = dialogData.distance;
    data.duration = dialogData.duration;
    data.spellSkillProtectionList = dialogData.spellSkillProtectionList;
    data.isConcentration = dialogData.isConcentration;
    data.concentrationEnduranceCost = dialogData.concentrationEnduranceCost;
    data.spellLevel = dialogData.spellLevel;
    data.spellComponentList = dialogData.spellComponentList;
    data.checkDC = dialogData.checkDC;
    data.preparationTime = dialogData.preparationTime;
    data.dangerInfo = dialogData.dangerInfo;
    data.withdrawalCondition = dialogData.withdrawalCondition;
    data.spellType = dialogData.spellType;
    data.spellTypeDescription = dialogData.spellTypeDescription;
    data.sourceType = dialogData.sourceType;
    data.sourceTypeDescription = dialogData.sourceTypeDescription;
    data.isPriestSpell = dialogData.isPriestSpell;
    data.isDruidSpell = dialogData.isDruidSpell;

    console.log(data);
    onSave();
  };

  const SetValues = () => {
    setValue("name", data.name);
    setValue("description", data.description);
    setValue("source", data.source);
    setValue("enduranceCost", data.enduranceCost);
    setValue("distance", data.distance);
    setValue("duration", data.duration);
    setValue("spellSkillProtectionList", data.spellSkillProtectionList);
    setValue("isConcentration", data.isConcentration);
    setValue("concentrationEnduranceCost", data.concentrationEnduranceCost);
    setValue("spellLevel", data.spellLevel);
    setValue("spellComponentList", data.spellComponentList);
    setValue("checkDC", data.checkDC);
    setValue("preparationTime", data.preparationTime);
    setValue("dangerInfo", data.dangerInfo);
    setValue("withdrawalCondition", data.withdrawalCondition);
    setValue("spellType", data.spellType);
    setValue("spellTypeDescription", data.spellTypeDescription);
    setValue("sourceType", data.sourceType);
    setValue("sourceTypeDescription", data.sourceTypeDescription);
    setValue("isPriestSpell", data.isPriestSpell);
    setValue("isDruidSpell", data.isDruidSpell);

    setSpellType(data.spellType);
    if (getValues("spellType") !== undefined) setSpellTypeSelectVisible(true);
    else setSpellTypeSelectVisible(false);
  };

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

  useEffect(() => {
    SpellTypeOptionsLoad({ setItems: setSpellTypeOptions });
    SourceOptionsLoad({ setItems: setSourceOptions });
  }, []);

  useEffect(() => {
    SetValues();
  }, [visible]);

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
        <div className="align-items-center mt-4 flex flex-wrap">
          <div className="field flex mr-2">
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
          <div className="field flex mr-2">
            <span className="p-float-label" style={{ width: "172px" }}>
              <Controller
                name="spellType"
                control={control}
                render={({ field }) => (
                  <>
                    <Dropdown
                      id={field.name}
                      value={field.value}
                      onChange={(e: DropdownChangeEvent) => {
                        field.onChange(e.value);
                        setSpellType(e.value);
                        if (getValues("spellType") !== undefined)
                          setSpellTypeSelectVisible(true);
                        else setSpellTypeSelectVisible(false);
                      }}
                      optionLabel="label"
                      options={spellTypeOptions}
                    />
                  </>
                )}
              />
              <label>Тип заклинания</label>
            </span>
          </div>
          <div className="field flex mr-2">
            <span className="p-float-label" style={{ width: "172px" }}>
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
          <div className="field flex mr-2">
            <span className="p-float-label">
              <InputNumber
                value={data.enduranceCost}
                min={0}
                max={999}
                placeholder="ВЫН"
                onValueChange={(e) => {
                  setValue("enduranceCost", e.target.value);
                }}
              />
              <label>Затраты ВЫН</label>
            </span>
          </div>
          <div
            className="flex flex-column field flex mr-2"
            style={{ width: "-webkit-fill-available" }}
          >
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
              <label>Эффект</label>
            </span>
          </div>
          <div
            className="field flex flex-column mr-2"
            style={{ width: "-webkit-fill-available" }}
          >
            <SpellTypeSelect
              data={data}
              visible={spellTypeSelectVisible}
              //itemType={getValues("itemType")}
              spellType={spellType}
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

export { EditSpellDialog };
