import { Card } from "primereact/card";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import { useLocation } from "react-router-dom";
import { ClassFilterDTO, emptyClass, IClass, LazyState } from "shared/models";
import { ListShow } from "widgets/List";

const ClassesPage = () => {
  const { search } = useLocation();
  const params = new URLSearchParams(search);  
  const name = params.get('name') || null;

  const [classesList, setClassesList] = useState<IClass[]>([]);
  const [singleClass, setSingleClass] = useState<IClass>(emptyClass);
  const [filter, setFilter] = useState<ClassFilterDTO>({
    name: name,
    classSkill: "",
  } as ClassFilterDTO);

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
    <Card style={{ minHeight: "500px", margin: "0 auto" }}>
      <ListShow
        getParams={getParams}
        lazyState={lazyState}
        entity={singleClass}
        setEntity={setSingleClass}
        entityList={classesList}
        setEntityList={setClassesList}
        emptyEntity={emptyClass}
        toast={toast}
        filter={filter}
        setFilter={setFilter}
      />
    </Card>
  );
};

export { ClassesPage };
