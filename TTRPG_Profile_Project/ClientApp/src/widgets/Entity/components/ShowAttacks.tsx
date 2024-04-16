import React, { useEffect, useState } from "react";
import { ICreatureAttack } from "shared/models";

interface IShowAttacks {
  creatureAttacks: ICreatureAttack[];
}

export const ShowAttacks = ({ creatureAttacks }: IShowAttacks) => {
  const [width, setWidth] = useState(window.innerWidth);

  useEffect(() => {
    const handleResize = (event) => {
      setWidth(event.target.innerWidth);
    };
    window.addEventListener('resize', handleResize);
    return () => {
      window.removeEventListener('resize', handleResize);
    };
  }, []);

  return creatureAttacks.length > 0 ? (
    <div className="creatureAttacks">
      <p>Атаки:</p>
      <div>
        <table className="w-full">
          <thead>
            <th>{width <= 750 ? ("Наз") : ("Наименование")}</th>
            <th>{width <= 750 ? ("Осн") : ("Основа")}</th>
            <th>Тип</th>
            <th>{width <= 750 ? ("Ур") : ("Урон")}</th>
            <th>{width <= 750 ? ("Над") : ("Надежность")}</th>
            <th>{width <= 750 ? ("Дал") : ("Дальность")}</th>
            <th>{width <= 750 ? ("Эфф") : ("Эффекты")}</th>
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
    ""
  );
};
