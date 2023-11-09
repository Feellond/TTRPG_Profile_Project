import React from "react";
import { Control, FieldValues, UseFormRegister } from "react-hook-form";

interface ItemTypeSelectProps {
  itemType: number;
  visible: boolean;
  register: UseFormRegister<FieldValues>;
  control: Control<FieldValues, any>;
}

const ItemTypeSelect = ({
  itemType,
  visible,
  register,
  control,
}: ItemTypeSelectProps) => {
  let content = null;

  const WeaponItem = () => {
    return (
        <div>
            <div>
                isAmmunition
            </div>
            <div>
                accuracy
            </div>
            <div>
                damage
            </div>
            <div>
                reliability
            </div>
            <div>
                grip
            </div>
            <div>
                distance
            </div>
            <div>
                StealhType
            </div>
            <div>
                amountOfEnhancements
            </div>
            <div>
                skillId
            </div>
        </div>
    );
  };

  const ArmorItem = () => {
    return (
        <div>
            <div>
                reliability
            </div>
            <div>
                amountOfEnhancements
            </div>
            <div>
                stiffness
            </div>
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
            <div>
                type
            </div>
        </div>
    );
  };

  const FormulaItem = () => {
    return (
        <div>
            <div>
                complexity
            </div>
            <div>
                timeSpend
            </div>
            <div>
                additionalPayment
            </div>
            <div>
                formulaComponentLists
            </div>
        </div>
    );
  };

  const BlueprintItem = () => {
    return (
        <div>
            <div>
                complexity
            </div>
            <div>
                timeSpend
            </div>
            <div>
                additionalPayment
            </div>
            <div>
                blueprintComponentLists
            </div>
        </div>
    );
  };

  const ComponentItem = () => {
    return (
        <div>
            <div>
                whereToFind
            </div>
            <div>
                amount
            </div>
            <div>
                complexity
            </div>
            <div>
                isAlchemical
            </div>
            <div>
                substanceType
            </div>
            <div>
                formulaComponentLists
            </div>
            <div>
                blueprintComponentLists
            </div>
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
