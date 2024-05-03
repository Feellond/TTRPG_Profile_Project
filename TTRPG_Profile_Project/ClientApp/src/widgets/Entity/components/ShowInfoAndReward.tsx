import React, { useEffect, useState } from "react";
import { Control, FieldValues, UseFormGetValues } from "react-hook-form";
import { ICreature, ICreatureReward } from "shared/models";

interface IShowInfoAndReward {
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  isEditMode: boolean;
}

export const ShowInfoAndReward = ({data, control, getValues, isEditMode }: IShowInfoAndReward) => {
  const [armor, setArmor] = useState<number>(null);
  const [regeneration, setRegeneration] = useState<number>(null);
  const [resistances, setResistances] = useState<number>(null);
  const [immunities, setImmunities] = useState<number>(null);
  const [vulnerabilities, setVulnerabilities] = useState<number>(null);
  const [creatureReward, setCreatureReward] = useState<ICreatureReward[]>([]);
  const [moneyReward, setMoneyReward] = useState<number>(null);
  const [height, setHeight] = useState<number>(null);
  const [weight, setWeight] = useState<number>(null);
  const [habitatPlace, setHabitatPlace] = useState<number>(null);
  const [intellect, setIntellect] = useState<number>(null);
  const [groupSize, setGroupSize] = useState<number>(null);

  const fetchData = () => {
    let values = getValues();

    setArmor(values.armor);
    setRegeneration(values.regeneration);
    setResistances(values.resistances);
    setImmunities(values.immunities);
    setVulnerabilities(values.vulnerabilities);
    setCreatureReward(values.creatureReward);
    setMoneyReward(values.moneyReward);
    setHeight(values.height);
    setWeight(values.weight);
    setHabitatPlace(values.habitatPlace);
    setIntellect(values.intellect);
    setGroupSize(values.groupSize);
  }

  useEffect(() => {
    fetchData();
  }, [data])

  return (
    <div className="my-2 infoAndRewardList">
      <div>Броня: {armor}</div>
      <div>Регенерация: {regeneration}</div>
      <div>Сопротивления: {resistances}</div>
      <div>Невосприимчивость: {immunities}</div>
      <div>Восприимчивость: {vulnerabilities}</div>
      <div className="flex">
        Добыча:{" "}
        {creatureReward.map((reward, index) => (
          <div key={index}>{reward.reward.name}, </div>
        ))}
      </div>
      <div>Награда: {moneyReward}</div>
      <div>Высота: {height}</div>
      <div>Вес: {weight}</div>
      <div>Место проживания: {habitatPlace}</div>
      <div>Интеллект: {intellect}</div>
      <div>Размер группы: {groupSize}</div>
    </div>
  );
};
