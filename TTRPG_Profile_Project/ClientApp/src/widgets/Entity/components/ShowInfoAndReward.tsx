import { FindItemById } from "entities/GeneralFunc";
import { Button } from "primereact/button";
import { Dropdown } from "primereact/dropdown";
import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import { MultiSelect } from "primereact/multiselect";
import { SelectItem } from "primereact/selectitem";
import { Tooltip } from "primereact/tooltip";
import React, { useEffect, useState } from "react";
import {
  Control,
  Controller,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
  UseFormSetValue,
} from "react-hook-form";
import { CreatureEffectType } from "shared/enums/CreatureEnums";
import {
  ICreature,
  ICreatureEffect,
  ICreatureReward,
  ISkillsList,
  IStatsList,
  ItemDTO,
} from "shared/models";
import { ItemShortDTO } from "shared/models/Item/DTO/ItemsDTO";
import itemService from "shared/services/item.service";

interface IShowInfoAndReward {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;

  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  setValue: UseFormSetValue<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowInfoAndReward = ({
  statList,
  skillsList,
  data,
  control,
  register,
  setValue,
  getValues,
  isEditMode,
}: IShowInfoAndReward) => {
  const [armor, setArmor] = useState<number>(null);
  const [regeneration, setRegeneration] = useState<number>(null);
  const [moneyReward, setMoneyReward] = useState<number>(null);
  const [height, setHeight] = useState<number>(null);
  const [weight, setWeight] = useState<number>(null);
  const [habitatPlace, setHabitatPlace] = useState<string>(null);
  const [intellect, setIntellect] = useState<string>(null);
  const [groupSize, setGroupSize] = useState<string>(null);

  const [creatureReward, setCreatureReward] = useState<ICreatureReward[]>([]);
  const [immunities, setImmunities] = useState<ICreatureEffect[]>([]);
  const [resistances, setResistances] = useState<ICreatureEffect[]>([]);
  const [vulnerabilities, setVulnerabilities] = useState<ICreatureEffect[]>([]);

  //const [rewards, setRewards] = useState<ItemShortDTO[]>([]);
  const [itemOptions, setItemOptions] = useState<SelectItem[]>([]);

  const fetchData = () => {
    let values = getValues();

    setArmor(values.armor);
    setRegeneration(values.regeneration);
    setCreatureReward(values.creatureReward);
    setMoneyReward(values.moneyReward);
    setHeight(values.height);
    setWeight(values.weight);
    setHabitatPlace(values.habitatPlace);
    setIntellect(values.intellect);
    setGroupSize(values.groupSize);

    setResistances(values.resistances);
    setImmunities(values.immunities);
    setVulnerabilities(values.vulnerabilities);
  };

  useEffect(() => {
    LoadItems();
  }, [isEditMode]);

  useEffect(() => {
    fetchData();
  }, [data, control, isEditMode, statList, skillsList]);

  // useEffect(() => {
  //   if (creatureReward) {
  //     // Извлечение Item из CreatureReward
  //     const items = creatureReward.map((reward) => reward.itemBase);

  //     const newItems = items.map((reward) => {
  //       const foundItem = findItemById(itemOptions, reward.id);
  //       return foundItem ? foundItem.value : null;
  //     });

  //     setRewards(newItems);
  //   }
  // }, [creatureReward]);

  useEffect(() => {
    setValue("immunities", immunities);
    setValue("resistances", resistances);
    setValue("vulnerabilities", vulnerabilities);
    setValue("creatureReward", creatureReward);
  }, [immunities, resistances, vulnerabilities, creatureReward]);

  const handleAdd = (e, type: CreatureEffectType) => {
    e.preventDefault();

    if (type === CreatureEffectType.Immunity)
      setImmunities((immunities) => [
        ...immunities,
        {
          id: 0,
          type: Number(CreatureEffectType.Immunity),
          name: "",
          description: "",
        },
      ]);
    else if (type === CreatureEffectType.Resistance)
      setResistances((resistances) => [
        ...resistances,
        {
          id: 0,
          type: Number(CreatureEffectType.Resistance),
          name: "",
          description: "",
        },
      ]);
    else if (type === CreatureEffectType.Vulnerability)
      setVulnerabilities((vulnerabilities) => [
        ...vulnerabilities,
        {
          id: 0,
          type: Number(CreatureEffectType.Vulnerability),
          name: "",
          description: "",
        },
      ]);
  };

  const handleRemove = (e, type: CreatureEffectType, index: number) => {
    e.preventDefault();

    if (type === CreatureEffectType.Immunity) {
      const newImmunities = [...immunities];
      newImmunities.splice(index, 1);
      setImmunities(newImmunities);
    } else if (type === CreatureEffectType.Resistance) {
      const newResistances = [...resistances];
      newResistances.splice(index, 1);
      setResistances(newResistances);
    } else if (type === CreatureEffectType.Vulnerability) {
      const newVulnerability = [...vulnerabilities];
      newVulnerability.splice(index, 1);
      setVulnerabilities(newVulnerability);
    }
  };

  const handleNameChange = (
    type: CreatureEffectType,
    index: number,
    name: string
  ) => {
    if (type === CreatureEffectType.Immunity) {
      const newImmunities = [...immunities];
      newImmunities[index].name = name;
      setImmunities(newImmunities);
    } else if (type === CreatureEffectType.Resistance) {
      const newResistances = [...resistances];
      newResistances[index].name = name;
      setResistances(newResistances);
    } else if (type === CreatureEffectType.Vulnerability) {
      const newVulnerability = [...vulnerabilities];
      newVulnerability[index].name = name;
      setVulnerabilities(newVulnerability);
    }
  };

  const handleDescriptionChange = (
    type: CreatureEffectType,
    index: number,
    description: string
  ) => {
    if (type === CreatureEffectType.Immunity) {
      const newImmunities = [...immunities];
      newImmunities[index].description = description;
      setImmunities(newImmunities);
    } else if (type === CreatureEffectType.Resistance) {
      const newResistances = [...resistances];
      newResistances[index].description = description;
      setResistances(newResistances);
    } else if (type === CreatureEffectType.Vulnerability) {
      const newVulnerability = [...vulnerabilities];
      newVulnerability[index].description = description;
      setVulnerabilities(newVulnerability);
    }
  };

  const LoadItems = async () => {
    try {
      let result = await itemService.getItemsSimple();

      if (result && result.data) {
        const entitys = result.data.entitys;
        //setEntityList(entitys);

        const options = entitys.map((data, index) => ({
          name: data.name,
          label: data.name,
          value: data,
        }));

        setItemOptions(options);
      }
    } catch (error) {
      console.error("Error fetching entitys:", error);
    }
  };

  return (
    <div className="baseList">
      <div className="showInfo">
        <span className="showInfo__name">Броня: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <Controller
              name="armor"
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
          </div>
        ) : (
          <div className="ml-1">{armor}</div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Регенерация: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <Controller
              name="regeneration"
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
          </div>
        ) : (
          <div className="ml-1">{regeneration}</div>
        )}
      </div>
      <div className="flex flex-wrap mb-2 showInfoMedia">
        {resistances && resistances.length > 0 ? (
          <div className="flex flex-wrap flex-column mr-3 mb-2">
            <span className="showInfo__name">Сопротивления: </span>
            {isEditMode ? (
              <div className="my-2 flex flex-wrap">
                {resistances ? (
                  resistances.map((resistance, index) => (
                    <div
                      key={index}
                      className="flex flex-column flex-wrap text-center align-items-center border-1 mb-2 justify-content-center relative"
                    >
                      <span className="field flex flex-column mx-1 mt-3">
                        <label>Наименование {index + 1}:</label>
                        <InputText
                          className="input-text"
                          value={resistance.name}
                          onChange={(e) =>
                            handleNameChange(
                              CreatureEffectType.Resistance,
                              index,
                              e.target.value
                            )
                          }
                        />
                      </span>
                      <span className="field flex flex-column mx-1">
                        <label>Описание:</label>
                        <InputTextarea
                          autoResize
                          value={resistance.description}
                          onChange={(
                            e: React.ChangeEvent<HTMLTextAreaElement>
                          ) =>
                            handleDescriptionChange(
                              CreatureEffectType.Resistance,
                              index,
                              e.target.value
                            )
                          }
                          rows={5}
                          cols={30}
                        />
                      </span>
                      <Button
                        className="absolute top-0 right-0 h-2rem w-1"
                        icon="pi pi-trash"
                        onClick={(e) =>
                          handleRemove(e, CreatureEffectType.Resistance, index)
                        }
                      ></Button>
                    </div>
                  ))
                ) : (
                  <div></div>
                )}
                <div className="flex justify-content-center align-items-center">
                  <Button
                    onClick={(e) => handleAdd(e, CreatureEffectType.Resistance)}
                  >
                    Добавить сопротивление
                  </Button>
                </div>
              </div>
            ) : (
              <div className="flex flex-column">
                {resistances
                  ? resistances.map((item, index) => (
                      <span key={index}>
                        <Tooltip
                          target={`.tooltip-${index}`}
                          position="top"
                          mouseTrack
                          mouseTrackLeft={2}
                        ></Tooltip>
                        <span
                          className={`tooltip-${index}`}
                          data-pr-tooltip={item.description}
                        >
                          {item.name}
                        </span>
                      </span>
                    ))
                  : ""}
              </div>
            )}
          </div>
        ) : (
          ""
        )}
        {immunities && immunities.length > 0 ? (
          <div className="flex flex-wrap flex-column mr-3 mb-2">
            <span className="showInfo__name">Иммунитеты: </span>
            {isEditMode ? (
              <div className="my-2 flex flex-wrap">
                {immunities ? (
                  immunities.map((immunity, index) => (
                    <div
                      key={index}
                      className="flex flex-column flex-wrap text-center align-items-center border-1 mb-2 justify-content-center relative"
                    >
                      <span className="field flex flex-column mx-1 mt-3">
                        <label>Наименование {index + 1}:</label>
                        <InputText
                          className="input-text"
                          value={immunity.name}
                          onChange={(e) =>
                            handleNameChange(
                              CreatureEffectType.Immunity,
                              index,
                              e.target.value
                            )
                          }
                        />
                      </span>
                      <span className="field flex flex-column mx-1">
                        <label>Описание:</label>
                        <InputTextarea
                          autoResize
                          value={immunity.description}
                          onChange={(
                            e: React.ChangeEvent<HTMLTextAreaElement>
                          ) =>
                            handleDescriptionChange(
                              CreatureEffectType.Immunity,
                              index,
                              e.target.value
                            )
                          }
                          rows={5}
                          cols={30}
                        />
                      </span>
                      <Button
                        className="absolute top-0 right-0 h-2rem w-1"
                        icon="pi pi-trash"
                        onClick={(e) =>
                          handleRemove(e, CreatureEffectType.Immunity, index)
                        }
                      ></Button>
                    </div>
                  ))
                ) : (
                  <div></div>
                )}
                <div className="flex justify-content-center align-items-center">
                  <Button
                    onClick={(e) => handleAdd(e, CreatureEffectType.Immunity)}
                  >
                    Добавить иммунитет
                  </Button>
                </div>
              </div>
            ) : (
              <div className="flex flex-column">
                {immunities
                  ? immunities.map((item, index) => (
                      <span key={index}>
                        <Tooltip
                          target={`.tooltip-${index}`}
                          position="top"
                          mouseTrack
                          mouseTrackLeft={2}
                        ></Tooltip>
                        <span
                          className={`tooltip-${index}`}
                          data-pr-tooltip={item.description}
                        >
                          {item.name}
                        </span>
                      </span>
                    ))
                  : ""}
              </div>
            )}
          </div>
        ) : (
          ""
        )}
        {vulnerabilities && vulnerabilities.length > 0 ? (
          <div className="flex flex-wrap flex-column mr-2 mb-2">
            <span className="showInfo__name">Уязвимости: </span>
            {isEditMode ? (
              <div className="my-2 flex flex-wrap">
                {vulnerabilities ? (
                  vulnerabilities.map((vulnerability, index) => (
                    <div
                      key={index}
                      className="flex flex-column flex-wrap text-center align-items-center border-1 mb-2 justify-content-center relative"
                    >
                      <span className="field flex flex-column mx-1 mt-3">
                        <label>Наименование {index + 1}:</label>
                        <InputText
                          className="input-text"
                          type="text"
                          value={vulnerability.name}
                          onChange={(e) =>
                            handleNameChange(
                              CreatureEffectType.Vulnerability,
                              index,
                              e.target.value
                            )
                          }
                        />
                      </span>
                      <span className="field flex flex-column mx-1">
                        <label>Описание:</label>
                        <InputTextarea
                          autoResize
                          value={vulnerability.description}
                          onChange={(
                            e: React.ChangeEvent<HTMLTextAreaElement>
                          ) =>
                            handleDescriptionChange(
                              CreatureEffectType.Vulnerability,
                              index,
                              e.target.value
                            )
                          }
                          rows={5}
                          cols={30}
                        />
                      </span>
                      <Button
                        className="absolute top-0 right-0 h-2rem w-1"
                        icon="pi pi-trash"
                        onClick={(e) =>
                          handleRemove(
                            e,
                            CreatureEffectType.Vulnerability,
                            index
                          )
                        }
                      ></Button>
                    </div>
                  ))
                ) : (
                  <div></div>
                )}
                <div className="flex justify-content-center align-items-center">
                  <Button
                    style={{ height: "fit-content" }}
                    onClick={(e) =>
                      handleAdd(e, CreatureEffectType.Vulnerability)
                    }
                  >
                    Добавить уязвимость
                  </Button>
                </div>
              </div>
            ) : (
              <div className="flex flex-column">
                {vulnerabilities &&
                  vulnerabilities.map((item, index) => (
                    <span key={index}>
                      <Tooltip
                        target={`.tooltip-${index}`}
                        position="top"
                        mouseTrack
                        mouseTrackLeft={2}
                      ></Tooltip>
                      <span
                        className={`tooltip-${index}`}
                        data-pr-tooltip={item.description}
                      >
                        {item.name}
                      </span>
                    </span>
                  ))}
              </div>
            )}
          </div>
        ) : (
          ""
        )}
      </div>
      <div className="flex flex-wrap flex-column mb-2">
        <span className="showInfo__name">Добыча: </span>
        {isEditMode ? (
          <div className="my-2 flex flex-wrap">
            {creatureReward &&
              creatureReward.map((reward, index) => (
                <div
                  key={index}
                  className="flex flex-wrap text-center align-items-center border-1 mb-2 justify-content-center"
                >
                  <span className="field flex flex-column mx-1">
                    <label>Награда {index + 1}:</label>
                    <Dropdown
                      filter
                      value={FindItemById(itemOptions, reward.itemBase?.id)}
                      onChange={(e) => {
                        setCreatureReward((prevCreatureReward) => {
                          const updatedCreatureReward = [...prevCreatureReward];
                          updatedCreatureReward[index] = {
                            ...updatedCreatureReward[index],
                            itemBase: e.target.value,
                          };
                          return updatedCreatureReward;
                        });
                      }}
                      optionLabel="label"
                      options={itemOptions}
                      placeholder="Предмет"
                    />
                  </span>
                  <span className="field flex flex-column mx-1">
                    <label>Количество:</label>
                    <InputText
                      value={reward.amount}
                      onChange={(e) => {
                        setCreatureReward((prevCreatureReward) => {
                          const updatedCreatureReward = [...prevCreatureReward];
                          updatedCreatureReward[index] = {
                            ...updatedCreatureReward[index],
                            amount: e.target.value,
                          };
                          return updatedCreatureReward;
                        });
                      }}
                    />
                  </span>
                  <Button
                    className="mx-2"
                    icon="pi pi-trash"
                    onClick={(e) => {
                      e.preventDefault();
                      const newCreatureRewards = [...creatureReward];
                      newCreatureRewards.splice(index, 1);
                      setCreatureReward(newCreatureRewards);
                    }}
                  ></Button>
                </div>
              ))}
            <div className="flex justify-content-center align-items-center">
              <Button
                onClick={(e) => {
                  e.preventDefault();
                  setCreatureReward((creatureReward) => [
                    ...creatureReward,
                    {
                      id: 0,
                      amount: "",
                      itemBase: null,
                    },
                  ]);
                }}
              >
                Добавить награду
              </Button>
            </div>
          </div>
        ) : (
          <div className="flex flex-column">
            {creatureReward !== null && creatureReward !== undefined ? (
              creatureReward.map((reward, index) => (
                <span key={index}>
                  {reward.itemBase ? (
                    <a href={"listitem?name=" + reward.itemBase.name} target="_blank" rel="noreferrer">
                      <span>
                        {reward.itemBase.name}{" "}
                        {reward.amount !== "" ? (
                          <span>({reward.amount})</span>
                        ) : (
                          ""
                        )}
                      </span>
                    </a>
                  ) : (
                    ""
                  )}
                </span>
              ))
            ) : (
              <div></div>
            )}
          </div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Награда: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <Controller
              name="moneyReward"
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
          </div>
        ) : (
          <div className="ml-1">{moneyReward}</div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Высота: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <Controller
              name="height"
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
          </div>
        ) : (
          <div className="ml-1">{height}</div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Вес: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <Controller
              name="weight"
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
          </div>
        ) : (
          <div className="ml-1">{weight}</div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Место проживания: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <span className="p-float-label">
              <Controller
                name="habitatPlace"
                control={control}
                render={({ field }) => (
                  <>
                    <InputTextarea
                      autoResize
                      id={field.name}
                      value={field.value}
                      onChange={(e) => {
                        field.onChange(e.target.value);
                      }}
                      rows={3}
                      cols={30}
                    />
                  </>
                )}
              />
            </span>
          </div>
        ) : (
          <div className="ml-1">{habitatPlace}</div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Интеллект: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <span className="p-float-label">
              <Controller
                name="intellect"
                control={control}
                render={({ field }) => (
                  <>
                    <InputTextarea
                      autoResize
                      id={field.name}
                      value={field.value}
                      onChange={(e) => {
                        field.onChange(e.target.value);
                      }}
                      rows={2}
                      cols={30}
                    />
                  </>
                )}
              />
            </span>
          </div>
        ) : (
          <div className="ml-1">{intellect}</div>
        )}
      </div>
      <div className="showInfo">
        <span className="showInfo__name">Размер группы: </span>
        {isEditMode ? (
          <div className="baseList__controller">
            <span className="p-float-label">
              <Controller
                name="groupSize"
                control={control}
                render={({ field }) => (
                  <>
                    <InputTextarea
                      autoResize
                      id={field.name}
                      value={field.value}
                      onChange={(e) => {
                        field.onChange(e.target.value);
                      }}
                      rows={3}
                      cols={30}
                    />
                  </>
                )}
              />
            </span>
          </div>
        ) : (
          <div className="ml-1">{groupSize}</div>
        )}
      </div>
    </div>
  );
};
