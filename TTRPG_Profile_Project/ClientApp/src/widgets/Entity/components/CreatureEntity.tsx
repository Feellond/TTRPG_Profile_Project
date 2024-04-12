import { ComplexityValueToString } from "entities/BestiaryFunc";
import { Button } from "primereact/button";
import { Checkbox } from "primereact/checkbox";
import { InputText } from "primereact/inputtext";
import React, { useEffect, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { ICreature } from "shared/models";
import { ShowSkills } from "./ShowSkills";
import { Accordion, AccordionTab } from 'primereact/accordion';
import "../scss/style.scss";
import { ShowAttacks } from "./ShowAttacks";
import { ShowAbilities } from "./ShowAbilities";

interface ICreatureEntity {
  data: ICreature;
  setData: React.Dispatch<React.SetStateAction<ICreature>>;
}

const CreatureEntity = ({ data, setData }: ICreatureEntity) => {
  const [isEditMode, setIsEditMode] = useState<boolean>(false);
  const [isAllSkills, setIsAllSkills] = useState<boolean>(false);

  const {
    register,
    setValue,
    getValues,
    control,
    formState: { errors },
    handleSubmit,
  } = useForm();

  useEffect(() => {
    setValues();
  }, [isEditMode, data]);

  useEffect(() => {}, [isEditMode]);

  const setValues = () => {
    setValue("id", data.id);
    setValue("name", data.name);
    setValue("description", data.description);
    setValue("source", data.source);
    setValue("race", data.race);
    setValue("additionalInformation", data.additionalInformation);
    setValue("educationSkill", data.educationSkill);
    setValue("superstitionsInformation", data.superstitionsInformation);
    setValue("monsterLoreSkill", data.monsterLoreSkill);
    setValue("monsterLoreInformation", data.monsterLoreInformation);
    setValue("complexity", data.complexity);
    setValue("moneyReward", data.moneyReward);
    setValue("armor", data.armor);
    setValue("regeneration", data.regeneration);
    setValue("statsList", data.statsList);
    setValue("evasionBase", data.evasionBase);
    setValue("athleticsBase", data.athleticsBase);
    setValue("blockBase", data.blockBase);
    setValue("spellResistBase", data.spellResistBase);
    setValue("height", data.height);
    setValue("weight", data.weight);
    setValue("habitatPlace", data.habitatPlace);
    setValue("intellect", data.intellect);
    setValue("groupSize", data.groupSize);
    setValue("creatureAttacks", data.creatureAttacks);
    setValue("creatureAbilitys", data.creatureAbilitys);
    setValue("creatureReward", data.creatureReward);
  };

  const onSave = () => {
    setIsEditMode(false);
  };

  const onCancel = () => {
    setIsEditMode(false);
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setData((prevData) => ({
      ...prevData,
      [name]: value,
    }));
  };

  const footerContent = (
    <div>
      <Button
        label="Отмена"
        icon="pi pi-times"
        visible={isEditMode}
        onClick={() => onCancel()}
        className="p-button-text"
      />
      <Button
        label="Сохранить"
        icon="pi pi-check"
        visible={isEditMode}
        onClick={() => onSave()}
        autoFocus
      />
    </div>
  );

  return (
    <div className="w-full" style={{ marginTop: "-20px" }}>
      <Button
        label="Изменить"
        onClick={() => setIsEditMode(!isEditMode)}
        className="p-button-text"
      />
      <div className="card block bg-bluegray-50 mb-4 text-0">
        <form className="m-2">
          {!isEditMode ? (
            <div
              className="p-2 text-2xl font-semibold"
              style={{ marginBottom: "-10px" }}
            >
              <div>{data.name}</div>
            </div>
          ) : (
            <span className="p-float-label mt-4">
              <Controller
                name="name"
                control={control}
                render={({ field }) => (
                  <>
                    <InputText
                      id={field.name}
                      value={field.value}
                      onChange={(e) => {
                        field.onChange(e.target.value);
                      }}
                      className="bg-white text-0"
                    />
                  </>
                )}
              />
              <label className="text-0">Наименование</label>
            </span>
          )}

          <ul className="p-2 params">
            <li>
              <i>{data.race?.name}, </i>
              <i>{ComplexityValueToString(data.complexity)}</i>
            </li>
          </ul>

          <div className="flex">
            <p>Характеристики</p>
            <div className="ml-2">
              <Checkbox
                onChange={(e) => setIsAllSkills(e.checked)}
                checked={isAllSkills}
                tooltip="Показать все навыки"
              />
            </div>
          </div>
          <div className="flex">
            <div className="flex">
              <div className="m-2 text-center">
                <table>
                  <tbody>
                    <tr>
                      <th scope="row">Инт</th>
                      <td>{data.statsList?.intellectValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Реа</th>
                      <td>{data.statsList?.reactionValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Лвк</th>
                      <td>{data.statsList?.dexterityValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Тел</th>
                      <td>{data.statsList?.constitutionValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Скор</th>
                      <td>{data.statsList?.speedValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Эмп</th>
                      <td>{data.statsList?.empathyValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Рем</th>
                      <td>{data.statsList?.craftsmanshipValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Воля</th>
                      <td>{data.statsList?.willpowerValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Удач</th>
                      <td>{data.statsList?.luckValue}</td>
                    </tr>
                  </tbody>
                </table>
              </div>

              <div  className="m-2 text-center">
                <table>
                  <tbody>
                    <tr>
                      <th scope="row">Уст</th>
                      <td>{data.statsList?.resilienceValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Бег</th>
                      <td>{data.statsList?.runningValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Прж</th>
                      <td>{data.statsList?.jumpingValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Вын</th>
                      <td>{data.statsList?.enduranceValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Вес</th>
                      <td>{data.statsList?.weightValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Отд</th>
                      <td>{data.statsList?.restValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Пз</th>
                      <td>{data.statsList?.healthPointsValue}</td>
                    </tr>
                    <tr>
                      <th scope="row">Энер</th>
                      <td>{data.statsList?.energyValue}</td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
            {ShowSkills({
              statList: data.statsList,
              skillsList: data.skillsList,
              isAllSkills: isAllSkills,
            })}
            <div className="w-12">
              Изображение, рассчитанное примерно на 50% пространста справа от скиллов???
            </div>
          </div>

          <div className="my-2">
            <div>База блока: {data.blockBase}</div>
            <div>База уклонения: {data.evasionBase}</div>
            <div>База атлетики: {data.athleticsBase}</div>
            <div>База сопротивления магии: {data.spellResistBase}</div>
          </div>

          <div className="my-2">
            <div>Броня: {data.armor}</div>
            <div>Регенерация: {data.regeneration}</div>
            <div>Сопротивления: {data.resistances}</div>
            <div>Невосприимчивость: {data.immunities}</div>
            <div>Восприимчивость: {data.vulnerabilities}</div>
            <div className="flex">
              Добыча:{" "}
              {data.creatureReward.map((reward, index) => (
                <div>{reward.reward.name}, </div>
              ))}
            </div>
            <div>Награда: {data.moneyReward}</div>
          </div>

          <div className="my-2">
            {ShowAttacks({creatureAttacks: data.creatureAttacks})}
          </div>

          <div className="my-2">
            {ShowAbilities({creatureAbilities: data.creatureAbilitys})}
          </div>

          <div className="creatureInfo">
            <Accordion multiple>
              <AccordionTab header={"Предрассудки простолюдинов (Образование, Сл " + data.educationSkill + ")"}>
                <p className="m-0 text-0">
                  {data.superstitionsInformation}
                </p>
              </AccordionTab>
              <AccordionTab header={"Экология и поведение (Монстрология, Сл " + data.monsterLoreSkill + ")"}>
                <p className="m-0 text-0">
                  {data.monsterLoreInformation}
                </p>
              </AccordionTab>
            </Accordion>            
          </div>

          {footerContent}
        </form>
      </div>
    </div>
  );
};

export { CreatureEntity };
