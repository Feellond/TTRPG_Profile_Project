import { DeleteIcon, EditIcon, SaveIcon } from "img";
import { Button } from "primereact/button";
import { InputNumber } from "primereact/inputnumber";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import React, { useEffect, useState } from "react";
import {
  Control,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
} from "react-hook-form";
import {
  IAbilitiy,
  ICreature,
  ICreatureAbilitys,
  ISkillsList,
  IStatsList,
} from "shared/models";

interface IShowAbilities {
  //creatureAbilities: ICreatureAbilitys[];
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowAbilities = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  register,
  isEditMode,
}: IShowAbilities) => {
  const [creatureAbilities, setCreatureAbilities] = useState<
    ICreatureAbilitys[]
  >([]);
  const [editIndex, setEditIndex] = useState(null);
  const [editValues, setEditValues] = useState<IAbilitiy>(null);

  const fetchData = () => {
    let getCreatureAbilities: ICreatureAbilitys[] =
      getValues("creatureAbilities");
    setCreatureAbilities(getCreatureAbilities);
  };

  const handleEdit = (index) => {
    setEditIndex(index);
    setEditValues({
      ...creatureAbilities[index].ability,
    });
  };

  useEffect(() => {
    if (!isEditMode) setEditIndex(null);
  }, [isEditMode]);

  useEffect(() => {
    fetchData();
  }, [data, statList, skillsList]);

  useEffect(() => {
    register("creatureAbilities", { value: creatureAbilities });
  }, [creatureAbilities]);

  return creatureAbilities?.length > 0 || isEditMode ? (
    <div className="creatureSkills">
      <p>Способности:</p>
      <table className="w-full">
        <thead>
          <th>Наименование</th>
          <th>Тип</th>
          <th>Описание</th>
        </thead>
        <tbody>
          {creatureAbilities.map((ability, index) => (
            <tr key={index}>
              <td>
                {editIndex === index ? (
                  <InputText
                    value={editValues.name}
                    onChange={(e) =>
                      setEditValues({ ...editValues, name: e.target.value })
                    }
                  />
                ) : (
                  ability.ability.name
                )}
              </td>
              <td>
                {editIndex === index ? (
                  <InputNumber
                    type="number"
                    value={editValues.type}
                    onChange={(e) =>
                      setEditValues({
                        ...editValues,
                        type: e.value,
                      })
                    }
                  />
                ) : (
                  ability.ability.type
                )}
              </td>
              <td>
                {editIndex === index ? (
                  <InputTextarea
                    autoResize
                    value={editValues.description}
                    onChange={(e) =>
                      setEditValues({
                        ...editValues,
                        description: e.target.value,
                      })
                    }
                  />
                ) : (
                  ability.ability.description
                )}
              </td>
              <td className="flex flex-wrap">
                {editIndex === index ? (
                  <Button
                    icon="pi pi-check"
                    onClick={(e) => {
                      e.preventDefault();
                      const updatedAbilities = [...creatureAbilities];
                      updatedAbilities[index] = {
                        ...updatedAbilities[index],
                        ability: { ...editValues },
                      };
                      setCreatureAbilities(updatedAbilities);
                      setEditIndex(null);
                    }}
                  />
                ) : (
                  <Button
                    icon="pi pi-pencil"
                    onClick={(e) => {
                      e.preventDefault();
                      handleEdit(index);
                    }}
                  />
                )}
                <Button
                  icon="pi pi-trash"
                  onClick={(e) => {
                    e.preventDefault();
                    const updatedAbilities = [...creatureAbilities];
                    updatedAbilities.splice(index, 1); // Удаляем элемент по индексу index
                    setCreatureAbilities(updatedAbilities);
                  }}
                />
              </td>
            </tr>
          ))}
          {isEditMode ? (
            <tr>
              <td>
                <Button
                  label="Добавить"
                  onClick={(e) => {
                    e.preventDefault();
                    const newAbility: ICreatureAbilitys = {
                      // Создаем новый объект атаки
                      id: 0,
                      ability: {
                        id: 0,
                        creature: null,
                        description: "Описание новой способности",
                        name: "Новая способность",
                        race: null,
                        source: null,
                        type: 0,
                      },
                    };
                    setCreatureAbilities([...creatureAbilities, newAbility]); // Добавляем новую атаку в конец массива
                  }}
                />
              </td>
            </tr>
          ) : (
            ""
          )}
        </tbody>
      </table>
    </div>
  ) : (
    <div></div>
  );
};
