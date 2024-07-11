import { Card } from "primereact/card";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import { useLocation } from "react-router-dom";
import { emptySpell, ISpell, LazyState, SpellFilterDTO } from "shared/models";
import { ListShow } from "widgets/List";

const SpellsListPage = () => {
  const { search } = useLocation();
  const params = new URLSearchParams(search);  
  const name = params.get('name') || null;

  const [itemList, setItemList] = useState<ISpell[]>([]);
  const [item, setItem] = useState<ISpell>(emptySpell);
  const [filter, setFilter] = useState<SpellFilterDTO>({
    name: name,
    spellLevel: null,
    spellType: null,
    sourceType: null,
  } as SpellFilterDTO);

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
      if (filter.spellLevel) {
        params["spellLevel"] = filter.spellLevel;
      }
      if (filter.spellLevel) {
        params["spellLevel"] = filter.spellLevel;
      }
      if (filter.spellType) {
        params["spellType"] = filter.spellType;
      }
      if (filter.sourceType) {
        params["sourceType"] = filter.sourceType;
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
        emptyEntity={emptySpell}
        toast={toast}
        filter={filter}
        setFilter={setFilter}
      ></ListShow>
    </Card>
  );
};

export { SpellsListPage };
