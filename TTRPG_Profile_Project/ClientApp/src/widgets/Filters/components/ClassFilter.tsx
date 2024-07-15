import { useDebounce } from "entities/GeneralFunc";
import { IconField } from "primereact/iconfield";
import { InputIcon } from "primereact/inputicon";
import { InputText } from "primereact/inputtext";
import React, { useCallback, useState } from "react";
import { ClassFilterDTO } from "shared/models";

interface ClassFilterProps {
  filter: ClassFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<ClassFilterDTO>>;
}

export const ClassFilter = ({ filter, setFilter }: ClassFilterProps) => {
  const [localFilter, setLocalFilter] = useState(filter);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback(
    (newFilter: Partial<ClassFilterDTO>) => {
      const updatedFilter = { ...localFilter, ...newFilter };
      setLocalFilter(updatedFilter);
      debouncedSetFilter(updatedFilter);
    },
    [localFilter, debouncedSetFilter]
  );

  return (
    <div className="w-full flex mb-2 flex-wrap">
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
    </div>
  );
};
