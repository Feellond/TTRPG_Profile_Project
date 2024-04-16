import React from "react";
import { IStatsList } from "shared/models";

interface IShowStats {
  stats: IStatsList | null;
}

export const ShowStats = ({ stats }: IShowStats) => {
  return (
    <div className="flex mr-6 statsTable">
      <div className="m-2 text-center">
        <table>
          <tbody>
            <tr>
              <th scope="row">Инт</th>
              <td>{stats?.intellectValue}</td>
            </tr>
            <tr>
              <th scope="row">Реа</th>
              <td>{stats?.reactionValue}</td>
            </tr>
            <tr>
              <th scope="row">Лвк</th>
              <td>{stats?.dexterityValue}</td>
            </tr>
            <tr>
              <th scope="row">Тел</th>
              <td>{stats?.constitutionValue}</td>
            </tr>
            <tr>
              <th scope="row">Скор</th>
              <td>{stats?.speedValue}</td>
            </tr>
            <tr>
              <th scope="row">Эмп</th>
              <td>{stats?.empathyValue}</td>
            </tr>
            <tr>
              <th scope="row">Рем</th>
              <td>{stats?.craftsmanshipValue}</td>
            </tr>
            <tr>
              <th scope="row">Воля</th>
              <td>{stats?.willpowerValue}</td>
            </tr>
            <tr>
              <th scope="row">Удач</th>
              <td>{stats?.luckValue}</td>
            </tr>
          </tbody>
        </table>
      </div>

      <div className="m-2 text-center">
        <table>
          <tbody>
            <tr>
              <th scope="row">Уст</th>
              <td>{stats?.resilienceValue}</td>
            </tr>
            <tr>
              <th scope="row">Бег</th>
              <td>{stats?.runningValue}</td>
            </tr>
            <tr>
              <th scope="row">Прж</th>
              <td>{stats?.jumpingValue}</td>
            </tr>
            <tr>
              <th scope="row">Вын</th>
              <td>{stats?.enduranceValue}</td>
            </tr>
            <tr>
              <th scope="row">Вес</th>
              <td>{stats?.weightValue}</td>
            </tr>
            <tr>
              <th scope="row">Отд</th>
              <td>{stats?.restValue}</td>
            </tr>
            <tr>
              <th scope="row">Пз</th>
              <td>{stats?.healthPointsValue}</td>
            </tr>
            <tr>
              <th scope="row">Энер</th>
              <td>{stats?.energyValue}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
};
