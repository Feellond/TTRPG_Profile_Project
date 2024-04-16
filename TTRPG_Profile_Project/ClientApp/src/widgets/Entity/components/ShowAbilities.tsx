import React from "react";
import { ICreatureAbilitys } from "shared/models";

interface IShowAbilities {
  creatureAbilities: ICreatureAbilitys[];
}

export const ShowAbilities = ({ creatureAbilities }: IShowAbilities) => {
  return creatureAbilities.length > 0 ? (
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
