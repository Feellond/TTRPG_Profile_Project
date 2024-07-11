import { Button } from "primereact/button";
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
  UseFormSetValue,
} from "react-hook-form";
import { ICreature, IMutagen, ISkillsList, IStatsList } from "shared/models";

interface IShowMutagen {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  setValue: UseFormSetValue<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowMutagen = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  setValue,
  register,
  isEditMode,
}: IShowMutagen) => {
  const [mutagen, setMutagen] = useState<IMutagen>(null);

  const fetchData = () => {
    let values = getValues();

    setMutagen(values.mutagen);

    if (mutagen){
      if (mutagen.id === 0)
        setMutagen(null);
    }
  };

  useEffect(() => {
    fetchData();
  }, [data, control, statList, skillsList, isEditMode]);

  useEffect(() => {
    setValue("mutagen", mutagen);
  }, [mutagen]);

  return (
    <div className="p-2">
      {mutagen ? (
        <div className="showInfo">
          <span className="showInfo__name">Мутаген:</span>
          <div className="flex flex-wrap">
            <div className="flex flex-column mx-2 justify-content-center">
              <span className="font-medium">СЛ:</span>
              {isEditMode ? (
                <div>
                  <InputNumber
                    value={mutagen.complexity}
                    onValueChange={(e: InputNumberValueChangeEvent) => {
                      setMutagen((prevMutagen) => {
                        return {
                          ...prevMutagen,
                          complexity: e.value
                        };
                      })
                    }}
                    minFractionDigits={0}
                    maxFractionDigits={0}
                    min={0}
                    max={9999}
                  />
                </div>
              ) : (
                <div>{mutagen.complexity}</div>
              )}
            </div>
            <div className="flex flex-column mr-2 justify-content-center">
              <span className="font-medium">Эффект:</span>
              {isEditMode ? (
                <div>
                  <InputText
                    value={mutagen.effect}
                    onChange={(e) => {
                      setMutagen((prevMutagen) => {
                        return {
                          ...prevMutagen,
                          effect: e.target.value
                        };
                      })
                    }}
                  />
                </div>
              ) : (
                <div>{mutagen.effect}</div>
              )}
            </div>
            <div className="flex flex-column mr-2 justify-content-center">
              <span className="font-medium">Малая мутация:</span>
              {isEditMode ? (
                <div>
                  <InputTextarea
                    autoResize
                    value={mutagen.mutation}
                    onChange={(e) => {
                      setMutagen((prevMutagen) => {
                        return {
                          ...prevMutagen,
                          mutation: e.target.value
                        };
                      })
                    }}
                    rows={5}
                    cols={30}
                  />
                </div>
              ) : (
                <div>{mutagen.mutation}</div>
              )}
            </div>
            {isEditMode ? (<div>
              <Button onClick={() => {
                setMutagen(null);
              }}>
                Убрать мутаген
              </Button>
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
                imageFileName: null,
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
