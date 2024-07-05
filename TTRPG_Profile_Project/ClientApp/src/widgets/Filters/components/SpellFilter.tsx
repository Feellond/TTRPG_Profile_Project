import { useDebounce } from "entities/GeneralFunc";
import { IconField } from "primereact/iconfield";
import { InputIcon } from "primereact/inputicon";
import { InputText } from "primereact/inputtext";
import React, { useCallback, useState } from "react";
import { SpellFilterDTO } from "shared/models";

interface SpellFilterProps {
  filter: SpellFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<SpellFilterDTO>>;
}

const SpellFilter = ({ filter, setFilter }: SpellFilterProps) => {
  const [localFilter, setLocalFilter] = useState(filter);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback((newFilter: Partial<SpellFilterDTO>) => {
    const updatedFilter = { ...localFilter, ...newFilter };
    setLocalFilter(updatedFilter);
    debouncedSetFilter(updatedFilter);
  }, [localFilter, debouncedSetFilter]);

  return (
    <div className="flex mb-2 flex-wrap">
      <div className="flex flex-column justify-content-center mr-3 ">
        <IconField iconPosition="left" className="p-input-icon-left">
          <InputIcon className="pi pi-search" />
          <InputText
            className="w-full"
            value={localFilter.name}
            placeholder="Наименование"
            onChange={(e) => handleFilterChange({ ...filter, name: e.target.value })}
          />
        </IconField>
      </div>
    </div>
  );
};

export { SpellFilter };
