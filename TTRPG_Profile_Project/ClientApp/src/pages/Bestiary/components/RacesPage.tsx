import { Card } from "primereact/card";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import {
  emptyRace,
  IClass,
  IRace,
  LazyState,
  RaceFilterDTO,
} from "shared/models";
import { ListShow } from "widgets/List";

const RacesPage = () => {
  const [raceList, setRaceList] = useState<IClass[]>([]);
  const [race, setRace] = useState<IRace>(emptyRace);
  const [filter, setFilter] = useState<RaceFilterDTO>({
    name: "",
  } as RaceFilterDTO);

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
    }

    console.log(params);
    return params;
  };

  return (
    <Card style={{ minHeight: "500px", width: "1500px", margin: "0 auto" }}>
      <ListShow
        getParams={getParams}
        lazyState={lazyState}
        entity={race}
        setEntity={setRace}
        entityList={raceList}
        setEntityList={setRaceList}
        emptyEntity={emptyRace}
        toast={toast}
        filter={filter}
        setFilter={setFilter}
      />
    </Card>
  );
};

export { RacesPage };
