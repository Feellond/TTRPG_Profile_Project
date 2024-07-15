import React, { useEffect, useState, useCallback } from "react";
import { InputText } from "primereact/inputtext";
import { SelectItem } from "primereact/selectitem";
import { ListInput } from "features/inputs/listInput";
import {
  AvailabilityTypeLoad,
  ItemEntityTypeLoad,
  SubstanceTypeLoad,
} from "entities/ItemFunc";
import { ItemFilterDTO } from "shared/models";
import { IconField } from "primereact/iconfield";
import { InputIcon } from "primereact/inputicon";
import { useDebounce } from "entities/GeneralFunc";
import { ItemEntityType } from "shared/enums/ItemEnums";

import "react-range-slider-input/dist/style.css";
import { InputNumber } from "primereact/inputnumber";
import { Button } from "primereact/button";

interface ItemFilterProps {
  filter: ItemFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<ItemFilterDTO>>;
}

const ItemFilter = ({ filter, setFilter }: ItemFilterProps) => {
  const [localFilter, setLocalFilter] = useState(filter);
  const [moreFilters, setMoreFilters] = useState<boolean>(false);

  const [substanceType, setSubstanceType] = useState<SelectItem[]>([]);
  const [itemTypeOptions, setItemTypeOptions] = useState<SelectItem[]>([]);
  const [itemAvailabilityType, setItemAvailabilityType] = useState<
    SelectItem[]
  >([]);
  const [costValue, setCostValue] = useState<number[]>([0, 99999]);

  const debouncedSetFilter = useDebounce(setFilter, 300);

  const handleFilterChange = useCallback(
    (newFilter: Partial<ItemFilterDTO>) => {
      const updatedFilter = { ...localFilter, ...newFilter };
      setLocalFilter(updatedFilter);
      debouncedSetFilter(updatedFilter);
    },
    [localFilter, debouncedSetFilter]
  );

  const handleCostInputChange = (index: number, value: number) => {
    const newCostValue = [...costValue];
    newCostValue[index] = value;
    setCostValue(newCostValue);
  };

  useEffect(() => {
    ItemEntityTypeLoad({ setItems: setItemTypeOptions });
    SubstanceTypeLoad({ setItems: setSubstanceType });
    AvailabilityTypeLoad({ setItems: setItemAvailabilityType });
  }, []);

  useEffect(() => {
    if (!moreFilters)
      setCostValue([0, 99999])
  }, [moreFilters])

  useEffect(() => {
    handleFilterChange({priceRange: costValue});
  }, [costValue])

  return (
    <div className="flex mb-2 flex-wrap align-items-center">
      <div className="flex flex-column justify-content-center mr-3 mb-2">
        <IconField iconPosition="left" className="p-input-icon-left">
          <InputIcon className="pi pi-search" />
          <InputText
            className="w-full"
            value={localFilter.name}
            placeholder="Наименование"
            onChange={(e) => handleFilterChange({ name: e.target.value })}
          />
        </IconField>
      </div>
      <div className="flex flex-column justify-content-center mr-3 mb-2">
        <ListInput
          id="itemType"
          placeholder="Тип предмета"
          value={localFilter.itemType}
          data={itemTypeOptions}
          onChange={(e) => handleFilterChange({ itemType: e.value })}
        />
      </div>
      {localFilter.itemType === ItemEntityType.ComponentAlc ? (
        <div className="flex flex-column justify-content-center mr-3 mb-2">
          <ListInput
            id="substanceType"
            placeholder="Тип компонента"
            value={localFilter.substanceType}
            data={substanceType}
            onChange={(e) => handleFilterChange({ substanceType: e.value })}
          />
        </div>
      ) : (
        (localFilter.substanceType = null)
      )}
      <div className="flex flex-column justify-content-center mr-3 mb-2">
        <ListInput
          id="itemAvailabilityType"
          placeholder="Сложность"
          value={localFilter.itemAvailabilityType}
          data={itemAvailabilityType}
          onChange={(e) =>
            handleFilterChange({ itemAvailabilityType: e.value })
          }
        />
      </div>
      <div className="flex flex-column justify-content-center mr-3 mb-2">
        <InputText
          className="w-full"
          value={localFilter.whereToFind}
          placeholder="Где найти?"
          onChange={(e) => handleFilterChange({ whereToFind: e.target.value })}
        />
      </div>
      {moreFilters ? (
        <div className="flex flex-wrap justify-content-center mr-3 my-2 rangeSlider align-items-center">
          <span>Цена от: </span>
          <InputNumber
            value={costValue[0]}
            onChange={(e) => handleCostInputChange(0, e.value)}
          />
          <span className="ml-1">до: </span>
          <InputNumber
            value={costValue[1]}
            onChange={(e) => handleCostInputChange(1, e.value)}
          />
        </div>
      ) : (
        ""
      )}
      <div className="flex flex-column justify-content-center">
        <Button
          aria-label="Bookmark"
          icon={moreFilters ? "pi pi-angle-left" : "pi pi-cog"}
          severity="secondary"
          onClick={(e) => {
            setMoreFilters(!moreFilters);
          }}
        />
      </div>
    </div>
  );
};

export { ItemFilter };
