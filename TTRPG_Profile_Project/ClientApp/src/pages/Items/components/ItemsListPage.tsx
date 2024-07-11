import { Card } from "primereact/card";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import { useLocation } from "react-router-dom";
import { ItemEntityType } from "shared/enums/ItemEnums";
import { ItemDTO, ItemFilterDTO, LazyState, emptyItem } from "shared/models";
import { ListShow } from "widgets/List";

const ItemsListPage = () => {
  const { search } = useLocation();
  const params = new URLSearchParams(search);  
  const name = params.get('name') || null;
  const itemType = params.get('itemType') || null;
  const itemTypeAsNumber = itemType ? parseInt(itemType, 10) : null;

  const substanceType = params.get('substanceType') || null;
  const substanceTypeAsNumber = substanceType ? parseInt(substanceType, 10) : null;

  const [itemList, setItemList] = useState<ItemDTO[]>([]);
  const [item, setItem] = useState<ItemDTO>(emptyItem);
  const [filter, setFilter] = useState<ItemFilterDTO>({
    name: name,
    substanceType: substanceTypeAsNumber,
    itemType: itemTypeAsNumber,
    
    componentIsAlchemical: itemTypeAsNumber === null ? null : (itemTypeAsNumber === ItemEntityType.ComponentAlc ? true : false),
    itemAvailabilityType: null,
    whereToFind: null,
  } as ItemFilterDTO);

  const toast = useRef<Toast>(null);
  const [lazyState, setLazyState] = useState<LazyState>({
    first: 0,
    rows: 10,
    page: 0,
    totalRecords: 100,
  });

  const getParams = () => {
    const params = {};
    params["first"] = lazyState.first;
    params["page"] = lazyState.page;
    params["pageSize"] = lazyState.rows;
    console.log(filter)

    if (filter) {
      if (filter.name) {
        params["name"] = filter.name;
      }
      if (filter.itemType) {
        //Костыль для того, чтобы не создавать новую таблицу в БД на бэке
        if (filter.itemType === ItemEntityType.ComponentAlc)
        {
          params["itemType"] = ItemEntityType.ComponentRem;
          params["componentIsAlchemical"] = true;
        }
        else if (filter.itemType === ItemEntityType.ComponentRem) {
          params["itemType"] = ItemEntityType.ComponentRem;
          params["componentIsAlchemical"] = false;
        }
        else
          params["itemType"] = filter.itemType;
      }
      if (filter.substanceType) {
        params["substanceType"] = filter.substanceType;
      }
      // if (filter.componentIsAlchemical !== null) {
      //   params["componentIsAlchemical"] = filter.componentIsAlchemical;
      // }
      if (filter.itemAvailabilityType) {
        params["itemAvailabilityType"] = filter.itemAvailabilityType;
      }
      if (filter.whereToFind) {
        params["whereToFind"] = filter.whereToFind;
      }
    }
    
    console.log(params)
    return params;
  };

  return (
    <Card style={{ minHeight: "500px", margin: "0 auto" }}>
      <ListShow
        getParams={getParams}
        lazyState={lazyState}
        entity={item}
        setEntity={setItem}
        entityList={itemList}
        setEntityList={setItemList}
        emptyEntity={emptyItem}
        toast={toast}
        filter={filter}
        setFilter={setFilter}
      ></ListShow>
    </Card>
  );
};

export { ItemsListPage };
