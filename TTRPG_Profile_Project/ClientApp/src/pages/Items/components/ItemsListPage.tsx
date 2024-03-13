import { Card } from "primereact/card";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import { ItemDTO, ItemFilterDTO, LazyState, emptyItem } from "shared/models";
import { ListShow } from "widgets/List";

const ItemsListPage = () => {
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
        toast={toast}
        filter={filter}
        setFilter={setFilter}
      ></ListShow>
    </Card>
  );
};

export { ItemsListPage };
