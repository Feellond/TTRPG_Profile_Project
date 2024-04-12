import React from "react";
import { ICreatureAttack } from "shared/models";

interface IShowAttacks {
  creatureAttacks: ICreatureAttack[];
}

export const ShowAttacks = ({ creatureAttacks }: IShowAttacks) => {
  return creatureAttacks.length > 0 ? (
    <div className="creatureAttacks">
      <p>Атаки:</p>
      <div>
        <table>
          <thead>
            <th>Наименование</th>
            <th>Основа</th>
            <th>Тип</th>
            <th>Урон</th>
            <th>Надеж</th>
            <th>Дальн</th>
            <th>Эффекты</th>
            <th>СА</th>
          </thead>
          <tbody>
            {creatureAttacks.map((attack, index) => (
              <tr>
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

              //   <div className="flex flex-wrap mt-3 border-solid">
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Наименование</div>
              //       <div>{attack.attack.name}</div>
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Основа</div>
              //       <div>{attack.attack.baseAttack}</div>
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Тип</div>
              //       <div>{attack.attack.attackType}</div>
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Урон</div>
              //       <div>{attack.attack.damage}</div>
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Надеж</div>
              //       <div>{attack.attack.reliability}</div>
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Дальн</div>
              //       <div>{attack.attack.distance}</div>
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">Эффекты</div>
              //       {attack.attack.attackEffectList.length > 0
              //         ? attack.attack.attackEffectList.map((effect, index) => (
              //             <div className="flex flex-wrap">
              //               <div key={index}>
              //                 {effect.effect.name} (
              //                 {effect.isDealDamage ? (
              //                   effect.damage
              //                 ) : (
              //                   <div>{effect.chancePercent}%</div>
              //                 )}
              //                 )
              //               </div>
              //             </div>
              //           ))
              //         : "-"}
              //     </div>
              //     <div className="m-2 text-center">
              //       <div className="font-bold">СА</div>
              //       <div>{attack.attack.attackSpeed}</div>
              //     </div>
              //   </div>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  ) : (
    ""
  );
};
