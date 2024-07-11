import { RaceLoad } from "entities/BestiaryFunc";
import { Card } from "primereact/card";
import { SelectItem } from "primereact/selectitem";
import { Toast } from "primereact/toast";
import React, { useEffect, useRef, useState } from "react";
import { useLocation} from "react-router-dom";
import {
  CreatureFilterDTO,
  emptyCreature,
  ICreature,
  LazyState,
} from "shared/models";

import { ListShow } from "widgets/List";

const BestiaryListPage = () => {
  const { search } = useLocation();
  const params = new URLSearchParams(search);  
  const name = params.get('name') || null;

  const [creatureList, setCreatureList] = useState<ICreature[]>([]);
  const [creature, setCreature] = useState<ICreature>(emptyCreature);
  const [filter, setFilter] = useState<CreatureFilterDTO>({
    name: name,
    race: null,
  } as CreatureFilterDTO);

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
      if (filter.complexity) {
        params["complexity"] = filter.complexity;
      }
      if (filter.race) {
        params["race"] = filter.race.name;
      }
    }

    console.log("params: ", params);
    return params;
  };

  return (
    <Card style={{ margin: "0 auto" }}>
      <ListShow
        getParams={getParams}
        lazyState={lazyState}
        entity={creature}
        setEntity={setCreature}
        entityList={creatureList}
        setEntityList={setCreatureList}
        emptyEntity={emptyCreature}
        toast={toast}
        filter={filter}
        setFilter={setFilter}
      />
    </Card>
  );
};

export { BestiaryListPage };
