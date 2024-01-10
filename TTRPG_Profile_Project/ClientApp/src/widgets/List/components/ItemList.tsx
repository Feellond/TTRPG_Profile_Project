import { ItemFilter } from "widgets/Filters";
import React, { useEffect, useRef, useState } from "react";
import "../scss/style.scss";
import { Button } from "primereact/button";
import { EditItemShortDialog } from "widgets/Dialog";
import { emptyItem } from "../models/EmptyItem";
import itemService from "shared/services/item.service";
import { Toast } from "primereact/toast";
import { FindIndexById } from "entities/GeneralFunc";
import { ShowItem } from "./ShowItem";
import { ItemDTO, ItemFilterDTO } from "shared/models";
import { ItemEntityType } from "shared/enums/ItemEnums";

interface LazyState {
  first: number;
  rows: number;
  page: number;
}

const ItemList = () => {
  const [editDialogVisible, setEditDialogVisible] = useState<boolean>(false);
  const [editDialogHeader, setEditDialogHeader] = useState<string>("");

  const [itemList, setItemList] = useState<ItemDTO[]>([]);
  const [item, setItem] = useState<ItemDTO>(emptyItem);
  const [filter, setFilter] = useState<ItemFilterDTO>({} as ItemFilterDTO);

  const toast = useRef<Toast>(null);
  const [lazyState, setLazyState] = useState<LazyState>({
    first: 0,
    rows: 20,
    page: 0,
  });


  const getParams = () => {
    const params = {};
    params["page"] = lazyState.page;
    params["pageSize"] = lazyState.rows;
    console.log(filter);

    if (filter) {
      if (filter.name) {
        params["name"] = filter.name;
      }
      if (filter.itemType) {
        params["itemType"] = filter.itemType;
      }
    }

    console.log(params);
    return params;
  }

  const showEditDialog = (id: number) => {
    const index = FindIndexById(id, itemList);
    if (index !== -1) {
      setItem(itemList[index]);
      setEditDialogVisible(true);
    }
  };

  const showCreateDialog = () => {
    setEditDialogHeader("Создание нового предмета")
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
          itemType: 1, //ItemEntityType.BaseItem
          toast: toast,
          params: getParams(),
        });
        console.log(result);

        if (result && result.data) {
          const items: ItemDTO[] = result.data;
          console.log(items);
          setItemList(items);
        }
      } catch (error) {
        console.error("Error fetching items:", error);
      }
    };

    fetchData();
  }, [lazyState, filter]);

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
      <ItemFilter filter={filter} setFilter={setFilter}/>
      {itemList.map((it, index) => (
        <div key={index} className="mb-4">
          <div className="card block bg-bluegray-50">
            <div className="flex flex-column text-0">
              <div>
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
