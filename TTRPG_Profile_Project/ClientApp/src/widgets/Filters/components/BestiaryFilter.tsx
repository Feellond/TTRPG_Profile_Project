import { ComplexityLoad } from "entities/BestiaryFunc";
import { ListInput } from "features/inputs/listInput";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import React, { useEffect, useState } from "react";
import { CreatureFilterDTO } from "shared/models";

interface BestiaryFilterProps {
    filter: CreatureFilterDTO,
    setFilter: React.Dispatch<React.SetStateAction<CreatureFilterDTO>>
  }

const BestiaryFilter = ({filter, setFilter}: BestiaryFilterProps) => {
  const [complexityOptions, setComplexityOptions] = useState<SelectItem[]>([]);

  useEffect(() => {
    ComplexityLoad({setItems: setComplexityOptions})
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
          id="complexity"
          placeholder="Сложность"
          value={filter.complexity}
          data={complexityOptions}
          onChange={(e) => setFilter({ ...filter, complexity: e.value })}
        />
      </div>
      </div>
    );
}

export {BestiaryFilter}