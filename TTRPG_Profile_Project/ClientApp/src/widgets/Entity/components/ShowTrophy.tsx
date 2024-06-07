import { InputText } from "primereact/inputtext";
import React, { useEffect, useState } from "react";
import {
  Control,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
} from "react-hook-form";
import { ICreature, ISkillsList, IStatsList, ITrophy } from "shared/models";

interface IShowTrophy {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowTrophy = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  register,
  isEditMode,
}: IShowTrophy) => {
  const [trophy, setTrophy] = useState<ITrophy>(null);

  const fetchData = () => {
    let values = getValues();

    setTrophy(values.trophy);

    if (trophy){
      if (trophy.id === 0 || trophy.name === "")
        setTrophy(null);
    }
  };

  useEffect(() => {
    fetchData();
  }, [data, control, statList, skillsList, isEditMode]);

  useEffect(() => {
    register("trophy", { value: trophy });
  }, [trophy]);

  return (
    <div>
      {trophy ? (
        <div>
          <span>Трофей:</span>
          <div>
            <div className="flex">
              <span>Эффект:</span>
              {isEditMode ? (
                <div>
                  <InputText
                    value={trophy.description}
                    onChange={(e) => {
                      trophy.description = e.target.value; //Не уверен, что работает
                    }}
                  />
                </div>
              ) : (
                <div className="ml-1">{trophy.description}</div>
              )}
            </div>
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
