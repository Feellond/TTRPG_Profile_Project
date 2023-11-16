import { ItemFilter } from "widgets/Filters";
import React, { useEffect, useRef, useState } from "react";
import "../scss/style.scss";
import { Button } from "primereact/button";
import { EditItemShortDialog } from "widgets/Dialog";
import { emptyItem } from "../models/EmptyItem";
import itemService from "shared/services/item.service";
import { Toast } from "primereact/toast";
import { ItemDTO } from "shared/models";
import { FindIndexById } from "entities/GeneralFunc";
import { ItemType } from "shared/enums/ItemEnums";

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
  }

  const saveItem = async () => {
    if (item.id !== 0) return await itemService.updateItem({item: item, toast: toast});
    else await itemService.createItem({item, toast});

    hideDialog();
  };

  useEffect(() => {
    let result = itemService.getItems({itemType: ItemType.BaseItem, toast: toast});
    console.log(result);
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
      <div className="mb-4">
        <div className="card block bg-bluegray-50">
          <div className="flex flex-column text-0">
            <div
              className="p-2 text-2xl font-semibold cursor-pointer"
              style={{ marginBottom: "-10px" }}
            >
              <a href="listitem/1">Элемент под наименованием 1 item.Name</a>
            </div>
            <ul className="p-2 params">
              <li style={{ float: "right" }}>Изображение</li>
              <li>
                <i>Оружие, Редкий</i>
              </li>
              <li>
                <strong>Стоимость в кронах:</strong> 1000,
                <strong> Вес:</strong> 0,5кг
              </li>
              <li>
                <strong>Требуемый навык:</strong>
                <a> Владение мечом</a>
              </li>
              <li className="stats flex flex-row py-2">
                <div className="stat" title="Точность">
                  <div>Точ</div>
                  <div>+0</div>
                </div>
                <div className="stat" title="Урон">
                  <div>Урон</div>
                  <div>3к6+2</div>
                </div>
                <div className="stat" title="Надежность">
                  <div>Над</div>
                  <div>10</div>
                </div>
                <div className="stat" title="Хват">
                  <div>Хват</div>
                  <div>1</div>
                </div>
                <div className="stat" title="Дистанция">
                  <div>Дист</div>
                  <div>-</div>
                </div>
                <div className="stat" title="Скрытность">
                  <div>Скрыт</div>
                  <div>Н/С</div>
                </div>
                <div className="stat" title="Количество улучшений">
                  <div>Улуч</div>
                  <div>1</div>
                </div>
                <div className="stat" title="Свойства">
                  <div>Свойства</div>
                  <div>
                    <a>Горение(75%); </a>
                    <a>Кровотечение(25%) </a>
                    <a>Отравление(25%) </a>
                  </div>
                </div>
              </li>
              <li className="my-2">
                <div>
                  Дополнительная информация о предмете и возможно наиболее
                  полная
                </div>
              </li>
            </ul>
            <div>
              Footer
              <Button
                label="Редактировать предмет"
                onClick={(e) => showEditDialog(1)}
              />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export { ItemList };
