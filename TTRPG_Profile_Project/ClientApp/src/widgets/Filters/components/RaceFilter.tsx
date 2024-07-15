import { useDebounce } from "entities/GeneralFunc";
import { Checkbox } from "primereact/checkbox";
import { IconField } from "primereact/iconfield";
import { InputIcon } from "primereact/inputicon";
import { InputText } from "primereact/inputtext";
import React, { useCallback, useState } from "react";
import { RaceFilterDTO } from "shared/models";

interface RaceFilterProps {
  filter: RaceFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<RaceFilterDTO>>;
}

export const RaceFilter = ({ filter, setFilter }: RaceFilterProps) => {
  const [localFilter, setLocalFilter] = useState(filter);
  const [onlyPlayable, setOnlyPlayable] = useState<boolean>(null);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback((newFilter: Partial<RaceFilterDTO>) => {
    const updatedFilter = { ...localFilter, ...newFilter };
    setLocalFilter(updatedFilter);
    debouncedSetFilter(updatedFilter);
  }, [localFilter, debouncedSetFilter]);

  return (
    <div className="w-full flex mb-2 flex-wrap align-items-center">
      <div className="flex flex-column justify-content-center mr-3">
        <IconField iconPosition="left" className="p-input-icon-left">
          <InputIcon className="pi pi-search" />
          <InputText
            className="w-full"
            value={localFilter.name}
            placeholder="Наименование"
            onChange={(e) =>
              handleFilterChange({ ...filter, name: e.target.value })
            }
          />
        </IconField>
      </div>
      <div className="flex flex-wrap justify-content-center mr-3">
        <Checkbox
            checked={onlyPlayable}
            onChange={(e) => {
                setOnlyPlayable(e.checked);
                handleFilterChange({ ...filter, onlyPlayable: e.checked })
            }}
        />
        <span className="ml-1">Только игровые</span>
      </div>
    </div>
  );
};

