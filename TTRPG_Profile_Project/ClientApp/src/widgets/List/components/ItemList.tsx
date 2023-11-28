import { ItemFilter } from "widgets/Filters";
import React, { useEffect, useRef, useState } from "react";
import "../scss/style.scss";
import { Button } from "primereact/button";
import { EditItemShortDialog } from "widgets/Dialog";
import { emptyItem } from "../models/EmptyItem";
import itemService from "shared/services/item.service";
import { Toast } from "primereact/toast";
import { FindIndexById } from "entities/GeneralFunc";
import { ItemType } from "shared/enums/ItemEnums";
import { ShowItem } from "./ShowItem";
import { ItemDTO } from "shared/models";

const ItemList = () => {
  const [editDialogVisible, setEditDialogVisible] = useState<boolean>(false);
  const [editDialogHeader, setEditDialogHeader] = useState<string>("");

  const [itemList, setItemList] = useState<ItemDTO[]>([]);
  const [item, setItem] = useState<ItemDTO>(emptyItem);

  const toast = useRef<Toast>(null);

  const showEditDialog = (id: number) => {
    const index = FindIndexById(id, itemList);
    if (index !== -1) {
      setItem(itemList[index]);
      setEditDialogVisible(true);
    }
  };

  const showCreateDialog = () => {
    setItem(emptyItem);
    setEditDialogVisible(true);
  };

  const hideDialog = () => {
    setEditDialogVisible(false);
    setItem(emptyItem);
  };

  const saveItem = async () => {
    if (item.id !== 0)
      return await itemService.updateItem({ item: item, toast: toast });
    else await itemService.createItem({ item, toast });

    hideDialog();
  };

  const deleteItem = async (id: number, itemType: number) => {
    itemService.deleteItem({ id, itemType, toast });
  };

  useEffect(() => {
    const fetchData = async () => {
      try {
        let result = await itemService.getItems({
          itemType: ItemType.BaseItem,
          toast: toast,
        });
        console.log(result);

        if (result && result.data) {
          const items: ItemDTO[] = result.data;
          console.log(items);
          setItemList(items);
        }
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

  //onClick={(e) => handleClick(1, e)}
  const handleClick = (id, e) => {
    e.preventDefault(); // Предотвращаем переход по ссылке

    const url = `listitem/${id}`;
    window.open(url, "_blank");
  };

  return (
    <div className="w-full" style={{ marginTop: "-20px" }}>
      <EditItemShortDialog
        data={item}
        header={editDialogHeader}
        visible={editDialogVisible}
        onHide={hideDialog}
        onSave={saveItem}
      />
      <div>
        <Button label="Создать предмет" onClick={(e) => showCreateDialog()} />
      </div>
      <ItemFilter></ItemFilter>
      {itemList.map((it, index) => (
        <div className="mb-4">
          <div className="card block bg-bluegray-50">
            <div className="flex flex-column text-0">
              <div key={index}>
                <ShowItem data={it} />
                <div>
                  Footer
                  <Button
                    label="Редактировать предмет"
                    //onClick={(e) => showEditDialog(it.id)}
                  />
                  <Button
                    label="Удалить предмет"
                    //onClick={(e) => deleteItem(it.id, it.itemType)}
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
      ))}
    </div>
  );
};

export { ItemList };
