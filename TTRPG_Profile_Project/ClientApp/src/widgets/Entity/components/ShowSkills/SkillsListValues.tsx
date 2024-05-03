import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import React, { useEffect, useState } from "react";
import { Control, Controller, FieldValues } from "react-hook-form";
import { ISkillsList, IStatsList } from "shared/models";

interface IShowValue {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  setSkillsList: React.Dispatch<React.SetStateAction<ISkillsList>>;

  control: Control<FieldValues, any>;
  isEditMode: boolean;
}

//#region Интеллект

export const ShowAttentionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [attentionValue, setAttentionValue] = useState<number | null>(0);

  // const handleChange = (value: number) => {
  //   const updatedSkills = { ...skillsList, attentionValue: value };
  //   setSkillsList(updatedSkills); // Обновить statList
  //   setAttentionValue(statList?.intellectValue + skillsList?.attentionValue);
  // };

  useEffect(() => {
    setAttentionValue(statList?.intellectValue + skillsList?.attentionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.attentionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, attentionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setAttentionValue(statList?.intellectValue + skillsList?.attentionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      {/* <span> = {String(getValues("statList.intellectValue") + getValues("statsList.attentionValue"))}</span> */}
      <span> = {attentionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.attentionValue + statList?.intellectValue}</div>
  );
};

export const ShowSurvivalValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [survivalValue, setSurvivalValue] = useState<number | null>(0);

  useEffect(() => {
    setSurvivalValue(statList?.intellectValue + skillsList?.survivalValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.survivalValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, survivalValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setSurvivalValue(statList?.intellectValue + skillsList?.survivalValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {survivalValue}</span>
    </div>
  ) : (
    <div>{skillsList?.survivalValue + statList?.intellectValue}</div>
  );
};

export const ShowDeductionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [deductionValue, setDeductionValue] = useState<number | null>(0);

  useEffect(() => {
    setDeductionValue(statList?.intellectValue + skillsList?.deductionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.deductionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, deductionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setDeductionValue(statList?.intellectValue + skillsList?.deductionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {deductionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.deductionValue + statList?.intellectValue}</div>
  );
};

export const ShowMonsterologyValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [monsterologyValue, setMonsterologyValue] = useState<number | null>(0);

  useEffect(() => {
    setMonsterologyValue(statList?.intellectValue + skillsList?.monsterologyValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.monsterologyValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, monsterologyValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setMonsterologyValue(statList?.intellectValue + skillsList?.monsterologyValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {monsterologyValue}</span>
    </div>
  ) : (
    <div>{skillsList?.monsterologyValue + statList?.intellectValue}</div>
  );
};

export const ShowEducationValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [educationValue, setEducationValue] = useState<number | null>(0);

  useEffect(() => {
    setEducationValue(statList?.intellectValue + skillsList?.educationValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.educationValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, educationValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setEducationValue(statList?.intellectValue + skillsList?.educationValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {educationValue}</span>
    </div>
  ) : (
    <div>{skillsList?.educationValue + statList?.intellectValue}</div>
  );
};

export const ShowCityOrientationValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [cityOrientationValue, setCityOrientationValue] = useState<number | null>(0);

  useEffect(() => {
    setCityOrientationValue(statList?.intellectValue + skillsList?.cityOrientationValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.cityOrientationValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, cityOrientationValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setCityOrientationValue(statList?.intellectValue + skillsList?.cityOrientationValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {cityOrientationValue}</span>
    </div>
  ) : (
    <div>{skillsList?.cityOrientationValue + statList?.intellectValue}</div>
  );
};

export const ShowKnowledgeTransferValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [knowledgeTransferValue, setKnowledgeTransferValue] = useState<number | null>(0);

  useEffect(() => {
    setKnowledgeTransferValue(statList?.intellectValue + skillsList?.knowledgeTransferValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.knowledgeTransferValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, knowledgeTransferValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setKnowledgeTransferValue(statList?.intellectValue + skillsList?.knowledgeTransferValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {knowledgeTransferValue}</span>
    </div>
  ) : (
    <div>{skillsList?.knowledgeTransferValue + statList?.intellectValue}</div>
  );
};

export const ShowTacticsValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [tacticsValue, setTacticsValue] = useState<number | null>(0);

  useEffect(() => {
    setTacticsValue(statList?.intellectValue + skillsList?.tacticsValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.tacticsValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, tacticsValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setTacticsValue(statList?.intellectValue + skillsList?.tacticsValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {tacticsValue}</span>
    </div>
  ) : (
    <div>{skillsList?.tacticsValue + statList?.intellectValue}</div>
  );
};

export const ShowTradingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [tradingValue, setTradingValue] = useState<number | null>(0);

  useEffect(() => {
    setTradingValue(statList?.intellectValue + skillsList?.tradingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.tradingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, tradingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setTradingValue(statList?.intellectValue + skillsList?.tradingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {tradingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.tradingValue + statList?.intellectValue}</div>
  );
};

export const ShowEtiquetteValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [etiquetteValue, setEtiquetteValue] = useState<number | null>(0);

  useEffect(() => {
    setEtiquetteValue(statList?.intellectValue + skillsList?.etiquetteValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.etiquetteValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, etiquetteValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setEtiquetteValue(statList?.intellectValue + skillsList?.etiquetteValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {etiquetteValue}</span>
    </div>
  ) : (
    <div>{skillsList?.etiquetteValue + statList?.intellectValue}</div>
  );
};

export const ShowLanguageGeneralValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [languageGeneralValue, setLanguageGeneralValue] = useState<number | null>(0);

  useEffect(() => {
    setLanguageGeneralValue(statList?.intellectValue + skillsList?.languageGeneralValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.languageGeneralValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, languageGeneralValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setLanguageGeneralValue(statList?.intellectValue + skillsList?.languageGeneralValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {languageGeneralValue}</span>
    </div>
  ) : (
    <div>{skillsList?.languageGeneralValue + statList?.intellectValue}</div>
  );
};

export const ShowLanguageHighValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [languageHighValue, setLanguageHighValue] = useState<number | null>(0);

  useEffect(() => {
    setLanguageHighValue(statList?.intellectValue + skillsList?.languageHighValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.languageHighValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, languageHighValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setLanguageHighValue(statList?.intellectValue + skillsList?.languageHighValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {languageHighValue}</span>
    </div>
  ) : (
    <div>{skillsList?.languageHighValue + statList?.intellectValue}</div>
  );
};

export const ShowLanguageDwarfValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [languageDwarfValue, setLanguageDwarfValue] = useState<number | null>(0);

  useEffect(() => {
    setLanguageDwarfValue(statList?.intellectValue + skillsList?.languageDwarfValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.intellectValue} + </span>
      <Controller
        name="skillsList.languageDwarfValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, languageDwarfValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setLanguageDwarfValue(statList?.intellectValue + skillsList?.languageDwarfValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {languageDwarfValue}</span>
    </div>
  ) : (
    <div>{skillsList?.languageDwarfValue + statList?.intellectValue}</div>
  );
};

//#endregion

////////////////////////////////////////

//#region Реакция

export const ShowMeleeCombatValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [meleeCombatValue, setMeleeCombatValue] = useState<number | null>(0);

  useEffect(() => {
    setMeleeCombatValue(statList?.reactionValue + skillsList?.meleeCombatValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.meleeCombatValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, meleeCombatValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setMeleeCombatValue(statList?.reactionValue + skillsList?.meleeCombatValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {meleeCombatValue}</span>
    </div>
  ) : (
    <div>{skillsList?.meleeCombatValue + statList?.reactionValue}</div>
  );
};

export const ShowWrestlingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [wrestlingValue, setWrestlingValue] = useState<number | null>(0);

  useEffect(() => {
    setWrestlingValue(statList?.reactionValue + skillsList?.wrestlingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.wrestlingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, wrestlingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setWrestlingValue(statList?.reactionValue + skillsList?.wrestlingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {wrestlingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.wrestlingValue + statList?.reactionValue}</div>
  );
};

export const ShowRidingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [ridingValue, setRidingValue] = useState<number | null>(0);

  useEffect(() => {
    setRidingValue(statList?.reactionValue + skillsList?.ridingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.ridingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, ridingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setRidingValue(statList?.reactionValue + skillsList?.ridingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {ridingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.ridingValue + statList?.reactionValue}</div>
  );
};

export const ShowPoleWeaponMasteryValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [poleWeaponMasteryValue, setPoleWeaponMasteryValue] = useState<number | null>(0);

  useEffect(() => {
    setPoleWeaponMasteryValue(statList?.reactionValue + skillsList?.poleWeaponMasteryValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.poleWeaponMasteryValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, poleWeaponMasteryValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setPoleWeaponMasteryValue(statList?.reactionValue + skillsList?.poleWeaponMasteryValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {poleWeaponMasteryValue}</span>
    </div>
  ) : (
    <div>{skillsList?.poleWeaponMasteryValue + statList?.reactionValue}</div>
  );
};

export const ShowLightBladeMasteryValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [lightBladeMasteryValue, setLightBladeMasteryValue] = useState<number | null>(0);

  useEffect(() => {
    setLightBladeMasteryValue(statList?.reactionValue + skillsList?.lightBladeMasteryValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.lightBladeMasteryValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, lightBladeMasteryValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setLightBladeMasteryValue(statList?.reactionValue + skillsList?.lightBladeMasteryValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {lightBladeMasteryValue}</span>
    </div>
  ) : (
    <div>{skillsList?.lightBladeMasteryValue + statList?.reactionValue}</div>
  );
};

export const ShowSwordsmanshipValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [swordsmanshipValue, setSwordsmanshipValue] = useState<number | null>(0);

  useEffect(() => {
    setSwordsmanshipValue(statList?.reactionValue + skillsList?.swordsmanshipValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.swordsmanshipValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, swordsmanshipValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setSwordsmanshipValue(statList?.reactionValue + skillsList?.swordsmanshipValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {swordsmanshipValue}</span>
    </div>
  ) : (
    <div>{skillsList?.swordsmanshipValue + statList?.reactionValue}</div>
  );
};

export const ShowSeamanshipValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [seamanshipValue, setSeamanshipValue] = useState<number | null>(0);

  useEffect(() => {
    setSeamanshipValue(statList?.reactionValue + skillsList?.seamanshipValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.seamanshipValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, seamanshipValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setSeamanshipValue(statList?.reactionValue + skillsList?.seamanshipValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {seamanshipValue}</span>
    </div>
  ) : (
    <div>{skillsList?.seamanshipValue + statList?.reactionValue}</div>
  );
};

export const ShowEvasionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [evasionValue, setEvasionValue] = useState<number | null>(0);

  useEffect(() => {
    setEvasionValue(statList?.reactionValue + skillsList?.evasionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.reactionValue} + </span>
      <Controller
        name="skillsList.evasionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, evasionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setEvasionValue(statList?.reactionValue + skillsList?.evasionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {evasionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.evasionValue + statList?.reactionValue}</div>
  );
};

//#endregion

////////////////////////////////////////

//#region Ловкость

export const ShowAthleticsValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [athleticsValue, setAthleticsValue] = useState<number | null>(0);

  useEffect(() => {
    setAthleticsValue(statList?.dexterityValue + skillsList?.athleticsValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.dexterityValue} + </span>
      <Controller
        name="skillsList.athleticsValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, athleticsValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setAthleticsValue(statList?.dexterityValue + skillsList?.athleticsValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {athleticsValue}</span>
    </div>
  ) : (
    <div>{skillsList?.athleticsValue + statList?.dexterityValue}</div>
  );
};

export const ShowManualDexterityValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [manualDexterityValue, setManualDexterityValue] = useState<number | null>(0);

  useEffect(() => {
    setManualDexterityValue(statList?.dexterityValue + skillsList?.manualDexterityValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.dexterityValue} + </span>
      <Controller
        name="skillsList.manualDexterityValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, manualDexterityValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setManualDexterityValue(statList?.dexterityValue + skillsList?.manualDexterityValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {manualDexterityValue}</span>
    </div>
  ) : (
    <div>{skillsList?.manualDexterityValue + statList?.dexterityValue}</div>
  );
};

export const ShowStealthValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [stealthValue, setStealthValue] = useState<number | null>(0);

  useEffect(() => {
    setStealthValue(statList?.dexterityValue + skillsList?.stealthValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.dexterityValue} + </span>
      <Controller
        name="skillsList.stealthValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, stealthValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setStealthValue(statList?.dexterityValue + skillsList?.stealthValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {stealthValue}</span>
    </div>
  ) : (
    <div>{skillsList?.stealthValue + statList?.dexterityValue}</div>
  );
};

export const ShowCrossbowMasteryValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [crossbowMasteryValue, setCrossbowMasteryValue] = useState<number | null>(0);

  useEffect(() => {
    setCrossbowMasteryValue(statList?.dexterityValue + skillsList?.crossbowMasteryValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.dexterityValue} + </span>
      <Controller
        name="skillsList.crossbowMasteryValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, crossbowMasteryValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setCrossbowMasteryValue(statList?.dexterityValue + skillsList?.crossbowMasteryValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {crossbowMasteryValue}</span>
    </div>
  ) : (
    <div>{skillsList?.crossbowMasteryValue + statList?.dexterityValue}</div>
  );
};

export const ShowArcheryValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [archeryValue, setArcheryValue] = useState<number | null>(0);

  useEffect(() => {
    setArcheryValue(statList?.dexterityValue + skillsList?.archeryValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.dexterityValue} + </span>
      <Controller
        name="skillsList.archeryValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, archeryValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setArcheryValue(statList?.dexterityValue + skillsList?.archeryValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {archeryValue}</span>
    </div>
  ) : (
    <div>{skillsList?.archeryValue + statList?.dexterityValue}</div>
  );
};

//#endregion

////////////////////////////////////////

//#region Телосложение

export const ShowStrengthValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [strengthValue, setStrengthValue] = useState<number | null>(0);

  useEffect(() => {
    setStrengthValue(statList?.constitutionValue + skillsList?.strengthValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.constitutionValue} + </span>
      <Controller
        name="skillsList.strengthValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, strengthValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setStrengthValue(statList?.constitutionValue + skillsList?.strengthValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {strengthValue}</span>
    </div>
  ) : (
    <div>{skillsList?.strengthValue + statList?.constitutionValue}</div>
  );
};

export const ShowEnduranceValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [enduranceValue, setEnduranceValue] = useState<number | null>(0);

  useEffect(() => {
    setEnduranceValue(statList?.constitutionValue + skillsList?.enduranceValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.constitutionValue} + </span>
      <Controller
        name="skillsList.enduranceValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, enduranceValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setEnduranceValue(statList?.constitutionValue + skillsList?.enduranceValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {enduranceValue}</span>
    </div>
  ) : (
    <div>{skillsList?.enduranceValue + statList?.constitutionValue}</div>
  );
};

//#endregion

////////////////////////////////////////

//#region Эмпатия

export const ShowGamblingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [gamblingValue, setGamblingValue] = useState<number | null>(0);

  useEffect(() => {
    setGamblingValue(statList?.empathyValue + skillsList?.gamblingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.gamblingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, gamblingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setGamblingValue(statList?.empathyValue + skillsList?.gamblingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {gamblingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.gamblingValue + statList?.empathyValue}</div>
  );
};

export const ShowAppearanceValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [appearanceValue, setAppearanceValue] = useState<number | null>(0);

  useEffect(() => {
    setAppearanceValue(statList?.empathyValue + skillsList?.appearanceValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.appearanceValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, appearanceValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setAppearanceValue(statList?.empathyValue + skillsList?.appearanceValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {appearanceValue}</span>
    </div>
  ) : (
    <div>{skillsList?.appearanceValue + statList?.empathyValue}</div>
  );
};

export const ShowPublicSpeakingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [publicSpeakingValue, setPublicSpeakingValue] = useState<number | null>(0);

  useEffect(() => {
    setPublicSpeakingValue(statList?.empathyValue + skillsList?.publicSpeakingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.publicSpeakingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, publicSpeakingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setPublicSpeakingValue(statList?.empathyValue + skillsList?.publicSpeakingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {publicSpeakingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.publicSpeakingValue + statList?.empathyValue}</div>
  );
};

export const ShowArtistryValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [artistryValue, setArtistryValue] = useState<number | null>(0);

  useEffect(() => {
    setArtistryValue(statList?.empathyValue + skillsList?.artistryValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.artistryValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, artistryValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setArtistryValue(statList?.empathyValue + skillsList?.artistryValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {artistryValue}</span>
    </div>
  ) : (
    <div>{skillsList?.artistryValue + statList?.empathyValue}</div>
  );
};

export const ShowLeadershipValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [leadershipValue, setLeadershipValue] = useState<number | null>(0);

  useEffect(() => {
    setLeadershipValue(statList?.empathyValue + skillsList?.leadershipValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.leadershipValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, leadershipValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setLeadershipValue(statList?.empathyValue + skillsList?.leadershipValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {leadershipValue}</span>
    </div>
  ) : (
    <div>{skillsList?.leadershipValue + statList?.empathyValue}</div>
  );
};

export const ShowDeceptionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [deceptionValue, setDeceptionValue] = useState<number | null>(0);

  useEffect(() => {
    setDeceptionValue(statList?.empathyValue + skillsList?.deceptionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.deceptionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, deceptionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setDeceptionValue(statList?.empathyValue + skillsList?.deceptionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {deceptionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.deceptionValue + statList?.empathyValue}</div>
  );
};

export const ShowUnderstandingPeopleValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [understandingPeopleValue, setUnderstandingPeopleValue] = useState<number | null>(0);

  useEffect(() => {
    setUnderstandingPeopleValue(statList?.empathyValue + skillsList?.understandingPeopleValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.understandingPeopleValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, understandingPeopleValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setUnderstandingPeopleValue(statList?.empathyValue + skillsList?.understandingPeopleValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {understandingPeopleValue}</span>
    </div>
  ) : (
    <div>{skillsList?.understandingPeopleValue + statList?.empathyValue}</div>
  );
};

export const ShowSeductionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [seductionValue, setSeductionValue] = useState<number | null>(0);

  useEffect(() => {
    setSeductionValue(statList?.empathyValue + skillsList?.seductionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.seductionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, seductionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setSeductionValue(statList?.empathyValue + skillsList?.seductionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {seductionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.seductionValue + statList?.empathyValue}</div>
  );
};

export const ShowPersuasionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [persuasionValue, setPersuasionValue] = useState<number | null>(0);

  useEffect(() => {
    setPersuasionValue(statList?.empathyValue + skillsList?.persuasionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.persuasionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, persuasionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setPersuasionValue(statList?.empathyValue + skillsList?.persuasionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {persuasionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.persuasionValue + statList?.empathyValue}</div>
  );
};

export const ShowCharismaValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [charismaValue, setCharismaValue] = useState<number | null>(0);

  useEffect(() => {
    setCharismaValue(statList?.empathyValue + skillsList?.charismaValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.empathyValue} + </span>
      <Controller
        name="skillsList.charismaValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, charismaValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setCharismaValue(statList?.empathyValue + skillsList?.charismaValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {charismaValue}</span>
    </div>
  ) : (
    <div>{skillsList?.charismaValue + statList?.empathyValue}</div>
  );
};

//#endregion

////////////////////////////////////////

//#region Ремесло

export const ShowAlchemyValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [alchemyValue, setAlchemyValue] = useState<number | null>(0);

  useEffect(() => {
    setAlchemyValue(statList?.craftsmanshipValue + skillsList?.alchemyValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.alchemyValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, alchemyValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setAlchemyValue(statList?.craftsmanshipValue + skillsList?.alchemyValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {alchemyValue}</span>
    </div>
  ) : (
    <div>{skillsList?.alchemyValue + statList?.craftsmanshipValue}</div>
  );
};

export const ShowLockpickingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [lockpickingValue, setLockpickingValue] = useState<number | null>(0);

  useEffect(() => {
    setLockpickingValue(statList?.craftsmanshipValue + skillsList?.lockpickingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.lockpickingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, lockpickingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setLockpickingValue(statList?.craftsmanshipValue + skillsList?.lockpickingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {lockpickingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.lockpickingValue + statList?.craftsmanshipValue}</div>
  );
};

export const ShowTrapKnowledgeValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [trapKnowledgeValue, setTrapKnowledgeValue] = useState<number | null>(0);

  useEffect(() => {
    setTrapKnowledgeValue(statList?.craftsmanshipValue + skillsList?.trapKnowledgeValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.trapKnowledgeValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, trapKnowledgeValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setTrapKnowledgeValue(statList?.craftsmanshipValue + skillsList?.trapKnowledgeValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {trapKnowledgeValue}</span>
    </div>
  ) : (
    <div>{skillsList?.trapKnowledgeValue + statList?.craftsmanshipValue}</div>
  );
};

export const ShowForgeryValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [forgeryValue, setForgeryValue] = useState<number | null>(0);

  useEffect(() => {
    setForgeryValue(statList?.craftsmanshipValue + skillsList?.forgeryValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.forgeryValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, forgeryValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setForgeryValue(statList?.craftsmanshipValue + skillsList?.forgeryValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {forgeryValue}</span>
    </div>
  ) : (
    <div>{skillsList?.forgeryValue + statList?.craftsmanshipValue}</div>
  );
};

export const ShowCamouflageValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [camouflageValue, setCamouflageValue] = useState<number | null>(0);

  useEffect(() => {
    setCamouflageValue(statList?.craftsmanshipValue + skillsList?.camouflageValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.camouflageValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, camouflageValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setCamouflageValue(statList?.craftsmanshipValue + skillsList?.camouflageValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {camouflageValue}</span>
    </div>
  ) : (
    <div>{skillsList?.camouflageValue + statList?.craftsmanshipValue}</div>
  );
};

export const ShowFirstAidValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [firstAidValue, setFirstAidValue] = useState<number | null>(0);

  useEffect(() => {
    setFirstAidValue(statList?.craftsmanshipValue + skillsList?.firstAidValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.firstAidValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, firstAidValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setFirstAidValue(statList?.craftsmanshipValue + skillsList?.firstAidValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {firstAidValue}</span>
    </div>
  ) : (
    <div>{skillsList?.firstAidValue + statList?.craftsmanshipValue}</div>
  );
};

export const ShowManufacturingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [manufacturingValue, setManufacturingValue] = useState<number | null>(0);

  useEffect(() => {
    setManufacturingValue(statList?.craftsmanshipValue + skillsList?.manufacturingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.craftsmanshipValue} + </span>
      <Controller
        name="skillsList.manufacturingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, manufacturingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setManufacturingValue(statList?.craftsmanshipValue + skillsList?.manufacturingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {manufacturingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.manufacturingValue + statList?.craftsmanshipValue}</div>
  );
};

//#endregion

////////////////////////////////////////

//#region Воля

export const ShowIntimidationValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [intimidationValue, setIntimidationValue] = useState<number | null>(0);

  useEffect(() => {
    setIntimidationValue(statList?.willpowerValue + skillsList?.intimidationValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.intimidationValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, intimidationValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setIntimidationValue(statList?.willpowerValue + skillsList?.intimidationValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {intimidationValue}</span>
    </div>
  ) : (
    <div>{skillsList?.intimidationValue + statList?.willpowerValue}</div>
  );
};

export const ShowCorruptionValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [corruptionValue, setCorruptionValue] = useState<number | null>(0);

  useEffect(() => {
    setCorruptionValue(statList?.willpowerValue + skillsList?.corruptionValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.corruptionValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, corruptionValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setCorruptionValue(statList?.willpowerValue + skillsList?.corruptionValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {corruptionValue}</span>
    </div>
  ) : (
    <div>{skillsList?.corruptionValue + statList?.willpowerValue}</div>
  );
};

export const ShowRitualsValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [ritualsValue, setRitualsValue] = useState<number | null>(0);

  useEffect(() => {
    setRitualsValue(statList?.willpowerValue + skillsList?.ritualsValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.ritualsValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, ritualsValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setRitualsValue(statList?.willpowerValue + skillsList?.ritualsValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {ritualsValue}</span>
    </div>
  ) : (
    <div>{skillsList?.ritualsValue + statList?.willpowerValue}</div>
  );
};

export const ShowMagicResistanceValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [magicResistanceValue, setMagicResistanceValue] = useState<number | null>(0);

  useEffect(() => {
    setMagicResistanceValue(statList?.willpowerValue + skillsList?.magicResistanceValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.magicResistanceValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, magicResistanceValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setMagicResistanceValue(statList?.willpowerValue + skillsList?.magicResistanceValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {magicResistanceValue}</span>
    </div>
  ) : (
    <div>{skillsList?.magicResistanceValue + statList?.willpowerValue}</div>
  );
};

export const ShowPersuasionResistanceValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [persuasionResistanceValue, setPersuasionResistanceValue] = useState<number | null>(0);

  useEffect(() => {
    setPersuasionResistanceValue(statList?.willpowerValue + skillsList?.persuasionResistanceValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.persuasionResistanceValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, persuasionResistanceValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setPersuasionResistanceValue(statList?.willpowerValue + skillsList?.persuasionResistanceValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {persuasionResistanceValue}</span>
    </div>
  ) : (
    <div>{skillsList?.persuasionResistanceValue + statList?.willpowerValue}</div>
  );
};

export const ShowSpellcastingValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [spellcastingValue, setSpellcastingValue] = useState<number | null>(0);

  useEffect(() => {
    setSpellcastingValue(statList?.willpowerValue + skillsList?.spellcastingValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.spellcastingValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, spellcastingValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setSpellcastingValue(statList?.willpowerValue + skillsList?.spellcastingValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {spellcastingValue}</span>
    </div>
  ) : (
    <div>{skillsList?.spellcastingValue + statList?.willpowerValue}</div>
  );
};

export const ShowCourageValue = ({
  isEditMode,
  statList,
  skillsList,
  setSkillsList,
  control,
}: IShowValue) => {
  const [courageValue, setCourageValue] = useState<number | null>(0);

  useEffect(() => {
    setCourageValue(statList?.willpowerValue + skillsList?.courageValue);
  }, [statList, skillsList]);

  return isEditMode ? (
    <div>
      <span>{statList?.willpowerValue} + </span>
      <Controller
        name="skillsList.courageValue"
        control={control}
        render={({ field }) => (
          <>
            <InputNumber
              id={field.name}
              value={field.value}
              onValueChange={(e: InputNumberValueChangeEvent) => {
                field.onChange(e.value);
                const updatedSkills = { ...skillsList, courageValue: e.value };
                setSkillsList(updatedSkills); // Обновить statList
                setCourageValue(statList?.willpowerValue + skillsList?.courageValue);
              }}
              minFractionDigits={0}
              maxFractionDigits={0}
              min={0}
              max={9999}
            />
          </>
        )}
      />
      <span> = {courageValue}</span>
    </div>
  ) : (
    <div>{skillsList?.courageValue + statList?.willpowerValue}</div>
  );
};

//#endregion