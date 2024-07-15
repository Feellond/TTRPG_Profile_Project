import React, { useEffect, useState } from "react";
import {
  Control,
  Controller,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
  UseFormSetValue,
} from "react-hook-form";
import { Checkbox } from "primereact/checkbox";
import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import { Component, ItemDTO } from "shared/models";
import { InputText } from "primereact/inputtext";
import { Dropdown, DropdownChangeEvent } from "primereact/dropdown";
import { SelectItem } from "primereact/selectitem";
import { SkillOptionsLoad } from "entities/BestiaryOptions";
import { EffectOptionsLoad, FindItemById, StealthOptionsLoad } from "entities/GeneralFunc";
import {
  ArmorEquipmentTypeLoad,
  ArmorTypeLoad,
  ComponentsTypeLoad,
  ItemOriginTypeLoad,
  SubstanceTypeLoad,
  WeaponAttackTypeLoad,
  WeaponEquipmentTypeLoad,
  WhereToFindTypeLoad,
} from "entities/ItemFunc/components/OptionsLoad";
import { Effect } from "shared/models/Additional";
import { Button } from "primereact/button";

interface ItemTypeSelectProps {
  data: ItemDTO;
  itemType: number;
  visible: boolean;
  register: UseFormRegister<FieldValues>;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  setValue: UseFormSetValue<FieldValues>;
}

const ItemTypeSelect = ({
  data,
  itemType,
  visible,
  register,
  control,
  getValues,
  setValue,
}: ItemTypeSelectProps) => {
  const [isAmmunitionChecked, setIsAmmunitionChecked] =
    useState<boolean>(false);
  const [isAlchemicalChecked, setIsAlchemicalChecked] =
    useState<boolean>(data.isAlchemical);

  const [componentsOptions, setComponentsOptions] = useState<SelectItem[]>([]);
  const [skillOptions, setSkillOptions] = useState<SelectItem[]>([]);
  const [stealthOptions, setStealthOptions] = useState<SelectItem[]>([]);
  const [itemOriginOptions, setItemOriginOptions] = useState<SelectItem[]>([]);
  const [armorOptions, setArmorOptions] = useState<SelectItem[]>([]);
  const [whereToFindOptions, setWhereToFindOptions] = useState<SelectItem[]>(
    []
  );
  const [weaponTypeOptions, setWeaponTypeOptions] = useState<SelectItem[]>([]);
  const [weaponEquipmentOptions, setWeaponEquipmentOptions] = useState<SelectItem[]>([]);

  const [effectOptions, setEffectOptions] = useState<SelectItem[]>([]);
  const [substanceOptions, setSubstanceOptions] = useState<SelectItem[]>([]);
  const [armorEquipmentOptions, setArmorEquipmentOptions] = useState<
    SelectItem[]
  >([]);
  const [Content, setContent] = useState<any>();

  const [substances, setSubstances] = useState(data.formulaSubstanceList || []);
  const [components, setComponents] = useState(
    data.blueprintComponentList || []
  );
  const [effects, setEffects] = useState(data.itemBaseEffectList || []);

  useEffect(() => {
    ComponentsTypeLoad({ setItems: setComponentsOptions });
    SkillOptionsLoad({ setItems: setSkillOptions });
    StealthOptionsLoad({ setItems: setStealthOptions });
    ItemOriginTypeLoad({ setItems: setItemOriginOptions });
    ArmorTypeLoad({ setItems: setArmorOptions });
    ArmorEquipmentTypeLoad({ setItems: setArmorEquipmentOptions });
    WhereToFindTypeLoad({ setItems: setWhereToFindOptions });
    SubstanceTypeLoad({ setItems: setSubstanceOptions });
    EffectOptionsLoad({ setItems: setEffectOptions });
    WeaponAttackTypeLoad({ setItems: setWeaponTypeOptions });
    WeaponEquipmentTypeLoad({setItems: setWeaponEquipmentOptions})

    setSubstances(data.formulaSubstanceList);
    setComponents(data.blueprintComponentList);
    setEffects(data.itemBaseEffectList);
  }, [visible]);

  useEffect(() => {
    setValue("itemBaseEffectList", effects);
  }, [effects]);

  const handleAddEffect = () => {
    const initialEffects = effects || [];
    setEffects((effects) => [
      ...initialEffects,
      {
        id: 0,
        chancePercent: 0,
        damage: "",
        effect: null,
        isDealDamage: false,
      },
    ]);
  };

  const handleRemoveEffect = (index: number) => {
    const newEffects = [...effects];
    newEffects.splice(index, 1);
    setEffects(newEffects);
  };

  const handleEffectPercentChange = (index: number, percent: number) => {
    const newEffects = [...effects];
    newEffects[index].chancePercent = percent;
    setEffects(newEffects);
  };

  const handleEffectDamageChange = (index: number, damage: string) => {
    const newEffects = [...effects];
    newEffects[index].damage = damage;
    setEffects(newEffects);
  };

  const handleEffectTypeChange = (index: number, effect: Effect) => {
    const newEffects = [...effects];
    newEffects[index].effect = effect;
    setEffects(newEffects);
  };

  const handleEffectIsDealDamageChange = (
    index: number,
    isDealDamage: boolean
  ) => {
    const newEffects = [...effects];
    newEffects[index].isDealDamage = isDealDamage;
    setEffects(newEffects);
  };

  useEffect(() => {
    switch (itemType) {
      case 1:
        setContent(<div></div>);
        break;
      case 2:
        setContent(ToolItem());
        break;
      case 3:
        setContent(AlchemicalItem());
        break;
      case 4:
        setContent(ArmorItem());
        break;
      case 5:
        setContent(WeaponItem());
        break;
      case 6:
        setContent(FormulaItem());
        break;
      case 7:
        setContent(BlueprintItem());
        break;
      case 8:
        setContent(Item());
        break;
      case 9:
      case 10:
        if (itemType === 9) {
          setIsAlchemicalChecked(false);
          setValue("isAlchemical", false);
        } else if (itemType === 10) {
          setIsAlchemicalChecked(true);
          setValue("isAlchemical", true);
        }
        setContent(ComponentItem());
        break;
      default:
        setContent(<div></div>);
    }
  }, [
    itemType,
    isAmmunitionChecked,
    data,
    substances,
    components,
    effects,
    isAlchemicalChecked,

    componentsOptions,
    skillOptions,
    stealthOptions,
    itemOriginOptions,
    armorOptions,
    whereToFindOptions,
    weaponTypeOptions,
    effectOptions,
    substanceOptions,
    armorEquipmentOptions,
  ]);

  const WeaponItem = () => {
    return (
      <div>
        <div className="field flex align-items-center">
          <Checkbox
            onChange={(e) => {
              setIsAmmunitionChecked(e.checked);
              setValue("isAmmunition", e.checked);
              //setValue("isAmmunition", e.checked);
            }}
            checked={isAmmunitionChecked}
          />
          <label className="ml-2">Боеприпас?</label>
        </div>
        <span className="field">
          <label>Тип оружия</label>
          <Controller
            name="equipmentType"
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
                  options={weaponEquipmentOptions}
                  placeholder="Выберите тип оружия"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Тип урона оружия</label>
          <Controller
            name="type"
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
                  options={weaponTypeOptions}
                  placeholder="Выберите тип урона оружия"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Точность</label>
          <InputNumber
            min={-100}
            max={100}
            placeholder="Число"
            value={data.accuracy}
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("accuracy", e.target.value);
            }}
          />
        </span>
        <span className="field">
          <label>Урон</label>
          <Controller
            name="damage"
            control={control}
            render={({ field }) => (
              <>
                <InputText
                  placeholder="2к4+2"
                  id={field.name}
                  value={field.value}
                  onChange={(e) => {
                    field.onChange(e.target.value);
                  }}
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Надежность</label>
          <InputNumber
            id="number-input"
            value={data.reliability}
            min={0}
            max={999}
            placeholder="Число"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("reliability", e.target.value );
            }}
          />
        </span>
        <span className="field">
          <label>Хват</label>
          <InputNumber
            id="number-input"
            value={data.grip}
            min={0}
            max={4}
            placeholder="Число"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("grip",e.target.value );
            }}
          />
        </span>
        <span className="field">
          <label>Дистанция</label>
          <InputNumber
            //value={getValues("distance")}
            value={data.distance}
            placeholder="Число"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("distance", e.target.value );
              //setValue("distance", e.target.value);
            }}
          ></InputNumber>
        </span>
        <span className="field">
          <label>Тип скрытности</label>
          <Controller
            name="stealthType"
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
                  options={stealthOptions}
                  placeholder="Выберите тип скрытности"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Количество улучшений</label>
          <InputNumber
            value={data.amountOfEnhancements}
            placeholder="Число"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("amountOfEnhancements",e.target.value);
            }}
          ></InputNumber>
        </span>
        <span className="field">
          <label>Используемый навык</label>
          <Controller
            name="skill"
            control={control}
            render={({ field }) => (
              <>
                <Dropdown
                  id={field.name}
                  value={FindItemById(skillOptions, field.value?.id)}
                  onChange={(e: DropdownChangeEvent) => {
                    field.onChange(e.value);
                  }}
                  optionLabel="label"
                  options={skillOptions}
                  placeholder="Выберите навык"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Раса создателя</label>
          <Controller
            name="itemOriginType"
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
                  options={itemOriginOptions}
                  placeholder="Выберите расу создателя"
                />
              </>
            )}
          />
        </span>
        <div>
          <span className="field">
            <label>Список эффектов:</label>
            <div>
              {effects ? (
                effects.map((effect, index) => (
                  <div key={index} className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative">
                    <div className="field mt-3">
                      <span className="field">
                        <label>Эффект {index + 1}:</label>
                        <Dropdown
                          value={effect.effect}
                          onChange={(e) =>
                            handleEffectTypeChange(index, e.target.value)
                          }
                          optionLabel="label"
                          options={effectOptions}
                          placeholder="Выберите тип субстанции"
                        />
                      </span>
                    </div>
                    <div className="flex align-items-center">
                      <span className="field flex align-items-center">
                        <label>Наносит урон?:</label>
                        <Checkbox
                          className="ml-1"
                          checked={effect.isDealDamage}
                          onChange={(e) =>
                            handleEffectIsDealDamageChange(
                              index,
                              e.target.checked
                            )
                          }
                        />
                      </span>
                    </div>
                    {!effect.isDealDamage ? (
                    <div className="field">
                      <span className="field">
                        <label>Проценты:</label>
                        <InputNumber
                          value={effect.chancePercent}
                          onChange={(e) =>
                            handleEffectPercentChange(index, e.value)
                          }
                        />
                      </span>
                    </div>
                    ) : ""}
                    {effect.isDealDamage ? (
                    <div className="field">
                      <span className="field">
                        <label>Урон:</label>
                        <InputText
                          value={effect.damage}
                          onChange={(e) =>
                            handleEffectDamageChange(index, e.target.value)
                          }
                        />
                      </span>
                    </div>) : ""}
                    <Button
                      className="max-w-max absolute top-0 right-0 h-2rem w-1"
                      icon="pi pi-trash"
                      onClick={(e) => {
                        e.preventDefault();
                        handleRemoveEffect(index);
                      }}
                    >
                    </Button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <Button
                className="max-w-max"
                onClick={(e) => {
                  e.preventDefault();
                  handleAddEffect();
                }}
              >
                Добавить эффект
              </Button>
            </div>
          </span>
        </div>
      </div>
    );
  };

  const ArmorItem = () => {
    return (
      <div>
        <span className="field">
          <label>Тип брони</label>
          <Controller
            name="type"
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
                  options={armorOptions}
                  placeholder="Выберите тип брони"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Тип снаряжения</label>
          <Controller
            name="equipmentType"
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
                  options={armorEquipmentOptions}
                  placeholder="Выберите тип снаряжения"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Надежность</label>
          <InputNumber
            value={data.reliability}
            min={0}
            max={999}
            placeholder="Число надежности"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("reliability", e.target.value);
            }}
          />
        </span>
        <span className="field">
          <label>Количество улучшений</label>
          <InputNumber
            value={data.amountOfEnhancements}
            min={0}
            max={99}
            placeholder="Число возможных улучшений"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("amountOfEnhancements", e.target.value);
            }}
          />
        </span>
        <span className="field">
          <label>Скованность движений</label>
          <InputNumber
            value={data.stiffness}
            min={0}
            max={99}
            placeholder="Число скованности"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("stiffness", e.target.value );
            }}
          />
        </span>
        <span className="field">
          <label>Раса создателя</label>
          <Controller
            name="itemOriginType"
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
                  options={itemOriginOptions}
                  placeholder="Выберите расу создателя"
                />
              </>
            )}
          />
        </span>
        <div>
          <span className="field">
            <label>Список эффектов:</label>
            <div>
              {effects ? (
                effects.map((effect, index) => (
                  <div key={index} className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative">
                    <div className="field mt-3">
                      <span className="field">
                        <label>Эффект {index + 1}:</label>
                        <Dropdown
                          value={effect.effect}
                          onChange={(e) =>
                            handleEffectTypeChange(index, e.target.value)
                          }
                          optionLabel="label"
                          options={effectOptions}
                          placeholder="Выберите тип субстанции"
                        />
                      </span>
                    </div>
                    <div className="flex align-items-center">
                      <span className="field flex align-items-center">
                        <label>Наносит урон?:</label>
                        <Checkbox
                          className="ml-1"
                          checked={effect.isDealDamage}
                          onChange={(e) =>
                            handleEffectIsDealDamageChange(
                              index,
                              e.target.checked
                            )
                          }
                        />
                      </span>
                    </div>
                    {!effect.isDealDamage ? (
                    <div className="field">
                      <span className="field">
                        <label>Проценты:</label>
                        <InputNumber
                          value={effect.chancePercent}
                          onChange={(e) =>
                            handleEffectPercentChange(index, e.value)
                          }
                        />
                      </span>
                    </div>
                    ) : ""}
                    {effect.isDealDamage ? (
                    <div className="field">
                      <span className="field">
                        <label>Урон:</label>
                        <InputText
                          value={effect.damage}
                          onChange={(e) =>
                            handleEffectDamageChange(index, e.target.value)
                          }
                        />
                      </span>
                    </div>) : ""}
                    <Button
                      className="max-w-max absolute top-0 right-0 h-2rem w-1"
                      icon="pi pi-trash"
                      onClick={(e) => {
                        e.preventDefault();
                        handleRemoveEffect(index);
                      }}
                    >
                    </Button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <Button
                className="max-w-max"
                onClick={(e) => {
                  e.preventDefault();
                  handleAddEffect();
                }}
              >
                Добавить эффект
              </Button>
            </div>
          </span>
        </div>
      </div>
    );
  };

  const ToolItem = () => {
    return (
      <div>
        <span className="field">
          <label>Тип скрытности</label>
          <Controller
            name="stealthType"
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
                  options={stealthOptions}
                  placeholder="Выберите тип скрытности"
                />
              </>
            )}
          />
        </span>
      </div>
    );
  };

  const AlchemicalItem = () => {
    return (
      <div>
        <div>
          <span className="field">
            <label>Список эффектов:</label>
            <div>
              {effects ? (
                effects.map((effect, index) => (
                  <div key={index} className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative">
                    <div className="field mt-3">
                      <span className="field">
                        <label>Эффект {index + 1}:</label>
                        <Dropdown
                          value={effect.effect}
                          onChange={(e) =>
                            handleEffectTypeChange(index, e.target.value)
                          }
                          optionLabel="label"
                          options={effectOptions}
                          placeholder="Выберите тип субстанции"
                        />
                      </span>
                    </div>
                    <div className="flex align-items-center">
                      <span className="field flex align-items-center">
                        <label>Наносит урон?:</label>
                        <Checkbox
                          className="ml-1"
                          checked={effect.isDealDamage}
                          onChange={(e) =>
                            handleEffectIsDealDamageChange(
                              index,
                              e.target.checked
                            )
                          }
                        />
                      </span>
                    </div>
                    {!effect.isDealDamage ? (
                    <div className="field">
                      <span className="field">
                        <label>Проценты:</label>
                        <InputNumber
                          value={effect.chancePercent}
                          onChange={(e) =>
                            handleEffectPercentChange(index, e.value)
                          }
                        />
                      </span>
                    </div>
                    ) : ""}
                    {effect.isDealDamage ? (
                    <div className="field">
                      <span className="field">
                        <label>Урон:</label>
                        <InputText
                          value={effect.damage}
                          onChange={(e) =>
                            handleEffectDamageChange(index, e.target.value)
                          }
                        />
                      </span>
                    </div>) : ""}
                    <Button
                      className="max-w-max absolute top-0 right-0 h-2rem w-1"
                      icon="pi pi-trash"
                      onClick={(e) => {
                        e.preventDefault();
                        handleRemoveEffect(index);
                      }}
                    >
                    </Button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <Button
                className="max-w-max"
                onClick={(e) => {
                  e.preventDefault();
                  handleAddEffect();
                }}
              >
                Добавить эффект
              </Button>
            </div>
          </span>
        </div>
      </div>
    );
  };

  const Item = () => {
    return (
      <div>
        <span className="field">
          <label>Тип скрытности</label>
          <Controller
            name="stealthType"
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
                  options={stealthOptions}
                  placeholder="Выберите тип скрытности"
                />
              </>
            )}
          />
        </span>
      </div>
    );
  };

  useEffect(() => {
    setValue("formulaSubstanceList", substances );
  }, [substances]);

  const handleAddSubstance = () => {
    const initialSubstances = substances || [];
    setSubstances((substances) => [
      ...initialSubstances,
      { id: 0, substanceType: 1, amount: 0 },
    ]);
  };

  const handleRemoveSubstance = (index: number) => {
    const newSubstances = [...substances];
    newSubstances.splice(index, 1);
    setSubstances(newSubstances);
  };

  const handleSubstanceTypeChange = (index: number, substanceType: number) => {
    const newSubstances = [...substances];
    newSubstances[index].substanceType = substanceType;
    setSubstances(newSubstances);
  };

  const handleAmountSubstanceChange = (index: number, amount: number) => {
    const newSubstances = [...substances];
    newSubstances[index].amount = amount;
    setSubstances(newSubstances);
  };

  const FormulaItem = () => {
    return (
      <div>
        <div>
          <span className="field">
            <label>Сложность</label>
            <InputNumber
              value={data.complexity}
              min={0}
              max={999}
              placeholder="Число сложности"
              onValueChange={(e: InputNumberValueChangeEvent) => {
                setValue("complexity", e.target.value );
              }}
            />
          </span>
        </div>
        <div>
          <span className="field">
            <label>Требуемое время изготовления</label>
            <InputNumber
              value={data.timeSpend}
              min={0}
              max={999999}
              placeholder="Время изготовления"
              onValueChange={(e: InputNumberValueChangeEvent) => {
                setValue("timeSpend", e.target.value );
              }}
            />
          </span>
        </div>
        <div>
          <span className="field">
            <label>Доплата</label>
            <InputNumber
              value={data.additionalPayment}
              min={0}
              max={999999}
              placeholder="Число доплаты"
              onValueChange={(e: InputNumberValueChangeEvent) => {
                setValue("additionalPayment", e.target.value );
              }}
            />
          </span>
        </div>
        <div>
          <span className="field">
            <label>Список субстанций:</label>
            <div>
              {substances ? (
                substances.map((substance, index) => (
                  <div key={index} className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative">
                    <div className="field mt-3">
                      <label>Тип субстацнии {index + 1}:</label>
                      <Dropdown
                        value={substance.substanceType}
                        onChange={(e) =>
                          handleSubstanceTypeChange(
                            index,
                            parseInt(e.target.value)
                          )
                        }
                        optionLabel="label"
                        options={substanceOptions}
                        placeholder="Выберите тип субстанции"
                      />
                    </div>
                    <span className="field">
                      <label>Количество:</label>
                      <InputNumber
                        value={substance.amount}
                        onChange={(e) =>
                          handleAmountSubstanceChange(
                            index,
                            e.value
                          )
                        }
                      />
                    </span>
                    <Button
                      className="max-w-max absolute top-0 right-0 h-2rem w-1"
                      icon="pi pi-trash"
                      onClick={(e) => {
                        e.preventDefault();
                        handleRemoveSubstance(index);
                      }}
                    >
                    </Button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <Button
                className="max-w-max"
                onClick={(e) => {
                  e.preventDefault();
                  handleAddSubstance();
                }}
              >
                Добавить субстанцию
              </Button>
            </div>
          </span>
        </div>
      </div>
    );
  };

  useEffect(() => {
    setValue("blueprintComponentList", components);
  }, [components]);

  const handleAddComponent = () => {
    const initialComponents = components || [];
    setComponents((components) => [
      ...initialComponents,
      { id: 0, component: null, amount: 0 },
    ]);
  };

  const handleRemoveComponent = (index: number) => {
    const newComponents = [...components];
    newComponents.splice(index, 1);
    setComponents(newComponents);
  };

  const handleComponentTypeChange = (index: number, component: Component) => {
    const newComponents = [...components];
    newComponents[index].component = component;
    setComponents(newComponents);
  };

  const handleAmountComponentChange = (index: number, amount: number) => {
    const newComponents = [...components];
    newComponents[index].amount = amount;
    setComponents(newComponents);
  };

  const BlueprintItem = () => {
    return (
      <div>
        <span className="field">
          <label>Сложность</label>
          <InputNumber
            value={data.complexity}
            min={0}
            max={999}
            placeholder="Число сложности"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("complexity", e.target.value );
            }}
          />
        </span>
        <span className="field">
          <label>Требуемое время изготовления</label>
          <InputNumber
            value={data.timeSpend}
            min={0}
            max={999999}
            placeholder="Время изготовления"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("timeSpend", e.target.value );
            }}
          />
        </span>
        <span className="field">
          <label>Доплата</label>
          <InputNumber
            value={data.additionalPayment}
            min={0}
            max={999999}
            placeholder="Число доплаты"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("additionalPayment", e.target.value );
            }}
          />
        </span>
        <span className="field">
          <label>Список компонентов: </label>
          <div>
            {components ? (
              components.map((component, index) => (
                <div key={index} className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative">
                  <div className="field mt-3">
                    <label>Компонент {index + 1}:</label>
                    <Dropdown
                      filter
                      value={FindItemById(componentsOptions, component.component?.id)}
                      onChange={(e) =>
                        handleComponentTypeChange(index, e.value)
                      }
                      optionLabel="label"
                      options={componentsOptions}
                      placeholder="Выберите компонент"
                    />
                  </div>
                  <span className="field">
                    <label>Количество:</label>
                    <InputNumber
                      value={component.amount}
                      onChange={(e) =>
                        handleAmountComponentChange(
                          index,
                          e.value
                        )
                      }
                    />
                  </span>
                  <Button
                      className="max-w-max absolute top-0 right-0 h-2rem w-1"
                      icon="pi pi-trash"
                      onClick={(e) => {
                        e.preventDefault();
                        handleRemoveComponent(index);
                      }}
                    >
                    </Button>
                </div>
              ))
            ) : (
              <div></div>
            )}
            <Button
                className="max-w-max"
                onClick={(e) => {
                  e.preventDefault();
                  handleAddComponent();
                }}
              >
                Добавить компонент
              </Button>
          </div>
        </span>
      </div>
    );
  };

  const ComponentItem = () => {
    return (
      <div>
        <span className="field">
          <label>Где найти?</label>
          <Controller
            name="whereToFind"
            control={control}
            render={({ field }) => (
              <>
                <InputText
                  placeholder="Где найти?"
                  id={field.name}
                  value={field.value}
                  onChange={(e) => {
                    field.onChange(e.target.value);
                  }}
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Количество</label>
          <Controller
            name="amount"
            control={control}
            render={({ field }) => (
              <>
                <InputText
                  placeholder="Число, которое получит при сборе"
                  id={field.name}
                  value={field.value}
                  onChange={(e) => {
                    field.onChange(e.target.value);
                  }}
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Сложность</label>
          <InputNumber
            value={data.complexity}
            min={0}
            max={9999}
            placeholder="Число сложности"
            onValueChange={(e: InputNumberValueChangeEvent) => {
              setValue("complexity", e.target.value);
            }}
          />
        </span>
        {/* <div className="my-2">
          <Checkbox
            onChange={(e) => {
              setIsAlchemicalChecked(e.checked);
              setValue("isAlchemical", e.checked);
            }}
            checked={isAlchemicalChecked}
          />
          <label className="ml-2">Алхимический компонент?</label>
        </div> */}
        {isAlchemicalChecked ? (
          <span className="field">
            <label>Тип субстанции</label>
            <Controller
              name="substanceType"
              control={control}
              render={({ field }) => (
                <>
                  <Dropdown
                    id={field.name}
                    value={field.value}
                    showClear
                    onChange={(e: DropdownChangeEvent) => {
                      field.onChange(e.value);
                    }}
                    options={substanceOptions}
                    placeholder="Выберите тип субстанции"
                  />
                </>
              )}
            />
          </span>
        ) : (
          ""
        )}
      </div>
    );
  };

  return (
    <div style={{ visibility: visible ? "visible" : "hidden" }}>{Content}</div>
  );
};

export { ItemTypeSelect };
