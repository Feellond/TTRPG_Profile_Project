import { Card } from "primereact/card";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import { CreatureFilterDTO, emptyCreature, ICreature, LazyState } from "shared/models";

import { ListShow } from "widgets/List";

const BestiaryListPage = () => {
    const [creatureList, setCreatureList] = useState<ICreature[]>([]);
    const [creature, setCreature] = useState<ICreature>(emptyCreature);
    const [filter, setFilter] = useState<CreatureFilterDTO>({} as CreatureFilterDTO);
    
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
        <Card style={{minHeight: '500px', width: '1500px', margin: '0 auto' }} >
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
    )
}

export {BestiaryListPage}