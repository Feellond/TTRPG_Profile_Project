import { ComplexityLoad, RaceLoad } from "entities/BestiaryFunc";
import { ListInput } from "features/inputs/listInput";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import React, { useEffect, useState } from "react";
import { CreatureFilterDTO } from "shared/models";

interface BestiaryFilterProps {
  filter: CreatureFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<CreatureFilterDTO>>;
}

const BestiaryFilter = ({ filter, setFilter }: BestiaryFilterProps) => {
  const [complexityOptions, setComplexityOptions] = useState<SelectItem[]>([]);
  const [raceOptions, setRaceOptions] = useState<SelectItem[]>([]);

  useEffect(() => {
    ComplexityLoad({ setItems: setComplexityOptions });
    RaceLoad({setItems: setRaceOptions});
  }, []);

  return (
    <div className="w-full flex mb-2 flex-wrap">
      <div className="flex flex-column justify-content-center mr-3">
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
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="complexity"
          placeholder="Сложность"
          value={filter.complexity}
          data={complexityOptions}
          onChange={(e) => setFilter({ ...filter, complexity: e.value })}
        />
      </div>
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="race"
          placeholder="Раса"
          value={filter.race}
          data={raceOptions}
          onChange={(e) => setFilter({ ...filter, race: e.value })}
        />
      </div>
    </div>
  );
};

export { BestiaryFilter };
