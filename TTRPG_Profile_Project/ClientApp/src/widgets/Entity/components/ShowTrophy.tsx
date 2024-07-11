import { Button } from "primereact/button";
import { InputTextarea } from "primereact/inputtextarea";
import React, { useEffect, useState } from "react";
import {
  Control,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
  UseFormSetValue,
} from "react-hook-form";
import { ICreature, ISkillsList, IStatsList, ITrophy } from "shared/models";

interface IShowTrophy {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  setValue: UseFormSetValue<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowTrophy = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  setValue,
  register,
  isEditMode,
}: IShowTrophy) => {
  const [trophy, setTrophy] = useState<ITrophy>(null);

  const fetchData = () => {
    let values = getValues();

    setTrophy(values.trophy);

    if (trophy){
      if (trophy.id === 0)
        setTrophy(null);
    }
  };

  useEffect(() => {
    fetchData();
  }, [data, control, statList, skillsList, isEditMode]);

  useEffect(() => {
    setValue("trophy", trophy)
  }, [trophy, register]);

  return (
    <div className="p-2">
      {trophy ? (
        <div className="showInfo">
          <span className="showInfo__name">Трофей:</span>
          <div className="flex flex-wrap">
            <div className="flex flex-column mx-2 justify-content-center">
              <span className="font-medium">Эффект:</span>
              {isEditMode ? (
                <div>
                  <InputTextarea
                    autoResize
                    value={trophy.description}
                    onChange={(e) => {
                      setTrophy((prevTrophy) => {
                        return {
                          ...prevTrophy,
                          description: e.target.value
                        }
                      })
                    }}
                  />
                </div>
              ) : (
                <div className="ml-1">{trophy.description}</div>
              )}
            </div>
            {isEditMode ? (<div>
              <Button onClick={() => {
                setTrophy(null);
              }}>
                Убрать трофей
              </Button>
            </div>) : ""}
          </div>
        </div>
      ) : (
        <div></div>
      )}
      {!trophy && isEditMode ? (
        <div>
          <button
            onClick={(e) => {
              e.preventDefault();
              setTrophy({
                id: 0,
                description: "",
                name: "",
                source: null,
                imageFileName: null,
              });
            }}
          >
            Добавить трофей
          </button>
        </div>
      ) : (
        ""
      )}
    </div>
  );
};
