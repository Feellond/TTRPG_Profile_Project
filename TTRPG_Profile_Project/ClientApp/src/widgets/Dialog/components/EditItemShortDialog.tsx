import { Dialog } from 'primereact/dialog';
import React, { useEffect } from "react";
import { ItemShortDTO } from "widgets/List/models/ItemsDTO";

interface EditItemShortDialogProps {
  data: ItemShortDTO;
  visible: boolean

  onHide: () => void;
  onSave: () => void;
}

const EditItemShortDialog = ({
    data,
    visible,

    onHide,
    onSave
} : EditItemShortDialogProps) => {

  useEffect(() => {
    
  }, [visible])

  return (
    <Dialog
      visible={visible}
      onHide={() => onHide()}
    >
      
    </Dialog>
  );
};

export {EditItemShortDialog}