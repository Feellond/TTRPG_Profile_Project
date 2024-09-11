import {
  ComplexityLoad,
  ComplexityValueToString,
  RaceLoad,
} from "entities/BestiaryFunc";
import { Button } from "primereact/button";
import { Checkbox } from "primereact/checkbox";
import { InputText } from "primereact/inputtext";
import React, { useContext, useEffect, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { ICreature, ISkillsList, IStatsList } from "shared/models";
import { ShowSkills } from "./ShowSkills/ShowSkills";
import { Accordion, AccordionTab } from "primereact/accordion";
import "../scss/style.scss";
import { ShowAttacks } from "./ShowAttacks";
import { ShowAbilities } from "./ShowAbilities";
import { ShowStats } from "./ShowStats";
import { ShowBases } from "./ShowBases";
import { ShowInfoAndReward } from "./ShowInfoAndReward";
import generalService from "shared/services/general.service";
import bestiaryService from "shared/services/bestiary.service";
import { Dropdown, DropdownChangeEvent } from "primereact/dropdown";
import { SelectItem } from "primereact/selectitem";
import { SourceOptionsLoad } from "entities/GeneralFunc";
import { Editor, EditorTextChangeEvent } from "primereact/editor";
import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import { CreatureEffectType } from "shared/enums/CreatureEnums";
import { ShowMutagen } from "./ShowMutagen";
import { ShowTrophy } from "./ShowTrophy";
import { Context } from "index";

interface ICreatureEntity {
  data: ICreature;
  setData: React.Dispatch<React.SetStateAction<ICreature>>;
  fetchData: () => Promise<void>;
}

const CreatureEntity = ({ data, setData, fetchData }: ICreatureEntity) => {
  const [isEditMode, setIsEditMode] = useState<boolean>(false);
  const [isEducationEdit, setIsEducationEdit] = useState<boolean>(false);
  const [isMonsterLoreEdit, setIsMonsterLoreEdit] = useState<boolean>(false);
  const [isTableEdit, setIsTableEdit] = useState<boolean>(false);
  const [activeIndex, setActiveIndex] = useState<number | number[]>();

  const [statList, setStatList] = useState<IStatsList>(null);
  const [skillsList, setSkillsList] = useState<ISkillsList>(null);

  const [isAllSkills, setIsAllSkills] = useState<boolean>(false);
  const [file, setFile] = useState<any>(null);

  const [complexityOptions, setComplexityOptions] = useState<SelectItem[]>([]);
  const [raceOptions, setRaceOptions] = useState<SelectItem[]>([]);
  const [sourceOptions, setSourceOptions] = useState<SelectItem[]>([]);

  const { store } = useContext(Context);

  const {
    register,
    setValue,
    getValues,
    control,
    formState: { errors },
    handleSubmit,
  } = useForm();

  useEffect(() => {
    ComplexityLoad({ setItems: setComplexityOptions });
    RaceLoad({ setItems: setRaceOptions });
    SourceOptionsLoad({ setItems: setSourceOptions });
  }, []);

  useEffect(() => {
    setValues();

    if (!isEditMode) {
      setIsTableEdit(false);
      setIsEducationEdit(false);
      setIsMonsterLoreEdit(false);
    }
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
    // setValue("immunities", data.immunities);
    // setValue("resistances", data.resistances);
    // setValue("vulnerabilities", data.vulnerabilities);
    setValue("intellect", data.intellect);
    setValue("groupSize", data.groupSize);
    setValue("creatureEffects", data.creatureEffects);
    setValue("creatureAttacks", data.creatureAttacks);
    setValue("creatureAbilitys", data.creatureAbilitys);
    setValue("creatureReward", data.creatureReward);
    setValue("imageFileName", data.imageFileName);
    setValue("mutagen", data.mutagen);
    setValue("trophy", data.trophy);

    if (data.creatureEffects) {
      const resistanceEffects = data.creatureEffects.filter(
        (effect) => effect.type === CreatureEffectType.Resistance
      );
      const immunityEffects = data.creatureEffects.filter(
        (effect) => effect.type === CreatureEffectType.Immunity
      );
      const vulnerabilityEffects = data.creatureEffects.filter(
        (effect) => effect.type === CreatureEffectType.Vulnerability
      );

      // const mapEffectsToSelectItems = (effects: ICreatureEffect[]) => {
      //   return effects.map((effect) => ({
      //     label: effect.name, // Assuming the name of the effect is stored in effect.name
      //     value: effect,
      //   }));
      // };

      setValue("immunities", immunityEffects);
      setValue("resistances", resistanceEffects);
      setValue("vulnerabilities", vulnerabilityEffects);
    }

    console.log("getValues:", getValues());

    setStatList(data.statsList);
    setSkillsList(data.skillsList);
  };

  const SaveChanges = () => {
    let dialogData = getValues();
    console.log(dialogData);

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
      // resistances: dialogData.resistances,
      // vulnerabilities: dialogData.vulnerabilities,
      // immunities: dialogData.immunities,
      intellect: dialogData.intellect,
      groupSize: dialogData.groupSize,
      creatureEffects: [
        ...dialogData.resistances,
        ...dialogData.immunities,
        ...dialogData.vulnerabilities,
      ], //dialogData.creatureEffects,
      creatureAttacks: dialogData.creatureAttacks,
      creatureAbilitys: dialogData.creatureAbilitys,
      creatureReward: dialogData.creatureReward,
      imageFileName: dialogData.imageFileName,
      mutagen: dialogData.mutagen,
      trophy: dialogData.trophy,
    };

    //dataOnSave.creatureEffects = [...dialogData.resistances, ...dialogData.immunities, ...dialogData.vulnerabilities];

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

    console.log("dataOnSave", dataOnSave);
    bestiaryService.updateEntity({ entity: dataOnSave });
    fetchData();
    setFile(null);
    //window.location.reload();
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
      <div className="flex">
        {store.isAuth && (
          <Button
            label="Изменить"
            onClick={() => setIsEditMode(!isEditMode)}
            className="p-button-text p-button-site"
            visible={!isEditMode}
          />
        )}
        {footerContent}
      </div>
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
            </div>
          )}

          <ul className="p-2 params">
            {!isEditMode ? (
              <li>
                <i>{data.race?.name}, </i>
                <i>{ComplexityValueToString(data.complexity)}, </i>
                <i>{data.source?.name}</i>
              </li>
            ) : (
              <div className="flex flex-wrap mt-3">
                <div className="field flex flex-column mr-3">
                  <span className="p-float-label">
                    <Controller
                      name="race"
                      control={control}
                      render={({ field }) => (
                        <>
                          <Dropdown
                            id={field.name}
                            value={field.value}
                            onChange={(e: DropdownChangeEvent) => {
                              field.onChange(e.value);
                            }}
                            optionLabel="label"
                            options={raceOptions}
                          />
                        </>
                      )}
                    />
                    <label className="text-0">Раса</label>
                  </span>
                </div>
                <div className="field flex flex-column mr-3">
                  <span className="p-float-label">
                    <Controller
                      name="complexity"
                      control={control}
                      render={({ field }) => (
                        <>
                          <Dropdown
                            id={field.name}
                            value={field.value}
                            onChange={(e: DropdownChangeEvent) => {
                              field.onChange(e.value);
                            }}
                            optionLabel="label"
                            options={complexityOptions}
                          />
                        </>
                      )}
                    />
                    <label className="text-0">Сложность</label>
                  </span>
                </div>
                <div className="field flex flex-column mr-3">
                  <span className="p-float-label">
                    <Controller
                      name="source"
                      control={control}
                      render={({ field }) => (
                        <>
                          <Dropdown
                            id={field.name}
                            value={field.value}
                            onChange={(e: DropdownChangeEvent) => {
                              field.onChange(e.value);
                            }}
                            optionLabel="label"
                            options={sourceOptions}
                          />
                        </>
                      )}
                    />
                    <label className="text-0">Источник</label>
                  </span>
                </div>
              </div>
            )}
          </ul>

          <div className="creatureImage">
            {data.imageFileName !== null && data.imageFileName !== "" ? (
              <div className="mb-2">
                <img
                  src={"Images/Creature/" + data.imageFileName}
                  alt="Изображение"
                />
              </div>
            ) : (
              <div></div>
            )}
            {!isEditMode ? (
              <div></div>
            ) : (
              <input type="file" onChange={(e) => onFileChange(e)} />
            )}
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
            <ShowStats
              statList={statList}
              setStatList={setStatList}
              data={data}
              isEditMode={isEditMode}
              control={control}
              getValues={getValues}
            />

            <ShowSkills
              statList={statList}
              skillsList={skillsList}
              setSkillsList={setSkillsList}
              data={data}
              isAllSkills={isAllSkills}
              control={control}
              getValues={getValues}
              isEditMode={isEditMode}
            />
          </div>

          <div className="p-2">
            <ShowBases
              statList={statList}
              skillsList={skillsList}
              data={data}
              control={control}
              getValues={getValues}
              isEditMode={isEditMode}
            />
          </div>

          <div className="p-2">
            <ShowInfoAndReward
              statList={statList}
              skillsList={skillsList}
              data={data}
              control={control}
              getValues={getValues}
              setValue={setValue}
              register={register}
              isEditMode={isEditMode}
            />
          </div>

          <div>
            <ShowMutagen
              skillsList={skillsList}
              statList={statList}
              data={data}
              control={control}
              getValues={getValues}
              setValue={setValue}
              register={register}
              isEditMode={isEditMode}
            />
          </div>

          <div>
            <ShowTrophy
              skillsList={skillsList}
              statList={statList}
              data={data}
              control={control}
              getValues={getValues}
              setValue={setValue}
              register={register}
              isEditMode={isEditMode}
            />
          </div>

          <Button
            visible={isEditMode}
            icon="pi pi-pencil"
            className="ml-auto p-onlytext p-rounded"
            onClick={(e) => {
              setIsTableEdit(!isTableEdit);
            }}
            label="Редактировать таблицы"
            type="button"
          />

          <div className="my-2 p-2 overflow-auto">
            <ShowAttacks
              skillsList={skillsList}
              statList={statList}
              data={data}
              control={control}
              getValues={getValues}
              setValue={setValue}
              register={register}
              isEditMode={isTableEdit}
            />
          </div>

          <div className="my-2 p-2 overflow-auto">
            <ShowAbilities
              skillsList={skillsList}
              statList={statList}
              data={data}
              control={control}
              getValues={getValues}
              setValue={setValue}
              register={register}
              isEditMode={isTableEdit}
            />
          </div>

          <div>
            <Button
              visible={isEditMode}
              icon="pi pi-pencil"
              className="ml-auto p-onlytext p-rounded"
              onClick={(e) => {
                setIsEducationEdit(!isEducationEdit);
                setIsMonsterLoreEdit(!isMonsterLoreEdit);

                if (!isEducationEdit) setActiveIndex([0, 1]);
                else setActiveIndex([]);

                console.log("Values: ", getValues());
              }}
              label="Редактировать инфо"
              type="button"
            />
            {isEducationEdit ? (
              <div>
                <label className="text-0">Сложность образования</label>
                <span className="p-float-label">
                  <Controller
                    name="educationSkill"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                </span>
              </div>
            ) : (
              <div></div>
            )}

            {isMonsterLoreEdit ? (
              <div>
                <label className="text-0">Сложность монстрологии</label>
                <span className="p-float-label">
                  <Controller
                    name="monsterLoreSkill"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                </span>
              </div>
            ) : (
              <div></div>
            )}
          </div>

          <div className="creatureInfo p-2">
            <Accordion
              multiple
              activeIndex={activeIndex}
              onTabChange={(e) => {
                setActiveIndex(e.index);
              }}
            >
              <AccordionTab
                disabled={isEducationEdit}
                header={
                  <span className="flex align-items-center gap-2 w-full">
                    Предрассудки простолюдинов (Образование, Сл{" "}
                    {data.educationSkill})
                  </span>
                }
              >
                {!isEducationEdit ? (
                  <p className="m-0 text-0">{data.superstitionsInformation}</p>
                ) : (
                  <Controller
                    name="superstitionsInformation"
                    control={control}
                    render={({ field }) => (
                      <Editor
                        id={field.name}
                        value={field.value}
                        onLoad={() => {
                          console.log("start: ", field.value);
                        }}
                        onTextChange={(e: EditorTextChangeEvent) => {
                          field.onChange(e.htmlValue);
                          // register("superstitionsInformation", {
                          //   value: e.htmlValue,
                          // });
                        }}
                      />
                    )}
                  />
                )}
              </AccordionTab>
              <AccordionTab
                disabled={isMonsterLoreEdit}
                header={
                  <span className="flex align-items-center gap-2 w-full">
                    Экология и поведение (Монстрология, Сл{" "}
                    {data.monsterLoreSkill})
                  </span>
                }
              >
                {!isMonsterLoreEdit ? (
                  <p className="m-0 text-0">{data.monsterLoreInformation}</p>
                ) : (
                  <Controller
                    name="monsterLoreInformation"
                    control={control}
                    render={({ field }) => (
                      <Editor
                        id={field.name}
                        value={field.value}
                        onTextChange={(e: EditorTextChangeEvent) => {
                          field.onChange(e.htmlValue);
                          // register("monsterLoreInformation", {
                          //   value: e.htmlValue,
                          // });
                        }}
                      />
                    )}
                  />
                )}
              </AccordionTab>
            </Accordion>
          </div>
        </form>
      </div>
    </div>
  );
};

export { CreatureEntity };
