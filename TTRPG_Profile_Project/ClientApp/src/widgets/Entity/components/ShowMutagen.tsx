import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import React, { useEffect, useState } from "react";
import {
  Control,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
} from "react-hook-form";
import { ICreature, IMutagen, ISkillsList, IStatsList } from "shared/models";

interface IShowMutagen {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowMutagen = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  register,
  isEditMode,
}: IShowMutagen) => {
  const [mutagen, setMutagen] = useState<IMutagen>(null);

  const fetchData = () => {
    let values = getValues();

    setMutagen(values.mutagen);

    if (mutagen){
      if (mutagen.id === 0 || mutagen.name === "")
        setMutagen(null);
    }
  };

  useEffect(() => {
    fetchData();
  }, [data, control, statList, skillsList, isEditMode]);

  useEffect(() => {
    register("mutagen", { value: mutagen });
  }, [mutagen]);

  return (
    <div>
      {mutagen ? (
        <div>
          <span>Мутаген:</span>
          <div className="flex">
            <div>
              <span>СЛ:</span>
              {isEditMode ? (
                <div>
                  <InputNumber
                    value={mutagen.complexity}
                    onValueChange={(e: InputNumberValueChangeEvent) => {
                      mutagen.complexity = e.value; //Не уверен, что работает
                    }}
                    minFractionDigits={0}
                    maxFractionDigits={0}
                    min={0}
                    max={9999}
                  />
                </div>
              ) : (
                <div className="ml-1">{mutagen.complexity}</div>
              )}
            </div>
            <div>
              <span>Эффект</span>
              {isEditMode ? (
                <div>
                  <InputText
                    value={mutagen.effect}
                    onChange={(e) => {
                      mutagen.effect = e.target.value; //Не уверен, что работает
                    }}
                  />
                </div>
              ) : (
                <div className="ml-1">{mutagen.effect}</div>
              )}
            </div>
            <div>
              <span>Малая мутация</span>
              {isEditMode ? (
                <div>
                  <InputTextarea
                    autoResize
                    value={mutagen.mutation}
                    onChange={(e) => {
                      mutagen.mutation = e.target.value; //Не уверен, что работает
                    }}
                    rows={5}
                    cols={30}
                  />
                </div>
              ) : (
                <div className="ml-1">{mutagen.mutation}</div>
              )}
            </div>
            {isEditMode ? (<div>
              <button type="button" onClick={() => {
                setMutagen(null);
              }}>
                Убрать мутаген
              </button>
            </div>) : ""}
          </div>
        </div>
      ) : (
        <div></div>
      )}
      {!mutagen && isEditMode ? (
        <div>
          <button
            onClick={(e) => {
              e.preventDefault();
              setMutagen({
                id: 0,
                complexity: 0,
                description: "",
                effect: "",
                mutation: "",
                name: "",
                source: null,
              });
            }}
          >
            Добавить мутаген
          </button>
        </div>
      ) : (
        ""
      )}
    </div>
  );
};
