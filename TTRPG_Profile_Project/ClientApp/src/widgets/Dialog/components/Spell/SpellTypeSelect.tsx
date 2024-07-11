import { SkillOptionsLoad } from "entities/BestiaryOptions";
import { SpellLevelOptionsLoad, SpellSourceTypeOptionsLoad } from "entities/SpellFunc";
import { Checkbox } from "primereact/checkbox";
import { Dropdown } from "primereact/dropdown";
import { InputNumber } from "primereact/inputnumber";
import { InputText } from "primereact/inputtext";
import { InputTextarea } from "primereact/inputtextarea";
import { SelectItem } from "primereact/selectitem";
import React, { useEffect, useState } from "react";
import {
  Control,
  Controller,
  FieldValues,
  UseFormGetValues,
  UseFormRegister,
  UseFormSetValue,
} from "react-hook-form";
import { ItemEntityType } from "shared/enums/ItemEnums";
import { SpellType } from "shared/enums/SpellEnums";
import { Component, ISkill, ISpell, ItemDTO } from "shared/models";
import itemService from "shared/services/item.service";

interface ISpellTypeSelect {
  data: ISpell;
  spellType: number;
  visible: boolean;
  register: UseFormRegister<FieldValues>;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  setValue: UseFormSetValue<FieldValues>;
}

export const SpellTypeSelect = ({
  data,
  spellType,
  visible,
  register,
  control,
  getValues,
  setValue,
}: ISpellTypeSelect) => {
  const [Content, setContent] = useState<any>();
  const [spellSourceOptions, setSpellSourceOptions] = useState<SelectItem[]>(
    []
  );
  const [spellLevelOptions, setSpellLevelOptions] = useState<SelectItem[]>([]);

  const [isConcentrationChecked, setIsConcentrationChecked] =
    useState<boolean>(false);
  const [isPriestSpellChecked, setIsPriestSpellChecked] =
    useState<boolean>(false);
  const [isDruidSpellChecked, setIsDruidSpellChecked] =
    useState<boolean>(false);

  const [skillOptions, setSkillOptions] = useState<SelectItem[]>([]);
  const [componentOptions, setComponentOptions] = useState<SelectItem[]>([]);

  const [spellSkills, setSpellSkills] = useState(
    data.spellSkillProtectionList || []
  );
  const [spellComponents, setSpellComponents] = useState(
    data.spellComponentList || []
  );

  const LoadComponents = async () => {
    try {
      let result = await itemService.getEntitys({
        itemType: ItemEntityType.ComponentRem, //ItemEntityType.BaseItem
        toast: null,
        params: { pageSize: 99999 },
      });

      if (result && result.data) {
        const entitys: ItemDTO[] = result.data.entitys;
        //setEntityList(entitys);

        const options = entitys.map((data, index) => ({
          name: data.name,
          label: data.name,
          value: data,
        }));

        setComponentOptions(options);
      }
    } catch (error) {
      console.error("Error fetching entitys:", error);
    }
  };

  useEffect(() => {
    SpellSourceTypeOptionsLoad({ setItems: setSpellSourceOptions });
    SpellLevelOptionsLoad({ setItems: setSpellLevelOptions });

    SkillOptionsLoad({ setItems: setSkillOptions });
    LoadComponents();
  }, []);

  useEffect(() => {
    switch (spellType) {
      case 1: //Заклинание, Инвокация, Знак
      case 2:
      case 3:
        setContent(SpellContent(spellType));
        break;
      case 4: //Ритуал
        setContent(RitualContent());
        break;
      case 5: //Порча
        setContent(HexContent());
        break;
      default:
        setContent(<div></div>);
    }
  }, [
    spellType,
    data,
    visible,
    spellSkills,
    spellComponents,
    isConcentrationChecked,
    isPriestSpellChecked,
    isDruidSpellChecked,
  ]);

  useEffect(() => {
    register("spellSkillProtectionList", { value: spellSkills });
  }, [spellSkills]);

  const handleAddSkill = () => {
    const initialSkills = spellSkills || [];
    setSpellSkills((spellSkills) => [
      ...initialSkills,
      { id: 0, moreInfo: "", skill: null },
    ]);
  };

  const handleRemoveSkill = (index: number) => {
    const newSpellSkills = [...spellSkills];
    newSpellSkills.splice(index, 1);
    setSpellSkills(newSpellSkills);
  };

  const handleSkillChange = (index: number, skill: ISkill) => {
    const newSpellSkills = [...spellSkills];
    newSpellSkills[index].skill = skill;
    setSpellSkills(newSpellSkills);
  };

  const handleSkillInfoChange = (index: number, text: string) => {
    const newSpellSkills = [...spellSkills];
    newSpellSkills[index].moreInfo = text;
    setSpellSkills(newSpellSkills);
  };

  const SpellContent = (spellType: number) => {
    return (
      <div>
        <span className="field">
          <label>Элемент заклинания</label>
          <Controller
            name="sourceType"
            control={control}
            render={({ field }) => (
              <>
                <Dropdown
                  id={field.name}
                  value={field.value}
                  onChange={(e) => {
                    field.onChange(e.value);
                  }}
                  optionLabel="label"
                  options={spellSourceOptions}
                  placeholder="Выберите элемент"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Уровень заклинания</label>
          <Controller
            name="spellLevel"
            control={control}
            render={({ field }) => (
              <>
                <Dropdown
                  id={field.name}
                  value={field.value}
                  onChange={(e) => {
                    field.onChange(e.value);
                  }}
                  optionLabel="label"
                  options={spellLevelOptions}
                  placeholder="Выберите уровень"
                />
              </>
            )}
          />
        </span>
        <span className="field">
          <label>Дистанция</label>
          <InputNumber
            value={data.distance}
            min={0}
            max={999}
            placeholder="Дист"
            onValueChange={(e) => {
              register("distance", { value: e.target.value });
            }}
          />
        </span>
        {spellType === SpellType.Invocation ? (
          <div className="field flex align-items-center">
            <Checkbox
              onChange={(e) => {
                setIsConcentrationChecked(e.checked);
                register("isDruidSpell", { value: e.checked });
                //setValue("isAmmunition", e.checked);
              }}
              checked={isDruidSpellChecked}
            />
            <label className="ml-2">Друидское заклинание?</label>
          </div>
        ) : (
          ""
        )}
        <div className="field flex align-items-center">
          <Checkbox
            onChange={(e) => {
              setIsConcentrationChecked(e.checked);
              register("isConcentration", { value: e.checked });
              //setValue("isAmmunition", e.checked);
            }}
            checked={isConcentrationChecked}
          />
          <label className="ml-2">Активное?</label>
        </div>
        {isConcentrationChecked ? (
          <span className="field">
            <label>Трата ВЫН в раунд</label>
            <InputNumber
              value={data.concentrationEnduranceCost}
              min={0}
              max={999}
              placeholder="ВЫН"
              onValueChange={(e) => {
                register("concentrationEnduranceCost", {
                  value: e.target.value,
                });
              }}
            />
          </span>
        ) : (
          <span className="field">
            <label>Длительность</label>
            <InputText
              placeholder="прим. 1к10 раундов"
              value={data.duration}
              {...register("duration")}
            />
          </span>
        )}
        <span>
          <label>Защита</label>
          <div>
            {spellSkills ? (
              spellSkills.map((spellSkill, index) => (
                <div key={index}>
                  <span className="field">
                    <label>Навык:</label>
                    <Dropdown
                      value={spellSkill.skill}
                      onChange={(e) => handleSkillChange(index, e.target.value)}
                      optionLabel="label"
                      options={skillOptions}
                      placeholder="Выберите навык"
                    />
                  </span>
                  <span className="field">
                    <label>Дополнительное описание:</label>
                    <InputTextarea
                      value={spellSkill.moreInfo}
                      onChange={(e) =>
                        handleSkillInfoChange(index, e.target.value)
                      }
                      rows={1}
                    />
                  </span>
                  <button
                    type="button"
                    onClick={() => handleRemoveSkill(index)}
                  >
                    Убрать навык
                  </button>
                </div>
              ))
            ) : (
              <div></div>
            )}
            <button type="button" onClick={handleAddSkill}>
              Добавить навык
            </button>
          </div>
        </span>
      </div>
    );
  };

  useEffect(() => {
    register("spellComponentList", { value: spellComponents });
  }, [spellComponents]);

  const handleAddComponent = () => {
    const initialComponents = spellComponents || [];
    setSpellComponents((spellComponents) => [
      ...initialComponents,
      { id: 0, amount: 0, component: null },
    ]);
  };

  const handleRemoveComponent = (index: number) => {
    const newSpellComponents = [...spellComponents];
    newSpellComponents.splice(index, 1);
    setSpellComponents(newSpellComponents);
  };

  const handleComponentChange = (index: number, component: Component) => {
    const newSpellComponents = [...spellComponents];
    newSpellComponents[index].component = component;
    setSpellComponents(newSpellComponents);
  };

  const handleAmountComponentChange = (index: number, amount: number) => {
    const newSpellComponents = [...spellComponents];
    newSpellComponents[index].amount = amount;
    setSpellComponents(newSpellComponents);
  };

  const RitualContent = () => {
    return (
      <div>
        <span>
          <label>Время подготовки</label>
          <InputNumber
            value={data.checkDC}
            min={0}
            max={999}
            placeholder="Время"
            onValueChange={(e) => {
              register("preparationTime", { value: e.target.value });
            }}
          />
        </span>
        <span>
          <label>СЛ проверки</label>
          <InputNumber
            value={data.checkDC}
            min={0}
            max={999}
            placeholder="СЛ"
            onValueChange={(e) => {
              register("checkDC", { value: e.target.value });
            }}
          />
        </span>
        <span>
          <label>Длительность</label>
          <InputText
            placeholder="прим. 1к10 раундов"
            value={data.duration}
            {...register("duration")}
          />
        </span>
        <span>
          <label>Компоненты</label>
          <div>
            {spellComponents ? (
              spellComponents.map((component, index) => (
                <div key={index}>
                  <span>
                    <label>Компонент:</label>
                    <Dropdown
                      value={component.component}
                      onChange={(e) =>
                        handleComponentChange(index, e.target.value)
                      }
                      optionLabel="label"
                      options={componentOptions}
                      placeholder="Выберите тип субстанции"
                    />
                  </span>
                  <span>
                    <label>Количество:</label>
                    <input
                      type="number"
                      value={component.amount}
                      onChange={(e) =>
                        handleAmountComponentChange(
                          index,
                          parseInt(e.target.value)
                        )
                      }
                    />
                  </span>
                  <button
                    type="button"
                    onClick={() => handleRemoveComponent(index)}
                  >
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

  const HexContent = () => {
    return (
      <div className="field flex flex-column">
        <span className="p-float-label">
          <InputTextarea
            value={data.withdrawalCondition}
            onChange={(e) => {
              register("withdrawalCondition", { value: e.target.value });
            }}
            rows={5}
            cols={60}
          />
          <label>Условие снятия</label>
        </span>
      </div>
    );
  };

  return (
    <div style={{ visibility: visible ? "visible" : "hidden" }}>{Content}</div>
  );
};
