import React from "react";
import { ICreature } from "shared/models";

interface IShowInfoAndReward {
  data: ICreature;
}

export const ShowInfoAndReward = ({ data }: IShowInfoAndReward) => {
  return (
    <div className="my-2">
      <div>Броня: {data.armor}</div>
      <div>Регенерация: {data.regeneration}</div>
      <div>Сопротивления: {data.resistances}</div>
      <div>Невосприимчивость: {data.immunities}</div>
      <div>Восприимчивость: {data.vulnerabilities}</div>
      <div className="flex">
        Добыча:{" "}
        {data.creatureReward.map((reward, index) => (
          <div key={index}>{reward.reward.name}, </div>
        ))}
      </div>
      <div>Награда: {data.moneyReward}</div>
      <div>Высота: {data.height}</div>
      <div>Вес: {data.weight}</div>
      <div>Место проживания: {data.habitatPlace}</div>
      <div>Интеллект: {data.intellect}</div>
      <div>Размер группы: {data.groupSize}</div>
    </div>
  );
};
