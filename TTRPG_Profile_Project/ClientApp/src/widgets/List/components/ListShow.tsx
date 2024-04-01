import { ShowFilter } from "widgets/Filters";
import React, { useEffect, useState } from "react";
import "../scss/style.scss";
import { Button } from "primereact/button";
import {
  DeleteBestiaryDialog,
  DeleteItemDialog,
  DeleteSpellDialog,
  EditBestiaryDialog,
  EditItemShortDialog,
  EditSpellDialog,
} from "widgets/Dialog";
import { emptyItem } from "../../../shared/models/Item/DTO/EmptyItem";
import itemService from "shared/services/item.service";
import { Toast } from "primereact/toast";
import { FindIndexById } from "entities/GeneralFunc";
import { ShowItem } from "./ShowItem";
import { ItemDTO, ItemFilterDTO, LazyState } from "shared/models";
import { Paginator, PaginatorPageChangeEvent } from "primereact/paginator";
import { ShowSpell } from "./ShowSpell";
import { ShowBestiary } from "./ShowBestiary";

interface IListShow {
  getParams: () => {};
  lazyState: LazyState;
  entityList: ItemDTO[];
  setEntityList: React.Dispatch<React.SetStateAction<ItemDTO[]>>;
  entity: ItemDTO;
  setEntity: React.Dispatch<React.SetStateAction<ItemDTO>>;
  toast: React.MutableRefObject<Toast>;
  filter: ItemFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<ItemFilterDTO>>;
}

const ListShow = ({
  getParams,
  lazyState,
  entityList,
  setEntityList,
  entity,
  setEntity,
  toast,
  filter,
  setFilter,
}: IListShow) => {
  const [deleteDialogVisible, setDeleteDialogVisible] = useState(false);

  const [editDialogVisible, setEditDialogVisible] = useState<boolean>(false);
  const [editDialogHeader, setEditDialogHeader] = useState<string>("");

  const showContentFunc = ({ data }) => {
    if ("availabilityType" in data) {
      // Переменная data имеет тип ItemDTO
      return (
        <div>
          <ShowItem data={data} />
        </div>
      );
    } else if ("spellLevel" in data) {
      // Переменная data имеет тип SpellDTO
      return (
        <div>
          <ShowSpell />
        </div>
      );
    } else {
      // Переменная data имеет тип BestiaryDTO
      return (
        <div>
          <ShowBestiary />
        </div>
      );
    }
  };

  const showDialogs = () => {
    if ("availabilityType" in entity) {
      // Переменная data имеет тип ItemDTO
      return (
        <div>
          <DeleteItemDialog
            data={entity}
            visible={deleteDialogVisible}
            deleteItem={deleteItem}
            onHide={hideDialog}
          />
          <EditItemShortDialog
            data={entity}
            header={editDialogHeader}
            visible={editDialogVisible}
            onHide={hideDialog}
            onSave={saveItem}
          />
        </div>
      );
    } else if ("spellLevel" in entity) {
      // Переменная data имеет тип SpellDTO
      return (
        <div>
          <DeleteSpellDialog />
          <EditSpellDialog />
        </div>
      );
    } else {
      // Переменная data имеет тип BestiaryDTO
      return (
        <div>
          <DeleteBestiaryDialog />
          <EditBestiaryDialog />
        </div>
      );
    }
  };

  const onPageChange = (event: PaginatorPageChangeEvent) => {
    lazyState.first = event.first;
    lazyState.rows = event.rows;
    fetchData();
    console.log(lazyState);
  };

  const showEditDialog = (id: number) => {
    setEditDialogHeader("Изменение предмета");
    const index = FindIndexById(id, entityList);
    if (index !== -1) {
      const selectedItem = { ...entityList[index] }; // Создание копии объекта
      setEntity(selectedItem);
      setEditDialogVisible(true);
    }
  };

  const showCreateDialog = () => {
    setEditDialogHeader("Создание нового предмета");
    setEntity(emptyItem);
    setEditDialogVisible(true);
  };

  const showDeleteDialog = (id: number) => {
    const index = FindIndexById(id, entityList);
    if (index !== -1) {
      const selectedItem = { ...entityList[index] }; // Создание копии объекта
      setEntity(selectedItem);
      setDeleteDialogVisible(true);
    }
  };

  const hideDialog = () => {
    setDeleteDialogVisible(false);
    setEditDialogVisible(false);
    setEntity(emptyItem);
  };

  const saveItem = async () => {
    let result;
    if (entity.id !== 0)
      result = await itemService.updateItem({ item: entity, toast: toast });
    else result = await itemService.createItem({ item: entity, toast });

    if (result !== false) {
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
        setEntityList(items);
      }
    } catch (error) {
      console.error("Error fetching items:", error);
    }
  };

  useEffect(() => {}, []);

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
      {showDialogs()}
      <div>
        <Button label="Создать предмет" onClick={(e) => showCreateDialog()} />
      </div>
      <ShowFilter filter={filter} setFilter={setFilter} />
      {entityList.map((it, index) => (
        <div key={index} className="mb-4">
          <div className="card block bg-bluegray-50">
            <div className="flex flex-column text-0">
              <div>
                {showContentFunc({ data: it })}
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

export { ListShow };
