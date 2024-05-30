import React, { useEffect } from "react";
import {
  Control,
  FieldValues,
  UseFormGetValues,
} from "react-hook-form";
import { ICreature, ISkillsList, IStatsList } from "shared/models";
import {
  ShowAlchemyValue,
  ShowAppearanceValue,
  ShowArcheryValue,
  ShowArtistryValue,
  ShowAthleticsValue,
  ShowAttentionValue,
  ShowCamouflageValue,
  ShowCharismaValue,
  ShowCityOrientationValue,
  ShowCorruptionValue,
  ShowCourageValue,
  ShowCrossbowMasteryValue,
  ShowDeceptionValue,
  ShowDeductionValue,
  ShowEducationValue,
  ShowEnduranceValue,
  ShowEtiquetteValue,
  ShowEvasionValue,
  ShowFirstAidValue,
  ShowForgeryValue,
  ShowGamblingValue,
  ShowIntimidationValue,
  ShowKnowledgeTransferValue,
  ShowLanguageDwarfValue,
  ShowLanguageGeneralValue,
  ShowLanguageHighValue,
  ShowLeadershipValue,
  ShowLightBladeMasteryValue,
  ShowLockpickingValue,
  ShowMagicResistanceValue,
  ShowManualDexterityValue,
  ShowManufacturingValue,
  ShowMeleeCombatValue,
  ShowMonsterologyValue,
  ShowPersuasionResistanceValue,
  ShowPersuasionValue,
  ShowPoleWeaponMasteryValue,
  ShowPublicSpeakingValue,
  ShowRidingValue,
  ShowRitualsValue,
  ShowSeamanshipValue,
  ShowSeductionValue,
  ShowSpellcastingValue,
  ShowStealthValue,
  ShowStrengthValue,
  ShowSurvivalValue,
  ShowSwordsmanshipValue,
  ShowTacticsValue,
  ShowTradingValue,
  ShowTrapKnowledgeValue,
  ShowUnderstandingPeopleValue,
  ShowWrestlingValue,
} from "./SkillsListValues";

interface IShowSkills {
  statList: IStatsList | null;
  //setStatList: React.Dispatch<React.SetStateAction<IStatsList>>;
  skillsList: ISkillsList | null;
  setSkillsList: React.Dispatch<React.SetStateAction<ISkillsList>>;

  data: ICreature | null;
  isAllSkills: boolean;

  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  isEditMode: boolean;
}

export const ShowSkills = ({
  statList,
  skillsList,
  setSkillsList,
  data,
  isAllSkills,
  control,
  getValues,
  isEditMode,
}: IShowSkills) => {
  //  const [stat, setStat] = useState<IStatsList>(null);
  //  const [skills, setSkills] = useState<ISkillsList>(null);

  // const fetchStatList = () => {
  //   let getStatsList: IStatsList = getValues("statsList");
  //   setStat(getStatsList);

  //   let getSkillsList: ISkillsList = getValues("skillsList");
  //   setSkills(getSkillsList);

  //   console.log("Изменение")
  // }

  useEffect(() => {
    //fetchStatList();
  }, [isAllSkills, isEditMode, data, statList, skillsList]);

  /*
  tooltip={
    "Текущее значение: " +
    String(getValues("statsList.intellectValue")) +
    " + " +
     String(getValues("skillsList.educationValue")) +
     " = " +
     String(getValues("statsList.intellectValue") + getValues("skillsList.educationValue"))
    }
  */

  return (
    <div className="flex m-2 text-center showSkills skillsList">
      {isAllSkills ? (
        <div className="flex flex-wrap">
          <div>
            <h6>Интеллект</h6>
            <div>
              <span>Внимание </span>
              <ShowAttentionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Выживание в дикой природе </span>
              <ShowSurvivalValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Дедукция </span>
              <ShowDeductionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Монстрология </span>
              <ShowMonsterologyValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Образование </span>
              <ShowEducationValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Ориентирование в городе </span>
              <ShowCityOrientationValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Передача знаний </span>
              <ShowKnowledgeTransferValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Тактика </span>
              <ShowTacticsValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Торговля </span>
              <ShowTradingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Этикет </span>
              <ShowEtiquetteValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Язык: всеобщий </span>
              <ShowLanguageGeneralValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Язык: Старшая Речь </span>
              <ShowLanguageHighValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Язык: язык краснолюдов </span>
              <ShowLanguageDwarfValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>
          <div>
            <h6>Реакция</h6>
            <div>
              <span>Ближний бой </span>
              <ShowMeleeCombatValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Борьба </span>
              <ShowWrestlingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Верховая езда </span>
              <ShowRidingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Владение древковым оружием </span>
              <ShowPoleWeaponMasteryValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Владение легкими клинками </span>
              <ShowLightBladeMasteryValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Владение мечом </span>
              <ShowSwordsmanshipValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Мореходство </span>
              <ShowSeamanshipValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Уклонение/Изворотливость </span>
              <ShowEvasionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>
          <div>
            <h6>Ловкость</h6>
            <div>
              <span>Атлетика </span>
              <ShowAthleticsValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Ловкость рук </span>
              <ShowManualDexterityValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Скрытность </span>
              <ShowStealthValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Стрельба из арбалета </span>
              <ShowCrossbowMasteryValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Стрельба из лука </span>
              <ShowArcheryValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>
          <div className="mt-2">
            <h6>Телосложение</h6>
            <div>
              <span>Сила </span>
              <ShowStrengthValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Стойкость </span>
              <ShowEnduranceValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>

          <div>
            <h6>Эмпатия</h6>
            <div>
              <span>Азартные игры </span>
              <ShowGamblingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Внешний вид </span>
              <ShowAppearanceValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Выступление </span>
              <ShowPublicSpeakingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Искусство </span>
              <ShowArtistryValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Лидерство </span>
              <ShowLeadershipValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Обман </span>
              <ShowDeceptionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Понимание людей </span>
              <ShowUnderstandingPeopleValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Соблазнение </span>
              <ShowSeductionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Убеждение </span>
              <ShowPersuasionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Харизма </span>
              <ShowCharismaValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>
          <div>
            <h6>Ремесло</h6>
            <div>
              <span>Алхимия </span>
              <ShowAlchemyValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Взлом замков </span>
              <ShowLockpickingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Знание ловушек </span>
              <ShowTrapKnowledgeValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Изготовление </span>
              <ShowForgeryValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Маскировка </span>
              <ShowCamouflageValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Первая помощь </span>
              <ShowFirstAidValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Подделывание </span>
              <ShowManufacturingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>
          <div>
            <h6>Воля</h6>
            <div>
              <span>Запугивание </span>
              <ShowIntimidationValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Наведение порчи </span>
              <ShowCorruptionValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Проведение ритуалов </span>
              <ShowRitualsValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Сопротивление магии </span>
              <ShowMagicResistanceValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Сопротивление убеждению </span>
              <ShowPersuasionResistanceValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Сотворение заклинаний </span>
              <ShowSpellcastingValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
            <div>
              <span>Храбрость </span>
              <ShowCourageValue
                control={control}
                isEditMode={isEditMode}
                skillsList={skillsList}
                setSkillsList={setSkillsList}
                statList={statList}
              />
            </div>
          </div>
        </div>
      ) : (
        <table>
          <tbody>
            {skillsList?.attentionValue !== 0 ? (
              <tr>
                <td>Внимание</td>
                {/* <td>{skillsList?.attentionValue + statList?.intellectValue}</td> */}
                <td>
                  <ShowAttentionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.survivalValue !== 0 ? (
              <tr>
                <td>Выживание в дикой природе</td>
                <td>
                  <ShowSurvivalValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.deductionValue !== 0 ? (
              <tr>
                <td>Дедукция</td>
                <td>
                  <ShowDeductionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.monsterologyValue !== 0 ? (
              <tr>
                <td>Монстрология</td>
                <td>
                  <ShowMonsterologyValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.educationValue !== 0 ? (
              <tr>
                <td>Образование</td>
                <td>
                  <ShowEducationValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.cityOrientationValue !== 0 ? (
              <tr>
                <td>Ориентирование в городе</td>
                <td>
                  <ShowCityOrientationValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.knowledgeTransferValue !== 0 ? (
              <tr>
                <td>Передача знаний</td>
                <td>
                  <ShowKnowledgeTransferValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.tacticsValue !== 0 ? (
              <tr>
                <td>Тактика</td>
                <td>
                  <ShowTacticsValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.tradingValue !== 0 ? (
              <tr>
                <td>Торговля</td>
                <td>
                  <ShowTradingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.etiquetteValue !== 0 ? (
              <tr>
                <td>Этикет</td>
                <td>
                  <ShowEtiquetteValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.languageGeneralValue !== 0 ? (
              <tr>
                <td>Язык: всеобщий</td>
                <td>
                  <ShowLanguageGeneralValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.languageHighValue !== 0 ? (
              <tr>
                <td>Язык: Старшая Речь</td>
                <td>
                  <ShowLanguageHighValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.languageDwarfValue !== 0 ? (
              <tr>
                <td>Язык: язык краснолюдов</td>
                <td>
                  <ShowLanguageDwarfValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}

            {skillsList?.meleeCombatValue !== 0 ? (
              <tr>
                <td>Ближний бой</td>
                <td>
                  <ShowMeleeCombatValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.wrestlingValue !== 0 ? (
              <tr>
                <td>Борьба</td>
                <td>
                  <ShowWrestlingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.ridingValue !== 0 ? (
              <tr>
                <td>Верховая езда</td>
                <td>
                  <ShowRidingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.poleWeaponMasteryValue !== 0 ? (
              <tr>
                <td>Владение древковым оружием</td>
                <td>
                  <ShowPoleWeaponMasteryValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.lightBladeMasteryValue !== 0 ? (
              <tr>
                <td>Владение легкими клинками</td>
                <td>
                  <ShowLightBladeMasteryValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.swordsmanshipValue !== 0 ? (
              <tr>
                <td>Владение мечом</td>
                <td>
                  <ShowSwordsmanshipValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.seamanshipValue !== 0 ? (
              <tr>
                <td>Мореходство</td>
                <td>
                  <ShowSeamanshipValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.evasionValue !== 0 ? (
              <tr>
                <td>Уклонение/Изворотливость</td>
                <td>
                  <ShowEvasionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}

            {skillsList?.athleticsValue !== 0 ? (
              <tr>
                <td>Атлетика</td>
                <td>
                  <ShowAthleticsValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.manualDexterityValue !== 0 ? (
              <tr>
                <td>Ловкость рук</td>
                <td>
                  <ShowManualDexterityValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.stealthValue !== 0 ? (
              <tr>
                <td>Скрытность</td>
                <td>
                  <ShowStealthValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.crossbowMasteryValue !== 0 ? (
              <tr>
                <td>Стрельба из арбалета</td>
                <td>
                  <ShowCrossbowMasteryValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.archeryValue !== 0 ? (
              <tr>
                <td>Стрельба из лука</td>
                <td>
                  <ShowArcheryValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}

            {skillsList?.strengthValue !== 0 ? (
              <tr>
                <td>Сила</td>
                <td>
                  <ShowStrengthValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.enduranceValue !== 0 ? (
              <tr>
                <td>Стойкость</td>
                <td>
                  <ShowEnduranceValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}

            {skillsList?.gamblingValue !== 0 ? (
              <tr>
                <td>Азартные игры</td>
                <td>
                  <ShowGamblingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.appearanceValue !== 0 ? (
              <tr>
                <td>Внешний вид</td>
                <td>
                  <ShowAppearanceValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.publicSpeakingValue !== 0 ? (
              <tr>
                <td>Выступление</td>
                <td>
                  <ShowPublicSpeakingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.artistryValue !== 0 ? (
              <tr>
                <td>Искусство</td>
                <td>
                  <ShowArtistryValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.leadershipValue !== 0 ? (
              <tr>
                <td>Лидерство</td>
                <td>
                  <ShowLeadershipValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.deceptionValue !== 0 ? (
              <tr>
                <td>Обман</td>
                <td>
                  <ShowDeceptionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.understandingPeopleValue !== 0 ? (
              <tr>
                <td>Понимание людей</td>
                <td>
                  <ShowUnderstandingPeopleValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.seductionValue !== 0 ? (
              <tr>
                <td>Соблазнение</td>
                <td>
                  <ShowSeductionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.persuasionValue !== 0 ? (
              <tr>
                <td>Убеждение</td>
                <td>
                  <ShowPersuasionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.charismaValue !== 0 ? (
              <tr>
                <td>Харизма</td>
                <td>
                  <ShowCharismaValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}

            {skillsList?.alchemyValue !== 0 ? (
              <tr>
                <td>Алхимия</td>
                <td>
                  <ShowAlchemyValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.lockpickingValue !== 0 ? (
              <tr>
                <td>Взлом замков</td>
                <td>
                  <ShowLockpickingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.trapKnowledgeValue !== 0 ? (
              <tr>
                <td>Знание ловушек</td>
                <td>
                  <ShowTrapKnowledgeValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.forgeryValue !== 0 ? (
              <tr>
                <td>Изготовление</td>
                <td>
                  <ShowForgeryValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.camouflageValue !== 0 ? (
              <tr>
                <td>Маскировка</td>
                <td>
                  <ShowCamouflageValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.firstAidValue !== 0 ? (
              <tr>
                <td>Первая помощь</td>
                <td>
                  <ShowFirstAidValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.manufacturingValue !== 0 ? (
              <tr>
                <td>Подделывание</td>
                <td>
                  <ShowManufacturingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}

            {skillsList?.intimidationValue !== 0 ? (
              <tr>
                <td>Запугивание</td>
                <td>
                  <ShowIntimidationValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.corruptionValue !== 0 ? (
              <tr>
                <td>Наведение порчи</td>
                <td>
                  <ShowCorruptionValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.ritualsValue !== 0 ? (
              <tr>
                <td>Проведение ритуалов</td>
                <td>
                  <ShowRitualsValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.magicResistanceValue !== 0 ? (
              <tr>
                <td>Сопротивление магии</td>
                <td>
                  <ShowMagicResistanceValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.persuasionResistanceValue !== 0 ? (
              <tr>
                <td>Сопротивление убеждению</td>
                <td>
                  <ShowPersuasionResistanceValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.spellcastingValue !== 0 ? (
              <tr>
                <td>Сотворение заклинаний</td>
                <td>
                  <ShowSpellcastingValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
            {skillsList?.courageValue !== 0 ? (
              <tr>
                <td>Храбрость</td>
                <td>
                  <ShowCourageValue
                    control={control}
                    isEditMode={isEditMode}
                    skillsList={skillsList}
                    setSkillsList={setSkillsList}
                    statList={statList}
                  />
                </td>
              </tr>
            ) : (
              ""
            )}
          </tbody>
        </table>
      )}
    </div>
  );
};
