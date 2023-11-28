import React, { useEffect, useState } from "react";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import { ItemDTO } from "shared/models/Item/DTO/ItemsDTO";
import { ListInput } from "features/inputs/listInput";
import { Button } from 'primereact/button';
import { ItemEntityTypeLoad } from "entities/ItemFunc";

const ItemFilter = () => {
  const [filter, setFilter] = useState<ItemDTO>({} as ItemDTO);
  const [itemTypeOptions, setItemTypeOptions] = useState<SelectItem[]>([]);

  useEffect(() => {
    ItemEntityTypeLoad({setItems: setItemTypeOptions});
  }, [])

  return ( 
    <div className="grid">
      <div className="flex flex-column justify-content-center col-4">
        <span className="p-input-icon-left">
          <i className="pi pi-search" />
          <InputText
            className="w-full"
            value={filter.name}
            placeholder="Наименование"
            onChange={(e) => setFilter({ ...filter, name: e.target.value })}
          />
        </span>
      </div>
      <div className="flex flex-column justify-content-center col-4">
        <ListInput
          id="itemType"
          placeholder="Тип предмета"
          value={filter.itemType}
          data={itemTypeOptions}
          onChange={(e) => setFilter({ ...filter, itemType: e.value })}
        />
      </div>
      <div className="flex flex-column justify-content-center">
        <Button aria-label="Bookmark" icon="pi pi-cog" severity="secondary"/>
      </div>
    </div>
  );
};

export { ItemFilter };
