import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import React, { useEffect, useState } from "react";
import {
  Control,
  Controller,
  FieldValues,
  UseFormGetValues,
} from "react-hook-form";
import { ICreature, ISkillsList, IStatsList } from "shared/models";
//import { ICreature } from "shared/models";

interface IShowBase {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;

  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  isEditMode: boolean;
}

export const ShowBases = ({ statList, skillsList, data, control, getValues, isEditMode }: IShowBase) => {
  const [blockBase, setBlockBase] = useState<number>(null);
  const [evasionBase, setEvasionBase] = useState<number>(null);
  const [athleticsBase, setAthleticsBase] = useState<number>(null);
  const [spellResistBase, setSpellResistBase] = useState<number>(null);

  const fetchData = () => {
    let values = getValues();
    setBlockBase(values.blockBase);
    setEvasionBase(values.evasionBase);
    setAthleticsBase(values.athleticsBase);
    setSpellResistBase(values.spellResistBase);
  };

  useEffect(() => {
    fetchData();
  }, [data, statList, skillsList]);

  /*
  tooltip={
                      "Текущее значение: " +
                      String(getValues("statsList.intellectValue")) +
                      " + " +
                      String(getValues("skillsList.educationValue")) +
                      " = " +
                      String(
                        getValues("statsList.intellectValue") +
                          getValues("skillsList.educationValue")
                      )
                    }
  */
  return (
    <div className="my-2 baseList">
      <div className="flex">
        <span>База блока: </span>
        {isEditMode ? (
          <div>
            <Controller
              name="blockBase"
              control={control}
              render={({ field }) => (
                <>
                  <InputNumber
                    id={field.name}
                    value={field.value}
                    onValueChange={(e: InputNumberValueChangeEvent) => {
                      field.onChange(e.value);
                    }}
                    minFractionDigits={0}
                    maxFractionDigits={0}
                    min={0}
                    max={9999}
                    tooltip={
                      "Текущее значение: " +
                      String(getValues("statsList.reactionValue")) +
                      "(Реакция) + (макс. боевой навык)"
                    }
                  />
                </>
              )}
            />
          </div>
        ) : (
          <div className="ml-1">{blockBase}</div>
        )}
      </div>
      <div className="flex">
        <span>База уклонения: </span>
        {isEditMode ? (
          <div>
            <Controller
              name="evasionBase"
              control={control}
              render={({ field }) => (
                <>
                  <InputNumber
                    id={field.name}
                    value={field.value}
                    onValueChange={(e: InputNumberValueChangeEvent) => {
                      field.onChange(e.value);
                    }}
                    minFractionDigits={0}
                    maxFractionDigits={0}
                    min={0}
                    max={9999}
                    tooltip={
                      "Текущее значение: " +
                      String(getValues("statsList.reactionValue")) +
                      "(Реакция) + " +
                      String(getValues("skillsList.evasionValue")) +
                      "(Уклонение) = " +
                      String(
                        getValues("statsList.reactionValue") +
                          getValues("skillsList.evasionValue")
                      )
                    }
                  />
                </>
              )}
            />
          </div>
        ) : (
          <div className="ml-1">{evasionBase}</div>
        )}
      </div>
      <div className="flex">
        <span>База атлетики: </span>
        {isEditMode ? (
          <div>
            <Controller
              name="athleticsBase"
              control={control}
              render={({ field }) => (
                <>
                  <InputNumber
                    id={field.name}
                    value={field.value}
                    onValueChange={(e: InputNumberValueChangeEvent) => {
                      field.onChange(e.value);
                    }}
                    minFractionDigits={0}
                    maxFractionDigits={0}
                    min={0}
                    max={9999}
                    tooltip={
                      "Текущее значение: " +
                      String(getValues("statsList.dexterityValue")) +
                      "(Ловкость) + " +
                      String(getValues("skillsList.athleticsValue")) +
                      "(Атлетика) = " +
                      String(
                        getValues("statsList.dexterityValue") +
                          getValues("skillsList.athleticsValue")
                      )
                    }
                  />
                </>
              )}
            />
          </div>
        ) : (
          <div className="ml-1">{athleticsBase}</div>
        )}
      </div>
      <div className="flex">
        <span>База сопротивления магии: </span>
        {isEditMode ? (
          <div>
            <Controller
              name="spellResistBase"
              control={control}
              render={({ field }) => (
                <>
                  <InputNumber
                    id={field.name}
                    value={field.value}
                    onValueChange={(e: InputNumberValueChangeEvent) => {
                      field.onChange(e.value);
                    }}
                    minFractionDigits={0}
                    maxFractionDigits={0}
                    min={0}
                    max={9999}
                    tooltip={
                      "Текущее значение: " +
                      String(getValues("statsList.willpowerValue")) +
                      "(Воля) + " +
                      String(getValues("skillsList.magicResistanceValue")) +
                      "(Сопротивление заклинаниям) = " +
                      String(
                        getValues("statsList.willValue") +
                          getValues("skillsList.magicResistanceValue")
                      )
                    }
                  />
                </>
              )}
            />
          </div>
        ) : (
          <div className="ml-1">{spellResistBase}</div>
        )}
      </div>
    </div>
  );
};
