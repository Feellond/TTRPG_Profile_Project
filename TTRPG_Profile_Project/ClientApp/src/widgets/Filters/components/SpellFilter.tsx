import { useDebounce } from "entities/GeneralFunc";
import { SpellLevelOptionsLoad, SpellSourceTypeOptionsLoad, SpellTypeOptionsLoad } from "entities/SpellFunc";
import { ListInput } from "features/inputs/listInput";
import { IconField } from "primereact/iconfield";
import { InputIcon } from "primereact/inputicon";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import React, { useCallback, useEffect, useState } from "react";
import { SpellFilterDTO } from "shared/models";

interface SpellFilterProps {
  filter: SpellFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<SpellFilterDTO>>;
}

const SpellFilter = ({ filter, setFilter }: SpellFilterProps) => {
  const [localFilter, setLocalFilter] = useState(filter);
  const [spellLevelOptions, setSpellLevelOptions] = useState<SelectItem[]>([]);
  const [spellTypeOptions, setSpellTypeOptions] = useState<SelectItem[]>([]);
  const [spellSourceTypeOptions, setSpellSourceTypeOptions] = useState<SelectItem[]>([]);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback((newFilter: Partial<SpellFilterDTO>) => {
    const updatedFilter = { ...localFilter, ...newFilter };
    setLocalFilter(updatedFilter);
    debouncedSetFilter(updatedFilter);
  }, [localFilter, debouncedSetFilter]);

  useEffect(() => {
    SpellLevelOptionsLoad({setItems: setSpellLevelOptions});
    SpellTypeOptionsLoad({setItems: setSpellTypeOptions});
    SpellSourceTypeOptionsLoad({setItems: setSpellSourceTypeOptions});
  }, [])

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
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="spellLevel"
          placeholder="Уровень"
          value={localFilter.spellLevel}
          data={spellLevelOptions}
          onChange={(e) =>
            handleFilterChange({ spellLevel: e.value })
          }
        />
      </div>
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="spellType"
          placeholder="Сложность"
          value={localFilter.spellType}
          data={spellTypeOptions}
          onChange={(e) =>
            handleFilterChange({ spellType: e.value })
          }
        />
      </div>
      <div className="flex flex-column justify-content-center mr-3">
        <ListInput
          id="sourceType"
          placeholder="Источник заклинания"
          value={localFilter.sourceType}
          data={spellSourceTypeOptions}
          onChange={(e) =>
            handleFilterChange({ sourceType: e.value })
          }
        />
      </div>
    </div>
  );
};

export { SpellFilter };
