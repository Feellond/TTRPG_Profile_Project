import { ShowFilter } from "widgets/Filters";
import React, { useContext, useEffect, useState } from "react";
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
import { Toast } from "primereact/toast";
import { FindIndexById } from "entities/GeneralFunc";
import { ShowItem } from "./ShowItem";
import {
  ClassFilterDTO,
  CreatureFilterDTO,
  IClass,
  ICreature,
  IRace,
  ISpell,
  ItemDTO,
  ItemFilterDTO,
  LazyState,
  RaceFilterDTO,
  SpellFilterDTO,
} from "shared/models";
import { Paginator, PaginatorPageChangeEvent } from "primereact/paginator";
import { ShowSpell } from "./ShowSpell";
import { ShowBestiary } from "./ShowBestiary";
import itemService from "shared/services/item.service";
import bestiaryService from "shared/services/bestiary.service";
import spellService from "shared/services/spell.service";
import { Context } from "index";
import { ShowClass } from "./ShowClass";
import { ShowRace } from "./ShowRace";

interface IListShow {
  getParams: () => {};
  lazyState: LazyState;
  entityList: ItemDTO[] | ICreature[] | ISpell[] | IClass[] | IRace[];
  setEntityList: React.Dispatch<
    React.SetStateAction<
      ItemDTO[] | ICreature[] | ISpell[] | IClass[] | IRace[]
    >
  >;
  entity: ItemDTO | ICreature | ISpell | IClass | IRace;
  setEntity: React.Dispatch<
    React.SetStateAction<ItemDTO | ICreature | ISpell | IClass | IRace>
  >;
  emptyEntity: ItemDTO | ICreature | ISpell | IClass | IRace;
  toast: React.MutableRefObject<Toast>;
  filter:
    | ItemFilterDTO
    | CreatureFilterDTO
    | SpellFilterDTO
    | RaceFilterDTO
    | ClassFilterDTO;
  setFilter: React.Dispatch<
    React.SetStateAction<
      | ItemFilterDTO
      | CreatureFilterDTO
      | SpellFilterDTO
      | RaceFilterDTO
      | ClassFilterDTO
    >
  >;
}

const ListShow = ({
  getParams,
  lazyState,
  entityList,
  setEntityList,
  entity,
  setEntity,
  emptyEntity,
  toast,
  filter,
  setFilter,
}: IListShow) => {
  const [deleteDialogVisible, setDeleteDialogVisible] = useState(false);
  const [editDialogVisible, setEditDialogVisible] = useState<boolean>(false);
  const [editDialogHeader, setEditDialogHeader] = useState<string>("");
  const [isCreateDialog, setIsCreateDialog] = useState<boolean>(false);

  const { store } = useContext(Context);

  const showContentFunc = ({ data }) => {
    if ("itemType" in data) {
      // Переменная data имеет тип ItemDTO
      return <ShowItem data={data} />;
    } else if ("spellLevel" in data) {
      // Переменная data имеет тип SpellDTO
      return <ShowSpell data={data} />;
    } else if ("blockBase" in data) {
      // Переменная data имеет тип BestiaryDTO
      return <ShowBestiary data={data} />;
    } else if ("energy" in entity) {
      return <ShowClass data={data} />;
    } else {
      return <ShowRace data={data} />;
    }
  };

  const showDialogs = () => {
    if ("itemType" in entity) {
      // Переменная data имеет тип ItemDTO
      return (
        <div>
          <DeleteItemDialog
            data={entity}
            visible={deleteDialogVisible}
            deleteItem={deleteEntity}
            onHide={hideDialog}
          />
          <EditItemShortDialog
            data={entity}
            header={editDialogHeader}
            visible={editDialogVisible}
            isCreate={isCreateDialog}
            onHide={hideDialog}
            onSave={saveEntity}
          />
        </div>
      );
    } else if ("spellLevel" in entity) {
      // Переменная data имеет тип SpellDTO
      return (
        <div>
          <DeleteSpellDialog
            data={entity}
            visible={deleteDialogVisible}
            deleteSpell={deleteEntity}
            onHide={hideDialog}
          />
          <EditSpellDialog
            data={entity}
            header={editDialogHeader}
            visible={editDialogVisible}
            onHide={hideDialog}
            onSave={saveEntity}
          />
        </div>
      );
    } else if ("blockBase" in entity) {
      // Переменная data имеет тип BestiaryDTO
      return (
        <div>
          <DeleteBestiaryDialog
            data={entity}
            visible={deleteDialogVisible}
            deleteCreature={deleteEntity}
            onHide={hideDialog}
          />
          <EditBestiaryDialog
            data={entity}
            header={editDialogHeader}
            visible={editDialogVisible}
            onSave={fetchData}
            onHide={hideDialog}
          />
        </div>
      );
    }
  };

  const onPageChange = (event: PaginatorPageChangeEvent) => {
    lazyState.first = event.first;
    lazyState.rows = event.rows;
    fetchData();
  };

  const showEditDialog = (id: number) => {
    setEditDialogHeader("Изменение предмета");
    setIsCreateDialog(false);
    const index = FindIndexById(id, entityList);
    if (index !== -1) {
      const selectedItem = { ...entityList[index] }; // Создание копии объекта
      setEntity(selectedItem);
      setEditDialogVisible(true);
    }
  };

  const showCreateDialog = () => {
    setEditDialogHeader("Создание нового предмета");
    setIsCreateDialog(true);
    setEntity(emptyEntity);
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
    setEntity(emptyEntity);
  };

  const saveEntity = async () => {
    let result;
    if ("itemType" in entity) {
      if (entity.id !== 0)
        result = await itemService.updateEntity({
          entity: entity as ItemDTO,
          toast: toast,
        });
      else
        result = await itemService.createEntity({
          entity: entity as ItemDTO,
          toast,
        });
    } else if ("spellType" in entity) {
      if (entity.id !== 0)
        result = await spellService.updateEntity({
          entity: entity as ISpell,
        });
      else
        result = await spellService.createEntity({
          entity: entity as ISpell,
        });
    }

    if (result !== false) {
      hideDialog();
      fetchData();
    }
  };

  const deleteEntity = async (id: number, itemType: number) => {
    let result;

    if ("itemType" in entity)
      result = await itemService.deleteEntity({ id, itemType, toast });
    else if ("race" in entity)
      result = await bestiaryService.deleteEntity({ id });
    else if ("spellLevel" in entity)
      result = await spellService.deleteEntity({ id });

    if (result !== false) {
      hideDialog();
      fetchData();
    }
  };

  const fetchData = async () => {
    try {
      let result;

      if ("itemType" in entity) {
        result = await itemService.getEntitys({
          itemType: 1, //ItemEntityType.BaseItem
          toast: toast,
          params: getParams(),
        });
      } else if ("blockBase" in entity) {
        result = await bestiaryService.getEntitys({
          params: getParams(),
        });
      } else if ("spellType" in entity) {
        result = await spellService.getEntitys({
          params: getParams(),
        });
      } else if ("energy" in entity) {
        result = await bestiaryService.getClasses({
          params: getParams(),
        });
      } else {
        result = await bestiaryService.getRaces({
          params: getParams(),
        });
      }

      if (result && result.data) {
        lazyState.totalRecords = result.data.count;
        const entitys = result.data.entitys;
        console.log("entitys", entitys);
        setEntityList(entitys);
      }
    } catch (error) {
      console.error("Error fetching entitys:", error);
    }
  };

  useEffect(() => {}, []);

  useEffect(() => {
    fetchData();
  }, [lazyState, filter]);

  //onClick={(e) => handleClick(1, e)}
  // const handleClick = (id, e) => {
  //   e.preventDefault(); // Предотвращаем переход по ссылке

  //   const url = `listitem/${id}`;
  //   window.open(url, "_blank");
  // };

  return (
    <div className="w-full" style={{ marginTop: "-20px" }}>
      <Toast ref={toast} />
      {showDialogs()}
      {store.isAuth &&
        ("itemType" in entity ||
        "spellLevel" in entity ||
        "blockBase" in entity ? (
          <div>
            <Button
              icon="pi pi-plus"
              label="Создать предмет"
              className="p-button-site"
              onClick={(e) => showCreateDialog()}
            />
          </div>
        ) : (
          ""
        ))}
      <ShowFilter filter={filter} setFilter={setFilter} />
      {entityList !== null && entityList !== undefined ? (
        entityList.map((it, index) => (
          <div key={index} className="mb-4">
            <div className="card block bg-bluegray-50">
              <div className="flex flex-column text-0">
                <div>
                  {showContentFunc({ data: it })}
                  {store.isAuth &&
                    ("itemType" in entity || "spellType" in entity ? (
                      <div className="edit-buttons">
                        <Button
                          icon="pi pi-pencil"
                          onClick={(e) => showEditDialog(it.id)}
                          className="p-button-site"
                        />
                        <Button
                          icon="pi pi-trash"
                          onClick={(e) => showDeleteDialog(it.id)}
                          className="ml-3 p-button-site"
                        />
                      </div>
                    ) : (
                      <div>
                        <Button
                          icon="pi pi-trash"
                          onClick={(e) => showDeleteDialog(it.id)}
                          className="p-button-site"
                        />
                      </div>
                    ))}
                </div>
              </div>
            </div>
          </div>
        ))
      ) : (
        <div></div>
      )}
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
