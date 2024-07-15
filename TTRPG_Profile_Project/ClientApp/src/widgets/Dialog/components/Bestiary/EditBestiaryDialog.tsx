import { ComplexityLoad, RaceLoad } from "entities/BestiaryFunc";
import { SourceOptionsLoad } from "entities/GeneralFunc";
import { Button } from "primereact/button";
import { Dialog } from "primereact/dialog";
import { Dropdown, DropdownChangeEvent } from "primereact/dropdown";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import React, { useEffect, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { emptyCreature, ICreature } from "shared/models";
import bestiaryService from "shared/services/bestiary.service";

interface IEditBestiaryDialog {
  data: ICreature;
  visible: boolean;
  header: string;
  onSave: () => void;
  onHide: () => void;
}

const EditBestiaryDialog = ({
  data,
  visible,
  header,
  onSave,
  onHide,
}: IEditBestiaryDialog) => {
  const [complexityOptions, setComplexityOptions] = useState<SelectItem[]>([]);
  const [raceOptions, setRaceOptions] = useState<SelectItem[]>([]);
  const [sourceOptions, setSourceOptions] = useState<SelectItem[]>([]);

  useEffect(() => {
    ComplexityLoad({ setItems: setComplexityOptions });
    RaceLoad({ setItems: setRaceOptions });
    SourceOptionsLoad({ setItems: setSourceOptions });
  }, []);

  const Create = async () => {
    let dialogData = getValues();
    //console.log(dialogData);

    let creature = emptyCreature;
    creature.name = dialogData.name;
    creature.complexity = dialogData.complexity;
    creature.race = dialogData.race;
    creature.source = dialogData.source;

    console.log(creature);
    var result = await bestiaryService.createEntity({entity: creature});
    onHide();
    onSave();
    return result.data as ICreature;
  };

  const CreateAndContinue = async () => {
    var data = await Create();
    const url = `bestiary/${data.id}`;
    window.open(url, "_blank");
  }

  const footerContent = (
    <div>
      <Button
        label="Отмена"
        icon="pi pi-times"
        onClick={() => onHide()}
        className="p-button-text mr-1"
      />
      <Button
        label="Создать"
        icon="pi pi-check"
        onClick={() => Create()}
        className="p-button-text mr-1"
      />
      <Button
        label="Создать и продолжить"
        icon="pi pi-check"
        onClick={() => CreateAndContinue()}
        className="p-button-text mr-1"
      />
    </div>
  );

  const SetValues = () => {
    setValue("name", "");
    setValue("complexity", null);
    setValue("race", null);
    setValue("source", null);
  }

  useEffect(() => {
    SetValues();
  }, [visible])

  const {
    register,
    setValue,
    getValues,
    control,
    formState: { errors },
    handleSubmit,
  } = useForm();

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
          <div className="field flex flex-column mr-3">
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
          <div className="field flex flex-column mr-3" style={{width: "172px"}}>
            <span className="p-float-label">
              <Controller
                name="complexity"
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
                      options={complexityOptions}
                    />
                  </>
                )}
              />
              <label>Сложность</label>
            </span>
          </div>
          <div className="field flex flex-column mr-3" style={{width: "172px"}}>
            <span className="p-float-label">
              <Controller
                name="race"
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
                      options={raceOptions}
                    />
                  </>
                )}
              />
              <label>Раса</label>
            </span>
          </div>
          <div className="field flex flex-column" style={{width: "172px"}}>
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
        </div>
      </form>
    </Dialog>
  );
};

export { EditBestiaryDialog };
