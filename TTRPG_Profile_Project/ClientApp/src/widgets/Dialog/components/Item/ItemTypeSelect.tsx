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
import { EffectOptionsLoad, StealthOptionsLoad } from "entities/GeneralFunc";
import {
  ArmorEquipmentTypeLoad,
  ArmorTypeLoad,
  ComponentsTypeLoad,
  ItemOriginTypeLoad,
  SubstanceTypeLoad,
  WeaponAttackTypeLoad,
  WhereToFindTypeLoad,
} from "entities/ItemFunc/components/OptionsLoad";
import { Effect } from "shared/models/Additional";

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
    useState<boolean>(false);

    
  const [componentsOptions, setComponentsOptions] = useState<SelectItem[]>([]);
  const [skillOptions, setSkillOptions] = useState<SelectItem[]>([]);
  const [stealthOptions, setStealthOptions] = useState<SelectItem[]>([]);
  const [itemOriginOptions, setItemOriginOptions] = useState<SelectItem[]>([]);
  const [armorOptions, setArmorOptions] = useState<SelectItem[]>([]);
  const [whereToFindOptions, setWhereToFindOptions] = useState<SelectItem[]>(
    []
  );
  const [weaponTypeOptions, setWeaponTypeOptions] = useState<SelectItem[]>([]);

  const [effectOptions, setEffectOptions] = useState<SelectItem[]>([]);
  const [substanceOptions, setSubstanceOptions] = useState<SelectItem[]>([]);
  const [armorEquipmentOptions, setArmorEquipmentOptions] = useState<
    SelectItem[]
  >([]);
  const [Content, setContent] = useState<any>();

  const [substances, setSubstances] = useState(
    data.formulaSubstanceList || []
  );
  const [components, setComponents] = useState(
    data.blueprintComponentList || []
  );
  const [effects, setEffects] = useState(data.itemBaseEffectList || []);

  useEffect(() => {
    ComponentsTypeLoad({setItems: setComponentsOptions});
    SkillOptionsLoad({ setItems: setSkillOptions });
    StealthOptionsLoad({ setItems: setStealthOptions });
    ItemOriginTypeLoad({ setItems: setItemOriginOptions });
    ArmorTypeLoad({ setItems: setArmorOptions });
    ArmorEquipmentTypeLoad({ setItems: setArmorEquipmentOptions });
    WhereToFindTypeLoad({setItems: setWhereToFindOptions});
    SubstanceTypeLoad({setItems: setSubstanceOptions});
    EffectOptionsLoad({setItems: setEffectOptions});
    WeaponAttackTypeLoad({setItems: setWeaponTypeOptions});

    setSubstances(data.formulaSubstanceList);
    setComponents(data.blueprintComponentList);
    setEffects(data.itemBaseEffectList);
  }, [visible]);

  useEffect(() => {
    register("itemBaseEffectList", { value: effects });
  }, [effects]);

  const handleAddEffect = () => {
    const initialEffects = effects || [];
    setEffects(effects => [...initialEffects, { id: 0, chancePercent: 0, damage: "", effect: null, isDealDamage: false}]);
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

  const handleEffectIsDealDamageChange = (index: number, isDealDamage: boolean) => {
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
        setContent(ComponentItem());
        break;
      case 9:
        setContent(Item());
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
              register("isAmmunition", { value: e.checked });
              //setValue("isAmmunition", e.checked);
            }}
            checked={isAmmunitionChecked}
          />
          <label className="ml-2">Боеприпас?</label>
        </div>
        <span className="field">
          <label>Тип оружия</label>
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
              register("accuracy", { value: e.target.value });
            }}
          />
        </span>
        <span className="field">
          <label>Урон</label>
          <InputText
            placeholder="2к4+2"
            value={data.damage}
            {...register("damage")}
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
              register("reliability", { value: e.target.value });
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
              register("grip", { value: e.target.value });
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
              register("distance", { value: e.target.value });
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
                  value={field.value}
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
        <div>
          <span className="field">
            <label>Список эффектов:</label>
            <div>
              {effects ? (
                effects.map((effect, index) => (
                  <div key={index}>
                    <span className="field">
                      <label>Эффект:</label>
                      <Dropdown
                        value={effect.effect}
                        onChange={(e) =>
                          handleEffectTypeChange(index, e.target.value)
                        }
                        optionLabel="label"
                        options={effectOptions}
                        placeholder="Выберите эффект"
                      />
                    </span>
                    <span className="field">
                      <label>Наносит урон?:</label>
                      <input
                        type="checkbox"
                        checked={effect.isDealDamage}
                        onChange={(e) =>
                          handleEffectIsDealDamageChange(
                            index,
                            e.target.checked
                          )
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
                          handleEffectPercentChange(
                            index,
                            parseInt(e.target.value)
                          )
                        }
                      />
                    </span>
                    <span className="field">
                      <label>Урон:</label>
                      <input
                        type="text"
                        value={effect.damage}
                        onChange={(e) =>
                          handleEffectDamageChange(index, e.target.value)
                        }
                      />
                    </span>
                    <button
                      type="button"
                      onClick={() => handleRemoveEffect(index)}
                    >
                      Убрать эффект
                    </button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <button type="button" onClick={handleAddEffect}>
                Добавить эффект
              </button>
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
              register("reliability", { value: e.target.value });
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
              register("amountOfEnhancements", { value: e.target.value });
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
              register("stiffness", { value: e.target.value });
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
                  <div key={index}>
                    <span className="field">
                      <label>Эффект:</label>
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
                    <span className="field">
                      <label>Наносит урон?:</label>
                      <input
                        type="checkbox"
                        checked={effect.isDealDamage}
                        onChange={(e) =>
                          handleEffectIsDealDamageChange(
                            index,
                            e.target.checked
                          )
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
                          handleEffectPercentChange(
                            index,
                            parseInt(e.target.value)
                          )
                        }
                      />
                    </span>
                    <span className="field">
                      <label>Урон:</label>
                      <input
                        type="text"
                        value={effect.damage}
                        onChange={(e) =>
                          handleEffectDamageChange(index, e.target.value)
                        }
                      />
                    </span>
                    <button
                      type="button"
                      onClick={() => handleRemoveEffect(index)}
                    >
                      Убрать эффект
                    </button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <button type="button" onClick={handleAddEffect}>
                Добавить эффект
              </button>
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
                  <div key={index}>
                    <span className="field">
                      <label>Эффект:</label>
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
                    <span className="field">
                      <label>Наносит урон?:</label>
                      <input
                        type="checkbox"
                        checked={effect.isDealDamage}
                        onChange={(e) =>
                          handleEffectIsDealDamageChange(
                            index,
                            e.target.checked
                          )
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
                          handleEffectPercentChange(
                            index,
                            parseInt(e.target.value)
                          )
                        }
                      />
                    </span>
                    <span className="field">
                      <label>Урон:</label>
                      <input
                        type="text"
                        value={effect.damage}
                        onChange={(e) =>
                          handleEffectDamageChange(index, e.target.value)
                        }
                      />
                    </span>
                    <button
                      type="button"
                      onClick={() => handleRemoveEffect(index)}
                    >
                      Убрать эффект
                    </button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <button type="button" onClick={handleAddEffect}>
                Добавить эффект
              </button>
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
    register("formulaSubstanceList", { value: substances });
  }, [substances]);

  const handleAddSubstance = () => {
    const initialSubstances = substances || [];
    setSubstances(substances => [...initialSubstances, { id: 0, substanceType: 1, amount: 0 }]);
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
                register("complexity", { value: e.target.value });
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
                register("timeSpend", { value: e.target.value });
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
                register("additionalPayment", { value: e.target.value });
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
                  <div key={index}>
                    <span className="field">
                      <label>Тип субстацнии:</label>
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
                    </span>
                    <span className="field">
                      <label>Количество:</label>
                      <input
                        type="number"
                        value={substance.amount}
                        onChange={(e) =>
                          handleAmountSubstanceChange(index, parseInt(e.target.value))
                        }
                      />
                    </span>
                    <button type="button" onClick={() => handleRemoveSubstance(index)}>
                      Убрать субстанцию
                    </button>
                  </div>
                ))
              ) : (
                <div></div>
              )}
              <button type="button" onClick={handleAddSubstance}>
                Добавить субстанцию
              </button>
            </div>
          </span>
        </div>
      </div>
    );
  };

  useEffect(() => {
    register("blueprintComponentList", { value: components });
  }, [components]);

  const handleAddComponent = () => {
    const initialComponents = components || [];
    setComponents(components => [...initialComponents, { id: 0, component: null, amount: 0 }]);
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
              register("complexity", { value: e.target.value });
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
              register("timeSpend", { value: e.target.value });
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
              register("additionalPayment", { value: e.target.value });
            }}
          />
        </span>
        <span className="field">
          <label>Список компонентов: </label>
          <div>
            {components ? (
              components.map((component, index) => (
                <div key={index}>
                  <span className="field">
                    <label>Компонент:</label>
                    <Dropdown
                        value={component.component}
                        onChange={(e) =>
                          handleComponentTypeChange(
                            index,
                            e.value
                          )
                        }
                        optionLabel="label"
                        options={componentsOptions}
                        placeholder="Выберите компонент"
                      />
                  </span>
                  <span className="field">
                    <label>Количество:</label>
                    <input
                      type="number"
                      value={component.amount}
                      onChange={(e) =>
                        handleAmountComponentChange(index, parseInt(e.target.value))
                      }
                    />
                  </span>
                  <button type="button" onClick={() => handleRemoveComponent(index)}>
                    Убрать компонент
                  </button>
                </div>
              ))
            ) : (
              <div></div>
            )}
            <button type="button" onClick={handleAddComponent}>
              Добавить компонент
            </button>
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
          {/* <Controller
            name="whereToFind"
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
                  options={whereToFindOptions}
                  placeholder="Выберите тип субстанции"
                />
              </>
            )}
          /> */}
          <InputText
            value={data.whereToFind}
            min={0}
            max={999}
            placeholder="Где найти?"
            {...register("amount")}
          />
        </span>
        <span className="field">
          <label>Количество</label>
          <InputText
            value={data.amount}
            min={0}
            max={999}
            placeholder="Число, сколько получит при сборе"
            {...register("amount")}
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
              register("complexity", { value: e.target.value });
              setValue("complexity",  e.target.value)
            }}
          />
        </span>
        <div className="my-2">
          <Checkbox
            onChange={(e) => {
              setIsAlchemicalChecked(e.checked);
              //register("isAlchemical", { value: e.checked });
              setValue("isAlchemical",  e.checked)
            }}
            checked={isAlchemicalChecked}
          />
          <label className="ml-2">Алхимический компонент?</label>
        </div>
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
      </div>
    );
  };

  return (
    <div style={{ visibility: visible ? "visible" : "hidden" }}>{Content}</div>
  );
};

export { ItemTypeSelect };
