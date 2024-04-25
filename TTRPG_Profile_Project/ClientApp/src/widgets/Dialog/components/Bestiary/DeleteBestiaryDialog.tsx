import { Button } from "primereact/button";
import { Dialog } from "primereact/dialog";
import React from "react";
import { ICreature } from "shared/models";

interface IDeleteBestiaryDialog {
  data: ICreature;
  visible: boolean;
  deleteCreature: (id: number, itemType: number) => Promise<void>;
  onHide: () => void;
}

const DeleteBestiaryDialog = ({
  data,
  visible,
  deleteCreature,
  onHide,
}: IDeleteBestiaryDialog) => {
  const deleteFooter = (id: number) => {
    return (
      <div>
        <Button label="Да" icon="pi pi-check" onClick={() => deleteCreature(id, 0)} />
        <Button
          label="Нет"
          icon="pi pi-times"
          onClick={() => onHide()}
          className="p-button-secondary"
        />
      </div>
    );
  };

  return (
    <div>
      <Dialog
        header="Подтверждение удаления"
        onHide={() => onHide()}
        visible={visible}
        style={{ width: "50vw" }}
        modal
        footer={deleteFooter(data.id)}
      >
        <p>
          Вы уверены, что хотите удалить существо {data.name} с id = {data.id}?
        </p>
      </Dialog>
    </div>
  );
};

export { DeleteBestiaryDialog };
