import { SkillOptionsLoad } from "entities/BestiaryOptions";
import { FindItemById } from "entities/GeneralFunc";
import {
  SpellLevelOptionsLoad,
  SpellSourceTypeOptionsLoad,
} from "entities/SpellFunc";
import { Button } from "primereact/button";
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
    useState<boolean>(data.isConcentration);
  const [isPriestSpellChecked, setIsPriestSpellChecked] =
    useState<boolean>(data.isPriestSpell);
  const [isDruidSpellChecked, setIsDruidSpellChecked] =
    useState<boolean>(data.isDruidSpell);

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

    skillOptions,
    spellSourceOptions,
    spellLevelOptions,
  ]);

  useEffect(() => {
    setValue("spellSkillProtectionList", spellSkills);
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
        <div className="mb-1">
          <label className="mb-1">Элемент заклинания</label>
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
        </div>
        <div className="mb-1">
          <label className="mb-1">Уровень заклинания</label>
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
        </div>
        <div className="mb-1">
          <label className="mb-1">Дистанция</label>
          <InputNumber
            value={data.distance}
            min={0}
            max={999}
            placeholder="Дист"
            onValueChange={(e) => {
              setValue("distance", e.target.value);
            }}
          />
        </div>
        {spellType === SpellType.Invocation ? (
          <div className="mb-1 flex align-items-center">
            <Checkbox
              onChange={(e) => {
                setIsDruidSpellChecked(e.checked);
                setValue("isDruidSpell", e.checked);
                //setValue("isAmmunition", e.checked);
              }}
              checked={isDruidSpellChecked}
            />
            <label className="ml-2">Друидское заклинание?</label>
          </div>
        ) : (
          ""
        )}
        <div className="mb-1 flex align-items-center">
          <Checkbox
            onChange={(e) => {
              setIsConcentrationChecked(e.checked);
              setValue("isConcentration", e.checked);
              //setValue("isAmmunition", e.checked);
            }}
            checked={isConcentrationChecked}
          />
          <label className="ml-2">Активное?</label>
        </div>
        {isConcentrationChecked ? (
          <span className="mb-1">
            <label className="mb-1">Трата Выносливости в раунд</label>
            <InputNumber
              value={data.concentrationEnduranceCost}
              min={0}
              max={999}
              placeholder="ВЫН"
              onValueChange={(e) => {
                setValue("concentrationEnduranceCost", e.target.value);
              }}
            />
          </span>
        ) : (
          <span className="mb-1">
            <label className="mb-1">Длительность</label>
            <InputText
              placeholder="прим. 1к10 раундов"
              value={data.duration}
              onChange={(e) => {
                setValue("duration", e.target.value);
              }}
            />
          </span>
        )}
        <span>
          <label>Защита</label>
          <div>
            {spellSkills ? (
              spellSkills.map((spellSkill, index) => (
                <div
                  key={index}
                  className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative"
                >
                  <div className="field mt-3">
                    <label>Навык {index + 1}:</label>
                    <Dropdown
                      value={FindItemById(skillOptions, spellSkill.skill?.id)}
                      onChange={(e) => handleSkillChange(index, e.target.value)}
                      optionLabel="label"
                      options={skillOptions}
                      placeholder="Выберите навык"
                      filter
                    />
                  </div>
                  <div className="field">
                    <label>Дополнительное описание:</label>
                    <InputTextarea
                      value={spellSkill.moreInfo}
                      onChange={(e) =>
                        handleSkillInfoChange(index, e.target.value)
                      }
                      rows={1}
                    />
                  </div>
                  <Button
                    className="max-w-max absolute top-0 right-0 h-2rem w-1"
                    icon="pi pi-trash"
                    onClick={(e) => {
                      e.preventDefault();
                      handleRemoveSkill(index);
                    }}
                  ></Button>
                </div>
              ))
            ) : (
              <div></div>
            )}
            <Button
              className="max-w-max"
              onClick={(e) => {
                e.preventDefault();
                handleAddSkill();
              }}
            >
              Добавить навык
            </Button>
          </div>
        </span>
      </div>
    );
  };

  useEffect(() => {
    setValue("spellComponentList", spellComponents);
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
              setValue("preparationTime", e.target.value);
            }}
          />
        </span>
        <span>
          <label>Сложность проверки</label>
          <InputNumber
            value={data.checkDC}
            min={0}
            max={999}
            placeholder="СЛ"
            onValueChange={(e) => {
              setValue("checkDC", e.target.value);
            }}
          />
        </span>
        <span>
          <label>Длительность</label>
          <InputText
            placeholder="прим. 1к10 раундов"
            value={data.duration}
            onChange={(e) => {
              setValue("duration", e.target.value);
            }}
          />
        </span>
        <span>
          <label>Компоненты</label>
          <div>
            {spellComponents ? (
              spellComponents.map((component, index) => (
                <div
                  key={index}
                  className="border-1 p-2 align-items-center border-1 mb-2 justify-content-center relative"
                >
                  <div className="field mt-3">
                    <label>Компонент:</label>
                    <Dropdown
                      value={FindItemById(componentOptions, component.component?.id)}
                      onChange={(e) =>
                        handleComponentChange(index, e.target.value)
                      }
                      optionLabel="label"
                      options={componentOptions}
                      placeholder="Выберите компонент"
                      filter
                    />
                  </div>
                  <div className="field">
                    <label>Количество:</label>
                    <InputNumber
                      value={component.amount}
                      onChange={(e) =>
                        handleAmountComponentChange(index, e.value)
                      }
                    />
                  </div>
                  <Button
                    className="max-w-max absolute top-0 right-0 h-2rem w-1"
                    icon="pi pi-trash"
                    onClick={(e) => {
                      e.preventDefault();
                      handleRemoveComponent(index);
                    }}
                  ></Button>
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

  const HexContent = () => {
    return (
      <div className="field flex flex-column">
        <span className="p-float-label">
          <InputTextarea
            value={data.withdrawalCondition}
            onChange={(e) => {
              setValue("withdrawalCondition", e.target.value);
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
