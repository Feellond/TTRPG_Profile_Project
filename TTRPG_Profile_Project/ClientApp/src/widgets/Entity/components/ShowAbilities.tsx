import React from "react";
import { ICreatureAbilitys } from "shared/models";

interface IShowAbilities {
  creatureAbilities: ICreatureAbilitys[];
}

export const ShowAbilities = ({ creatureAbilities }: IShowAbilities) => {
  return creatureAbilities.length > 0 ? (
    <div className="creatureSkills">
      <p>Способности:</p>
      <table>
        <thead>
          <th>Наименование</th>
          <th>Тип</th>
          <th>Описание</th>
        </thead>
        <tbody>
          {creatureAbilities.map((ability, index) => (
            <tr>
              <td>{ability.ability.name}</td>
              <td>{ability.ability.type}</td>
              <td>{ability.ability.description}</td>
            </tr>
            // <div key={index} className="flex flex-wrap mt-3 border-solid">
            //   <div className="m-2 text-center">
            //     <div className="font-bold"></div>
            //     <div>{ability.ability.name}</div>
            //   </div>
            //   <div className="m-2 text-center">
            //     <div className="font-bold"></div>
            //     <div>{ability.ability.type}</div>
            //   </div>
            //   <div className="m-2 text-center">
            //     <div className="font-bold"></div>
            //     <div>{ability.ability.description}</div>
            //   </div>
            // </div>
          ))}
        </tbody>
      </table>
    </div>
  ) : (
    ""
  );
};
