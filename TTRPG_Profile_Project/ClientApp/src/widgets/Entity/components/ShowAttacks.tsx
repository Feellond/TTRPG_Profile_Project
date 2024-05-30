import React, { useEffect, useState } from "react";
import { Control, FieldValues, UseFormGetValues } from "react-hook-form";
import { ICreature, ICreatureAttack, ISkillsList, IStatsList } from "shared/models";

interface IShowAttacks {
  //creatureAttacks: ICreatureAttack[];
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  isEditMode: boolean;  
}

export const ShowAttacks = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  isEditMode,
}: IShowAttacks) => {
  const [width, setWidth] = useState(window.innerWidth);
  const [creatureAttacks, setCreatureAttacks] = useState<ICreatureAttack[]>([]);

  const fetchData = () => {
    let getCreatureAttacks = getValues("creatureAttacks");
    setCreatureAttacks(getCreatureAttacks);
  }

  useEffect(() => {
    const handleResize = (event) => {
      setWidth(event.target.innerWidth);
    };
    window.addEventListener("resize", handleResize);
    return () => {
      window.removeEventListener("resize", handleResize);
    };
  }, []);

  useEffect(() => {
    fetchData();
  }, [data, statList, skillsList])

  return creatureAttacks?.length > 0 ? (
    <div className="creatureAttacks">
      <p>Атаки:</p>
      <div>
        <table className="w-full">
          <thead>
            <th>{width <= 750 ? "Наз" : "Наименование"}</th>
            <th>{width <= 750 ? "Осн" : "Основа"}</th>
            <th>Тип</th>
            <th>{width <= 750 ? "Ур" : "Урон"}</th>
            <th>{width <= 750 ? "Над" : "Надежность"}</th>
            <th>{width <= 750 ? "Дал" : "Дальность"}</th>
            <th>{width <= 750 ? "Эфф" : "Эффекты"}</th>
            <th>СА</th>
          </thead>
          <tbody>
            {creatureAttacks.map((attack, index) => (
              <tr key={index}>
                <td>{attack.attack.name}</td>
                <td>{attack.attack.baseAttack}</td>
                <td>{attack.attack.attackType}</td>
                <td>{attack.attack.damage}</td>
                <td>{attack.attack.reliability}</td>
                <td>{attack.attack.distance}</td>
                <td>
                  {attack.attack.attackEffectList.length > 0
                    ? attack.attack.attackEffectList.map((effect, index) => (
                        <div className="flex flex-wrap">
                          <div key={index}>
                            {effect.effect.name} (
                            {effect.isDealDamage ? (
                              effect.damage
                            ) : (
                              <div>{effect.chancePercent}%</div>
                            )}
                            )
                          </div>
                        </div>
                      ))
                    : "-"}
                </td>
                <td>{attack.attack.attackSpeed}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  ) : (
    <div></div>
  );
};
