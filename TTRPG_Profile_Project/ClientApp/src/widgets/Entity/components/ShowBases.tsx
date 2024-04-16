import React from "react";
import { ICreature } from "shared/models";

interface IShowBase {
  data: ICreature;
}

export const ShowBases = ({ data }: IShowBase) => {
  return (
    <div className="my-2">
      <div>База блока: {data.blockBase}</div>
      <div>База уклонения: {data.evasionBase}</div>
      <div>База атлетики: {data.athleticsBase}</div>
      <div>База сопротивления магии: {data.spellResistBase}</div>
    </div>
  );
};
