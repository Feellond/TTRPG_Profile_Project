import { ComplexityValueToString } from "entities/BestiaryFunc";
import React, { useEffect } from "react";
import { ICreature } from "shared/models";

interface ShowBestiaryProps {
  data: ICreature;
}

const ShowBestiary = ({ data }: ShowBestiaryProps) => {
  let href = "bestiary/" + String(data.id);

  useEffect(() => {
  }, [data]);

  return (
    <div>
      <div
        className="p-2 text-2xl font-semibold cursor-pointer"
        style={{ marginBottom: "-10px" }}
      >
        <a href={href}>{data.name}</a>
      </div>
      <ul className="p-2 params">
        <li>
          <i>{data.race.name}, </i>
          <i>{ComplexityValueToString(data.complexity)}, </i>
          <i>{data.source?.name}</i>
        </li>
        {/*<li className="my-2">
          <div>{data.description}</div>
        </li> */}
      </ul>
    </div>
  );
};

export { ShowBestiary };
