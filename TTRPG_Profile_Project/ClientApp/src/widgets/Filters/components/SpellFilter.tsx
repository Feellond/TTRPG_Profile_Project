import { InputText } from "primereact/inputtext";
import React from "react";
import { SpellFilterDTO } from "shared/models";

interface SpellFilterProps {
  filter: SpellFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<SpellFilterDTO>>;
}

const SpellFilter = ({ filter, setFilter }: SpellFilterProps) => {
  return (
    <div className="flex mb-2 flex-wrap">
      <div className="flex flex-column justify-content-center mr-3 ">
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
    </div>
  );
};

export { SpellFilter };
