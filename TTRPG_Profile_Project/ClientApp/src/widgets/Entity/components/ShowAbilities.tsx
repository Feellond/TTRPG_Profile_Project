import React, { useEffect, useState } from "react";
import { Control, FieldValues, UseFormGetValues } from "react-hook-form";
import { ICreature, ICreatureAbilitys, ISkillsList, IStatsList } from "shared/models";

interface IShowAbilities {
  //creatureAbilities: ICreatureAbilitys[];
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  isEditMode: boolean;  
}

export const ShowAbilities = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  isEditMode,
}: IShowAbilities) => {
  const [creatureAbilities, setCreatureAbilities] = useState<
    ICreatureAbilitys[]
  >([]);

  const fetchData = () => {
    let getCreatureAbilities: ICreatureAbilitys[] =
      getValues("creatureAbilities");
    setCreatureAbilities(getCreatureAbilities);
  };

  useEffect(() => {
    fetchData();
  }, [data]);

  return creatureAbilities?.length > 0 ? (
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
              <td>{ability.ability.name}</td>
              <td>{ability.ability.type}</td>
              <td>{ability.ability.description}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  ) : (
    ""
  );
};
