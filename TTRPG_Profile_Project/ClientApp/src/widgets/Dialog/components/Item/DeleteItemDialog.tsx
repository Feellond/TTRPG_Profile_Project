import { Button } from "primereact/button";
import { Dialog } from "primereact/dialog";
import React from "react";
import { ItemDTO } from "shared/models";
import { drawItemEntityType } from "widgets/List";

interface DeleteItemShortDialogProps {
  data: ItemDTO;
  visible: boolean;
  deleteItem: (id: number, itemType: number) => Promise<void>;
  onHide: () => void;
}

const DeleteItemDialog = ({ data, visible, deleteItem, onHide }: DeleteItemShortDialogProps) => {

  const deleteFooter = (id: number, itemType: number) => {
    return (
      <div>
        <Button
          label="Да"
          icon="pi pi-check"
          onClick={() => deleteItem(id, itemType)}
        />
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
        footer={deleteFooter(data.id, data.itemType)}
      >
        <p>
          Вы уверены, что хотите удалить предмет {drawItemEntityType(data)} с id ={" "}
          {data.id}?
        </p>
      </Dialog>
    </div>
  );
};

export { DeleteItemDialog };
