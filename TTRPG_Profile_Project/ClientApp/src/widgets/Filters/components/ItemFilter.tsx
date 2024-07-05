import React, { useEffect, useState, useCallback } from "react";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import { ListInput } from "features/inputs/listInput";
import { Button } from 'primereact/button';
import { ItemEntityTypeLoad } from "entities/ItemFunc";
import { ItemFilterDTO } from "shared/models";
import { IconField } from 'primereact/iconfield';
import { InputIcon } from 'primereact/inputicon';
import { useDebounce } from "entities/GeneralFunc";

interface ItemFilterProps {
  filter: ItemFilterDTO,
  setFilter: React.Dispatch<React.SetStateAction<ItemFilterDTO>>
}

const ItemFilter = ({filter, setFilter} : ItemFilterProps) => {
  const [itemTypeOptions, setItemTypeOptions] = useState<SelectItem[]>([]);
  const [localFilter, setLocalFilter] = useState(filter);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback((newFilter: Partial<ItemFilterDTO>) => {
    const updatedFilter = { ...localFilter, ...newFilter };
    setLocalFilter(updatedFilter);
    debouncedSetFilter(updatedFilter);
  }, [localFilter, debouncedSetFilter]);

  useEffect(() => {
    ItemEntityTypeLoad({setItems: setItemTypeOptions});
  }, []);

  return ( 
    <div className="flex mb-2 flex-wrap">
      <div className="flex flex-column justify-content-center mr-3">
        <IconField iconPosition="left" className="p-input-icon-left">
          <InputIcon className="pi pi-search"/>
          <InputText
            className="w-full"
            value={localFilter.name}
            placeholder="Наименование"
            onChange={(e) => handleFilterChange({ name: e.target.value })}
          />
        </IconField>
      </div>
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="itemType"
          placeholder="Тип предмета"
          value={localFilter.itemType}
          data={itemTypeOptions}
          onChange={(e) => handleFilterChange({ itemType: e.value })}
        />
      </div>
      <div className="flex flex-column justify-content-center">
        <Button aria-label="Bookmark" icon="pi pi-cog" severity="secondary"/>
      </div>
    </div>
  );
};

export { ItemFilter };