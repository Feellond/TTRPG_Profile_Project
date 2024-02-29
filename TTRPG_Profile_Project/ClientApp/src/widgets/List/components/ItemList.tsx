import { ItemFilter } from "widgets/Filters";
import React, { useEffect, useRef, useState } from "react";
import "../scss/style.scss";
import { Button } from "primereact/button";
import { DeleteItemDialog, EditItemShortDialog } from "widgets/Dialog";
import { emptyItem } from "../models/EmptyItem";
import itemService from "shared/services/item.service";
import { Toast } from "primereact/toast";
import { FindIndexById } from "entities/GeneralFunc";
import { ShowItem } from "./ShowItem";
import { ItemDTO, ItemFilterDTO } from "shared/models";
import { Paginator, PaginatorPageChangeEvent } from 'primereact/paginator';

interface LazyState {
  first: number;
  rows: number;
  page: number;
  totalRecords: number;
}

const ItemList = () => {
  const [deleteDialogVisible, setDeleteDialogVisible] = useState(false);

  const [editDialogVisible, setEditDialogVisible] = useState<boolean>(false);
  const [editDialogHeader, setEditDialogHeader] = useState<string>("");

  const [itemList, setItemList] = useState<ItemDTO[]>([]);
  const [item, setItem] = useState<ItemDTO>(emptyItem);
  const [filter, setFilter] = useState<ItemFilterDTO>({} as ItemFilterDTO);

  const toast = useRef<Toast>(null);
  const [lazyState, setLazyState] = useState<LazyState>({
    first: 0,
    rows: 10,
    page: 0,
    totalRecords: 100,
  });

  const onPageChange = (event: PaginatorPageChangeEvent) => {
    lazyState.first = event.first;
    lazyState.rows = event.rows;
    fetchData();
    console.log(lazyState)
  };

  const getParams = () => {
    const params = {};
    params["first"] = lazyState.first;
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
    setEditDialogHeader("Изменение предмета");
    const index = FindIndexById(id, itemList);
    if (index !== -1) {
      const selectedItem = { ...itemList[index] }; // Создание копии объекта
      setItem(selectedItem);
      setEditDialogVisible(true);
    }
  };

  const showCreateDialog = () => {
    setEditDialogHeader("Создание нового предмета")
    setItem(emptyItem);
    setEditDialogVisible(true);
  };

  const showDeleteDialog = (id: number) => {
    const index = FindIndexById(id, itemList);
    if (index !== -1) {
      const selectedItem = { ...itemList[index] }; // Создание копии объекта
      setItem(selectedItem);
      setDeleteDialogVisible(true);
    }
  }

  const hideDialog = () => {
    setDeleteDialogVisible(false);
    setEditDialogVisible(false);
    setItem(emptyItem);
  };

  const saveItem = async () => {
    let result;
    if (item.id !== 0)
      result = await itemService.updateItem({ item: item, toast: toast });
    else result = await itemService.createItem({ item, toast });

    if (result !== false)
    {
      hideDialog();
      fetchData();
    }
  };

  const deleteItem = async (id: number, itemType: number) => {
    let result = await itemService.deleteItem({ id, itemType, toast });

    if (result !== false) {
      hideDialog();
      fetchData();
    }
  };

  const fetchData = async () => {
    try {
      let result = await itemService.getItems({
        itemType: 1, //ItemEntityType.BaseItem
        toast: toast,
        params: getParams(),
      });
      console.log(result);

      if (result && result.data) {
        lazyState.totalRecords = result.data.count;
        const items: ItemDTO[] = result.data.items;
        console.log(items);
        setItemList(items);
      }
    } catch (error) {
      console.error("Error fetching items:", error);
    }
  };

  useEffect(() => {

  }, [])

  useEffect(() => {
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
      <Toast ref={toast} />
      <DeleteItemDialog
        data={item}
        visible={deleteDialogVisible}
        deleteItem={deleteItem}
        onHide={hideDialog}
      />
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
      <ItemFilter filter={filter} setFilter={setFilter} />
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
                    onClick={(e) => showEditDialog(it.id)}
                  />
                  <Button
                    label="Удалить предмет"
                    onClick={(e) => showDeleteDialog(it.id)}
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
      ))}
      <Paginator
        first={lazyState.first}
        rows={lazyState.rows}
        totalRecords={lazyState.totalRecords}
        rowsPerPageOptions={[10, 20, 50, 100]}
        onPageChange={onPageChange}
      />
    </div>
  );
};

export { ItemList };
