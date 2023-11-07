import { Dialog } from "primereact/dialog";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import React, { useEffect, useState } from "react";
import { ItemShortDTO } from "widgets/List/models/ItemsDTO";
import { Controller, useForm } from "react-hook-form";
import { Button } from "primereact/button";
import { SelectItem } from "primereact/selectitem";
import { ItemTypeLoad } from "entities/ItemType";
import { Dropdown, DropdownChangeEvent } from "primereact/dropdown";

interface EditItemShortDialogProps {
  data: ItemShortDTO;
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

  const SaveChanges = () => {
    let dialogData = getValues();
    data.name = dialogData.name;
    onSave();
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
              <label htmlFor="name">Наименование</label>
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
              <label htmlFor="description">Описание</label>
            </span>
          </div>
          <div className="field flex flex-column col-3">
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
                      }}
                      optionLabel="label"
                      options={itemTypeOptions}
                    />
                  </>
                )}
              />
              <label htmlFor="type">Выберите тип</label>
            </span>
          </div>
        </div>
      </form>
    </Dialog>
  );
};

export { EditItemShortDialog };
