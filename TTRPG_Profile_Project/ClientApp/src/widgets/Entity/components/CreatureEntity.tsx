import { ComplexityValueToString } from "entities/BestiaryFunc";
import { Button } from "primereact/button";
import { Checkbox } from "primereact/checkbox";
import { InputText } from "primereact/inputtext";
import React, { useEffect, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { ICreature } from "shared/models";
import { ShowSkills } from "./ShowSkills";
import { Accordion, AccordionTab } from "primereact/accordion";
import "../scss/style.scss";
import { ShowAttacks } from "./ShowAttacks";
import { ShowAbilities } from "./ShowAbilities";
import { ShowStats } from "./ShowStats";
import { ShowBases } from "./ShowBases";
import { ShowInfoAndReward } from "./ShowInfoAndReward";
import generalService from "shared/services/general.service";
import bestiaryService from "shared/services/bestiary.service";

interface ICreatureEntity {
  data: ICreature;
  setData: React.Dispatch<React.SetStateAction<ICreature>>;
  fetchData: () => Promise<void>;
}

const CreatureEntity = ({ data, setData, fetchData }: ICreatureEntity) => {
  const [isEditMode, setIsEditMode] = useState<boolean>(false);
  const [isAllSkills, setIsAllSkills] = useState<boolean>(false);
  const [file, setFile] = useState<any>(null);

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

  useEffect(() => {}, [isEditMode, file]);

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
    setValue("skillsList", data.skillsList);
    setValue("evasionBase", data.evasionBase);
    setValue("athleticsBase", data.athleticsBase);
    setValue("blockBase", data.blockBase);
    setValue("spellResistBase", data.spellResistBase);
    setValue("height", data.height);
    setValue("weight", data.weight);
    setValue("habitatPlace", data.habitatPlace);
    setValue("immunities", data.immunities);
    setValue("resistances", data.resistances);
    setValue("vulnerabilities", data.vulnerabilities);
    setValue("intellect", data.intellect);
    setValue("groupSize", data.groupSize);
    setValue("creatureAttacks", data.creatureAttacks);
    setValue("creatureAbilitys", data.creatureAbilitys);
    setValue("creatureReward", data.creatureReward);
    setValue("imageFileName", data.imageFileName);
  };

  const SaveChanges = () => {
    let dialogData = getValues();
    console.log(dialogData);

    // let formData = new FormData();
    // formData.append("id", dialogData.id);
    // formData.append("name", dialogData.name);
    // formData.append("description", dialogData.description);
    // formData.append("source", dialogData.source);
    // formData.append("race", dialogData.race);
    // formData.append("additionalInformation", dialogData.additionalInformation);
    // formData.append("educationSkill", dialogData.educationSkill);
    // formData.append(
    //   "superstitionsInformation",
    //   dialogData.superstitionsInformation
    // );
    // formData.append("monsterLoreSkill", dialogData.monsterLoreSkill);
    // formData.append(
    //   "monsterLoreInformation",
    //   dialogData.monsterLoreInformation
    // );
    // formData.append("complexity", dialogData.complexity);
    // formData.append("moneyReward", dialogData.moneyReward);
    // formData.append("armor", dialogData.armor);
    // formData.append("regeneration", dialogData.regeneration);
    // formData.append("statsList", dialogData.statsList);

    // Object.keys(dialogData.skillsList).forEach((key) => {
    //   formData.append(`skillsList.${key}`, dialogData.skillsList[key]);
    // });
    // //formData.append("skillsList", JSON.stringify(dialogData.skillsList));
    // formData.append("evasionBase", dialogData.evasionBase);
    // formData.append("athleticsBase", dialogData.athleticsBase);
    // formData.append("blockBase", dialogData.blockBase);
    // formData.append("spellResistBase", dialogData.spellResistBase);
    // formData.append("height", dialogData.height);
    // formData.append("weight", dialogData.weight);
    // formData.append("habitatPlace", dialogData.habitatPlace);
    // formData.append("resistances", dialogData.resistances);
    // formData.append("vulnerabilities", dialogData.vulnerabilities);
    // formData.append("immunities", dialogData.immunities);
    // formData.append("intellect", dialogData.intellect);
    // formData.append("groupSize", dialogData.groupSize);
    // formData.append("creatureAttacks", dialogData.creatureAttacks);
    // formData.append("creatureAbilitys", dialogData.creatureAbilitys);
    // formData.append("creatureReward", dialogData.creatureReward);
    // formData.append("imageFileName", dialogData.imageFileName);
    // formData.append("file", file);

    let dataOnSave: ICreature = {
      id: dialogData.id,
      name: dialogData.name,
      description: dialogData.description,
      source: dialogData.source,
      race: dialogData.race,
      additionalInformation: dialogData.additionalInformation,
      educationSkill: dialogData.educationSkill,
      superstitionsInformation: dialogData.superstitionsInformation,
      monsterLoreSkill: dialogData.monsterLoreSkill,
      monsterLoreInformation: dialogData.monsterLoreInformation,
      complexity: dialogData.complexity,
      moneyReward: dialogData.moneyReward,
      armor: dialogData.armor,
      regeneration: dialogData.regeneration,
      statsList: dialogData.statsList,
      skillsList: dialogData.skillsList,
      evasionBase: dialogData.evasionBase,
      athleticsBase: dialogData.athleticsBase,
      blockBase: dialogData.blockBase,
      spellResistBase: dialogData.spellResistBase,
      height: dialogData.height,
      weight: dialogData.weight,
      habitatPlace: dialogData.habitatPlace,
      resistances: dialogData.resistances,
      vulnerabilities: dialogData.vulnerabilities,
      immunities: dialogData.immunities,
      intellect: dialogData.intellect,
      groupSize: dialogData.groupSize,
      creatureAttacks: dialogData.creatureAttacks,
      creatureAbilitys: dialogData.creatureAbilitys,
      creatureReward: dialogData.creatureReward,
      imageFileName: dialogData.imageFileName,
    };

    //dataOnSave.file = file;
    // for (let [key, value] of formData.entries()) {
    //   console.log(`${key}:`, value);
    //}
    onSave(dataOnSave);
  };

  const onFileChange = (e) => {
    setFile(e.target.files[0]);
  };

  const onSave = async (dataOnSave: ICreature) => {
    setIsEditMode(false);

    if (file != null) {
      if (dataOnSave.imageFileName !== null)
        if (dataOnSave.imageFileName !== "")
          generalService.deleteImage(dataOnSave.imageFileName, "Creature");

      let formData = new FormData();
      formData.append("file", file);
      formData.append("folderName", "Creature");

      generalService.loadImage(formData);
      dataOnSave.imageFileName = file.name;
    }

    console.log(dataOnSave);
    bestiaryService.updateEntity({ entity: dataOnSave });
    fetchData();
    setFile(null);
    window.location.reload();
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
        type="button"
      />
      <Button
        label="Сохранить"
        icon="pi pi-check"
        visible={isEditMode}
        onClick={() => SaveChanges()}
        type="button"
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
        <form className="p-2 creatureForm">
          {!isEditMode ? (
            <div
              className="p-2 text-2xl font-semibold"
              style={{ marginBottom: "-10px" }}
            >
              <div>{data.name}</div>
            </div>
          ) : (
            <div>
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
              {footerContent}
            </div>
          )}

          <ul className="p-2 params">
            <li>
              <i>{data.race?.name}, </i>
              <i>{ComplexityValueToString(data.complexity)}</i>
            </li>
          </ul>

          <div className="p-2 creatureImage">
            {data.imageFileName !== null ? (
              <div className="mb-4">
                <img
                  src={"Images/Creature/" + data.imageFileName}
                  alt="Изображение"
                />
              </div>
            ) : (
              <div></div>
            )}
            <input type="file" onChange={(e) => onFileChange(e)} />
          </div>

          <div className="pl-2 flex">
            <p>Характеристики</p>
            <div className="ml-2">
              <Checkbox
                onChange={(e) => setIsAllSkills(e.checked)}
                checked={isAllSkills}
                tooltip="Показать все навыки"
              />
            </div>
          </div>

          <div className="flex flex-wrap">
          {ShowStats({ stats: data.statsList })}

          {ShowSkills({
            statList: data.statsList,
            skillsList: data.skillsList,
            isAllSkills: isAllSkills,
          })}
          </div>

          <div className="p-2">{ShowBases({ data: data })}</div>

          <div className="p-2">{ShowInfoAndReward({ data: data })}</div>

          <div className="my-2 p-2 overflow-auto">
            {ShowAttacks({ creatureAttacks: data.creatureAttacks })}
          </div>

          <div className="my-2 p-2 overflow-auto">
            {ShowAbilities({ creatureAbilities: data.creatureAbilitys })}
          </div>

          <div className="creatureInfo p-2">
            <Accordion multiple>
              <AccordionTab
                header={
                  "Предрассудки простолюдинов (Образование, Сл " +
                  data.educationSkill +
                  ")"
                }
              >
                <p className="m-0 text-0">{data.superstitionsInformation}</p>
              </AccordionTab>
              <AccordionTab
                header={
                  "Экология и поведение (Монстрология, Сл " +
                  data.monsterLoreSkill +
                  ")"
                }
              >
                <p className="m-0 text-0">{data.monsterLoreInformation}</p>
              </AccordionTab>
            </Accordion>
          </div>
        </form>
      </div>
    </div>
  );
};

export { CreatureEntity };
