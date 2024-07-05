import { ComplexityLoad, RaceLoad } from "entities/BestiaryFunc";
import { useDebounce } from "entities/GeneralFunc";
import { ListInput } from "features/inputs/listInput";
import { IconField } from "primereact/iconfield";
import { InputIcon } from "primereact/inputicon";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import React, { useCallback, useEffect, useState } from "react";
import { CreatureFilterDTO } from "shared/models";

interface BestiaryFilterProps {
  filter: CreatureFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<CreatureFilterDTO>>;
}

const BestiaryFilter = ({ filter, setFilter }: BestiaryFilterProps) => {
  const [complexityOptions, setComplexityOptions] = useState<SelectItem[]>([]);
  const [raceOptions, setRaceOptions] = useState<SelectItem[]>([]);

  const [localFilter, setLocalFilter] = useState(filter);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback((newFilter: Partial<CreatureFilterDTO>) => {
    const updatedFilter = { ...localFilter, ...newFilter };
    setLocalFilter(updatedFilter);
    debouncedSetFilter(updatedFilter);
  }, [localFilter, debouncedSetFilter]);

  useEffect(() => {
    ComplexityLoad({ setItems: setComplexityOptions });
    RaceLoad({ setItems: setRaceOptions });
  }, []);

  return (
    <div className="w-full flex mb-2 flex-wrap">
      <div className="flex flex-column justify-content-center mr-3">
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
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="complexity"
          placeholder="Сложность"
          value={localFilter.complexity}
          data={complexityOptions}
          onChange={(e) => handleFilterChange({ ...filter, complexity: e.value })}
        />
      </div>
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="race"
          placeholder="Раса"
          value={localFilter.race}
          data={raceOptions}
          onChange={(e) => handleFilterChange({ ...filter, race: e.value })}
        />
      </div>
    </div>
  );
};

export { BestiaryFilter };
