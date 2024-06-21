import { AttackTypeToShortString } from "entities/BestiaryFunc";
import { AttackTypeOptionsLoad } from "entities/BestiaryFunc/components/OptionsLoad";
import { EffectOptionsLoad } from "entities/GeneralFunc";
import { DeleteIcon, EditIcon, PlusIcon, SaveIcon } from "img";
import { Button } from "primereact/button";
import { Dropdown } from "primereact/dropdown";
import { InputNumber } from "primereact/inputnumber";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import { SelectItem } from "primereact/selectitem";
import React, { useEffect, useState } from "react";
import {
  Control,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
} from "react-hook-form";
import {
  IAttack,
  IAttackEffectList,
  ICreature,
  ICreatureAttack,
  ISkillsList,
  IStatsList,
} from "shared/models";

interface IShowAttacks {
  //creatureAttacks: ICreatureAttack[];
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  register: UseFormRegister<FieldValues>;
  isEditMode: boolean;
}

export const ShowAttacks = ({
  statList,
  skillsList,
  data,
  control,
  getValues,
  register,
  isEditMode,
}: IShowAttacks) => {
  const [width, setWidth] = useState(window.innerWidth);
  const [creatureAttacks, setCreatureAttacks] = useState<ICreatureAttack[]>([]);
  const [editIndex, setEditIndex] = useState(null);
  const [editValues, setEditValues] = useState<IAttack>(null);

  const [effectOptions, setEffectOptions] = useState<SelectItem[]>([]);
  const [attackTypeOptions, setAttackTypeOptions] = useState<SelectItem[]>([]);

  const fetchData = () => {
    let getCreatureAttacks = getValues("creatureAttacks");
    setCreatureAttacks(getCreatureAttacks);
  };

  const handleEdit = (index) => {
    setEditIndex(index);
    setEditValues({
      ...creatureAttacks[index].attack,
    });
  };

  useEffect(() => {
    EffectOptionsLoad({ setItems: setEffectOptions });
    AttackTypeOptionsLoad({setItems: setAttackTypeOptions});

    const handleResize = (event) => {
      setWidth(event.target.innerWidth);
    };
    window.addEventListener("resize", handleResize);
    return () => {
      window.removeEventListener("resize", handleResize);
    };
  }, []);

  useEffect(() => {
    if (!isEditMode) setEditIndex(null);
  }, [isEditMode]);

  useEffect(() => {
    fetchData();
  }, [data, statList, skillsList]);

  useEffect(() => {
    register("creatureAttacks", { value: creatureAttacks });
  }, [creatureAttacks]);

  return creatureAttacks?.length > 0 || isEditMode ? (
    <div className="creatureAttacks">
      <p>Атаки:</p>
      <div>
        <table className="w-full">
          <thead>
            <th>{width <= 750 ? "Наз" : "Наименование"}</th>
            <th>{width <= 750 ? "Осн" : "Основа"}</th>
            <th>Тип</th>
            <th className="w-1">{width <= 750 ? "Ур" : "Урон"}</th>
            <th>{width <= 750 ? "Над" : "Надежность"}</th>
            <th>{width <= 750 ? "Дал" : "Дальность"}</th>
            <th
              style={{
                width:
                  editValues && editValues.attackEffectList.length > 0
                    ? "15rem"
                    : "auto",
              }}
            >
              {width <= 750 ? "Эфф" : "Эффекты"}
            </th>
            <th>СА</th>
          </thead>
          <tbody>
            {creatureAttacks.map((attack, index) => (
              <tr key={index}>
                <td>
                  {editIndex === index ? (
                    <InputTextarea
                      autoResize
                      value={editValues.name}
                      onChange={(e) =>
                        setEditValues({ ...editValues, name: e.target.value })
                      }
                      rows={4}
                    />
                  ) : (
                    attack.attack.name
                  )}
                </td>
                <td>
                  {editIndex === index ? (
                    <InputNumber
                      value={editValues.baseAttack}
                      onChange={(e) =>
                        setEditValues({ ...editValues, baseAttack: e.value })
                      }
                    />
                  ) : (
                    attack.attack.baseAttack
                  )}
                </td>
                <td>
                  {editIndex === index ? ( //Переделать под options
                    <Dropdown
                      value={editValues.attackType}
                      options={attackTypeOptions}
                      onChange={(e) => {
                        setEditValues({...editValues, attackType: e.value})
                      }}
                    />
                    /**<InputNumber
                      value={editValues.attackType}
                      onChange={(e) =>
                        setEditValues({ ...editValues, attackType: e.value })
                      }
                    /> */
                  ) : (
                    AttackTypeToShortString(attack.attack.attackType)
                  )}
                </td>
                <td>
                  {editIndex === index ? (
                    <InputText
                      value={editValues.damage}
                      onChange={(e) =>
                        setEditValues({ ...editValues, damage: e.target.value })
                      }
                    />
                  ) : (
                    attack.attack.damage
                  )}
                </td>
                <td>
                  {editIndex === index ? (
                    <InputNumber
                      value={editValues.reliability}
                      onChange={(e) =>
                        setEditValues({ ...editValues, reliability: e.value })
                      }
                    />
                  ) : (
                    attack.attack.reliability
                  )}
                </td>
                <td>
                  {editIndex === index ? (
                    <InputNumber
                      value={editValues.distance}
                      onChange={(e) =>
                        setEditValues({ ...editValues, distance: e.value })
                      }
                    />
                  ) : (
                    attack.attack.distance
                  )}
                </td>
                <td>
                  {editIndex === index ? (
                    <div>
                      {editValues.attackEffectList ? (
                        editValues.attackEffectList.map((effect, index2) => (
                          <div key={index2}>
                            <span className="field">
                              <label>Эффект:</label>
                              <Dropdown
                                value={effect.effect}
                                onChange={(e) =>
                                  setEditValues((prevEditValues) => ({
                                    ...prevEditValues,
                                    attackEffectList:
                                      prevEditValues.attackEffectList.map(
                                        (item, idx) =>
                                          idx === index2
                                            ? {
                                                ...item,
                                                effect: e.target.value,
                                              }
                                            : item
                                      ),
                                  }))
                                }
                                optionLabel="label"
                                options={effectOptions}
                                placeholder="Тип субстанции"
                              />
                            </span>
                            <span className="field">
                              <label>Наносит урон?:</label>
                              <input
                                type="checkbox"
                                checked={effect.isDealDamage}
                                onChange={(e) =>
                                  setEditValues((prevEditValues) => ({
                                    ...prevEditValues,
                                    attackEffectList:
                                      prevEditValues.attackEffectList.map(
                                        (item, idx) =>
                                          idx === index2
                                            ? {
                                                ...item,
                                                isDealDamage: e.target.checked,
                                              }
                                            : item
                                      ),
                                  }))
                                }
                              />
                            </span>
                            <span className="field">
                              <label>Проценты:</label>
                              <input
                                type="number"
                                min="1"
                                max="100"
                                value={effect.chancePercent}
                                onChange={(e) =>
                                  setEditValues((prevEditValues) => ({
                                    ...prevEditValues,
                                    attackEffectList:
                                      prevEditValues.attackEffectList.map(
                                        (item, idx) =>
                                          idx === index2
                                            ? {
                                                ...item,
                                                chancePercent: parseInt(
                                                  e.target.value
                                                ),
                                              }
                                            : item
                                      ),
                                  }))
                                }
                              />
                            </span>
                            <span className="field">
                              <label>Урон:</label>
                              <input
                                type="text"
                                value={effect.damage}
                                onChange={(e) =>
                                  setEditValues((prevEditValues) => ({
                                    ...prevEditValues,
                                    attackEffectList:
                                      prevEditValues.attackEffectList.map(
                                        (item, idx) =>
                                          idx === index2
                                            ? {
                                                ...item,
                                                damage: e.target.value,
                                              }
                                            : item
                                      ),
                                  }))
                                }
                              />
                            </span>
                            <button
                              type="button"
                              onClick={(e) => {
                                e.preventDefault();
                                let updatedAttack = editValues;
                                let updatedEffects = [
                                  ...updatedAttack.attackEffectList,
                                ];

                                updatedEffects.splice(index2, 1);
                                updatedAttack = {
                                  ...updatedAttack,
                                  attackEffectList: updatedEffects,
                                };

                                setEditValues(updatedAttack);
                                //setEditIndex(null);
                              }}
                            >
                              Убрать эффект
                            </button>
                          </div>
                        ))
                      ) : (
                        <div></div>
                      )}
                      <Button
                        icon="pi pi-plus"
                        type="button"
                        onClick={(e) => {
                          e.preventDefault();
                          const newEffect: IAttackEffectList = {
                            id: 0,
                            chancePercent: 0,
                            damage: "0к0",
                            isDealDamage: false,
                            effect: null,
                          };
                          setEditValues((prevEditValues) => ({
                            ...prevEditValues,
                            attackEffectList: [
                              ...prevEditValues.attackEffectList,
                              newEffect,
                            ],
                          })); // Добавляем новый эффект в конец массива
                        }}
                      />
                    </div>
                  ) : (
                    <div>
                      {attack.attack.attackEffectList.length > 0
                        ? attack.attack.attackEffectList.map(
                            (effect, index) => (
                              <div className="flex flex-wrap">
                                <div key={index}>
                                  {effect.effect.name} (
                                  {effect.isDealDamage ? (
                                    effect.damage
                                  ) : (
                                    <div>{effect.chancePercent}%</div>
                                  )}
                                  )
                                </div>
                              </div>
                            )
                          )
                        : "-"}
                    </div>
                  )}
                </td>
                <td>
                  {editIndex === index ? (
                    <InputNumber
                      value={editValues.attackSpeed}
                      onChange={(e) =>
                        setEditValues({ ...editValues, attackSpeed: e.value })
                      }
                    />
                  ) : (
                    attack.attack.attackSpeed
                  )}
                </td>
                {isEditMode ? (
                  <td className="flex flex-wrap w-min">
                    {editIndex === index ? (
                      <Button
                        icon="pi pi-check"
                        onClick={(e) => {
                          e.preventDefault();
                          const updatedAttacks = [...creatureAttacks];
                          updatedAttacks[index] = {
                            ...updatedAttacks[index],
                            attack: { ...editValues },
                          };
                          setCreatureAttacks(updatedAttacks);
                          setEditIndex(null);
                        }}
                      />
                    ) : (
                      <Button
                        icon="pi pi-pencil"
                        onClick={(e) => {
                          e.preventDefault();
                          handleEdit(index);
                        }}
                      />
                    )}
                    <Button
                      icon="pi pi-trash"
                      onClick={(e) => {
                        e.preventDefault();
                        const updatedAttacks = [...creatureAttacks];
                        updatedAttacks.splice(index, 1); // Удаляем элемент по индексу index
                        setCreatureAttacks(updatedAttacks);
                      }}
                    />
                  </td>
                ) : (
                  ""
                )}
              </tr>
            ))}
            {isEditMode ? (
              <tr>
                <td>
                  <Button
                    label="Добавить"
                    onClick={(e) => {
                      e.preventDefault();
                      const newAttack: ICreatureAttack = {
                        // Создаем новый объект атаки
                        id: 0,
                        attack: {
                          id: 0,
                          attackEffectList: [],
                          attackSpeed: 0,
                          attackType: 0,
                          baseAttack: 0,
                          creature: null,
                          damage: "0к0",
                          description: "Описание новой атаки",
                          distance: 0,
                          name: "Новая атака",
                          reliability: 0,
                          source: null,
                        },
                      };
                      setCreatureAttacks([...creatureAttacks, newAttack]); // Добавляем новую атаку в конец массива
                    }}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
          </tbody>
        </table>
      </div>
    </div>
  ) : (
    <div></div>
  );
};
