import React, { useEffect } from "react";
import { ISpell } from "shared/models";

interface IShowSpellProps {
  data: ISpell;
}

const ShowSpell = ({ data }: IShowSpellProps) => {
  useEffect(() => {}, [data]);

  return (
    <div>
      <div
        className="p-2 text-2xl font-semibold cursor-pointer"
        style={{ marginBottom: "-10px" }}
      >
        <a>{data.name}</a>
      </div>
      <ul className="p-2 params">
        <li>
          <i></i>
        </li>
        <li className="my-2">
          <div>{data.description}</div>
        </li>
      </ul>
    </div>
  );
};

export { ShowSpell };
