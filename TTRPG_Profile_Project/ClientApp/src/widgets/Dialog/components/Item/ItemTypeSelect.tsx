import React, { useState } from "react";
import { Control, FieldValues, UseFormRegister } from "react-hook-form";
import { Checkbox } from "primereact/checkbox";
import { InputMask } from "primereact/inputmask";
import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import { ItemDTO } from "shared/models";

interface ItemTypeSelectProps {
  data: ItemDTO;
  itemType: number;
  visible: boolean;
  register: UseFormRegister<FieldValues>;
  control: Control<FieldValues, any>;
}

const ItemTypeSelect = ({
  data,
  itemType,
  visible,
  register,
  control,
}: ItemTypeSelectProps) => {
  const [isAmmunitionChecked, setIsAmmunitionChecked] =
    useState<boolean>(false);

  let content = null;

  const WeaponItem = () => {
    return (
      <div className="card flex justify-content-center">
        <div className="flex align-items-center">
          <Checkbox
            inputId="ingredient1"
            onChange={(e) => setIsAmmunitionChecked(e.checked)}
            checked={isAmmunitionChecked}
          />
          <label className="ml-2">Боеприпас?</label>
        </div>
        <span className="p-float-label">
          <InputMask
            id="serial"
            mask="+99"
            placeholder="+99"
            value={String(data.accuracy)}
          />
          <label>Точность</label>
        </span>
        <span className="p-float-label">
          <InputMask
            id="serial"
            mask="9к9+9"
            placeholder="2к4+2"
            value={data.damage}
          />
          <label>Урон</label>
        </span>
        <span className="p-float-label">
          <InputNumber
            id="number-input"
            value={data.reliability}
            min={0}
            max={999}
          />
          <label>Надежность</label>
        </span>
        <span className="p-float-label">
          <InputNumber id="number-input" value={data.grip} min={0} max={4} />
          <label>Хват</label>
        </span>
        <span className="p-float-label">
          <InputMask
            id="serial"
            mask="999м."
            placeholder="20м."
            value={String(data.distance)}
          ></InputMask>
          <label>Дистанция</label>
        </span>
        <div>StealhType</div>
        <span className="p-float-label">
          <InputMask
            id="serial"
            mask="9"
            placeholder="0"
            value={String(data.amountOfEnhancements)}
          ></InputMask>
          <label>Количество улучшений</label>
        </span>
        <div>skillId</div>
      </div>
    );
  };

  const ArmorItem = () => {
    return (
      <div>
        <div>reliability</div>
        <div>amountOfEnhancements</div>
        <div>stiffness</div>
      </div>
    );
  };

  const ToolItem = () => {
    return <div></div>;
  };

  const AlchemicalItem = () => {
    return <div></div>;
  };

  const BaseItem = () => {
    return (
      <div>
        <div>type</div>
      </div>
    );
  };

  const FormulaItem = () => {
    return (
      <div>
        <div>complexity</div>
        <div>timeSpend</div>
        <div>additionalPayment</div>
        <div>formulaComponentLists</div>
      </div>
    );
  };

  const BlueprintItem = () => {
    return (
      <div>
        <div>complexity</div>
        <div>timeSpend</div>
        <div>additionalPayment</div>
        <div>blueprintComponentLists</div>
      </div>
    );
  };

  const ComponentItem = () => {
    return (
      <div>
        <div>whereToFind</div>
        <div>amount</div>
        <div>complexity</div>
        <div>isAlchemical</div>
        <div>substanceType</div>
        <div>formulaComponentLists</div>
        <div>blueprintComponentLists</div>
      </div>
    );
  };

  switch (itemType) {
    case 1:
      content = BaseItem();
      break;
    case 2:
      content = ToolItem();
      break;
    case 3:
      content = AlchemicalItem();
      break;
    case 4:
      content = ArmorItem();
      break;
    case 5:
      content = WeaponItem();
      break;
    case 6:
      content = FormulaItem();
      break;
    case 7:
      content = BlueprintItem();
      break;
    case 8:
      content = ComponentItem();
      break;
    default:
      content = <div>Неизвестный тип контента</div>;
  }

  return (
    <div style={{ visibility: visible ? "visible" : "hidden" }}>{content}</div>
  );
};

export { ItemTypeSelect };
