import React, { useEffect } from "react";
import { ISkillsList, IStatsList } from "shared/models";

interface IShowSkills {
  statList: IStatsList | null;
  skillsList: ISkillsList | null;
  isAllSkills: boolean;
}

export const ShowSkills = ({ statList, skillsList, isAllSkills }: IShowSkills) => {
  useEffect(() => {}, [isAllSkills]);

  return (
    <div className="flex">
      {isAllSkills ? (
        <div className="flex">
          <div>
            <h6>Интеллект</h6>
            <div>Внимание {skillsList?.attentionValue + statList?.intellectValue}</div>
            <div>Выживание в дикой природе {skillsList?.survivalValue + statList?.intellectValue}</div>
            <div>Дедукция {skillsList?.deductionValue + statList?.intellectValue}</div>
            <div>Монстрология {skillsList?.monsterologyValue + statList?.intellectValue}</div>
            <div>Образование {skillsList?.educationValue + statList?.intellectValue}</div>
            <div>
              Ориентирование в городе {skillsList?.cityOrientationValue + statList?.intellectValue}
            </div>
            <div>Передача знаний {skillsList?.knowledgeTransferValue + statList?.intellectValue}</div>
            <div>Тактика {skillsList?.tacticsValue + statList?.intellectValue}</div>
            <div>Торговля {skillsList?.tacticsValue + statList?.intellectValue}</div>
            <div>Этикет {skillsList?.etiquetteValue + statList?.intellectValue}</div>
            <div>Язык: всеобщий {skillsList?.languageGeneralValue + statList?.intellectValue}</div>
            <div>Язык: Старшая Речь {skillsList?.languageHighValue + statList?.intellectValue}</div>
            <div>Язык: язык краснолюдов {skillsList?.languageDwarfValue + statList?.intellectValue}</div>
          </div>
          <div>
            <h6>Реакция</h6>
            <div>Ближний бой {skillsList?.meleeCombatValue + statList?.reactionValue}</div>
            <div>Борьба {skillsList?.wrestlingValue + statList?.reactionValue}</div>
            <div>Верховая езда {skillsList?.ridingValue + statList?.reactionValue}</div>
            <div>
              Владение древковым оружием {skillsList?.poleWeaponMasteryValue + statList?.reactionValue}
            </div>
            <div>
              Владение легкими клинками {skillsList?.lightBladeMasteryValue + statList?.reactionValue}
            </div>
            <div>Владение мечом {skillsList?.swordsmanshipValue + statList?.reactionValue}</div>
            <div>Мореходство {skillsList?.seamanshipValue + statList?.reactionValue}</div>
            <div>Уклонение/Изворотливость {skillsList?.evasionValue + statList?.reactionValue}</div>
          </div>
          <div>
            <h6>Ловкость</h6>
            <div>Атлетика {skillsList?.athleticsValue + statList?.dexterityValue}</div>
            <div>Ловкость рук {skillsList?.manualDexterityValue + statList?.dexterityValue}</div>
            <div>Скрытность {skillsList?.stealthValue + statList?.dexterityValue}</div>
            <div>Стрельба из арбалета {skillsList?.crossbowMasteryValue + statList?.dexterityValue}</div>
            <div>Стрельба из лука {skillsList?.crossbowMasteryValue + statList?.dexterityValue}</div>
          </div>
          <div>
            <h6>Телосложение</h6>
            <div>Сила {skillsList?.strengthValue + statList?.constitutionValue}</div>
            <div>Стойкость {skillsList?.enduranceValue + statList?.constitutionValue}</div>
          </div>
          <div>
            <h6>Эмпатия</h6>
            <div>Азартные игры {skillsList?.gamblingValue + statList?.empathyValue}</div>
            <div>Внешний вид {skillsList?.appearanceValue + statList?.empathyValue}</div>
            <div>Выступление {skillsList?.publicSpeakingValue + statList?.empathyValue}</div>
            <div>Искусство {skillsList?.artistryValue + statList?.empathyValue}</div>
            <div>Лидерство {skillsList?.leadershipValue + statList?.empathyValue}</div>
            <div>Обман {skillsList?.deceptionValue + statList?.empathyValue}</div>
            <div>Понимание людей {skillsList?.understandingPeopleValue + statList?.empathyValue}</div>
            <div>Соблазнение {skillsList?.seductionValue + statList?.empathyValue}</div>
            <div>Убеждение {skillsList?.persuasionValue + statList?.empathyValue}</div>
            <div>Харизма {skillsList?.charismaValue + statList?.empathyValue}</div>
          </div>
          <div>
            <h6>Ремесло</h6>
            <div>Алхимия {skillsList?.alchemyValue + statList?.craftsmanshipValue}</div>
            <div>Взлом замков {skillsList?.lockpickingValue + statList?.craftsmanshipValue}</div>
            <div>Знание ловушек {skillsList?.trapKnowledgeValue + statList?.craftsmanshipValue}</div>
            <div>Изготовление {skillsList?.forgeryValue + statList?.craftsmanshipValue}</div>
            <div>Маскировка {skillsList?.camouflageValue + statList?.craftsmanshipValue}</div>
            <div>Первая помощь {skillsList?.firstAidValue + statList?.craftsmanshipValue}</div>
            <div>Подделывание {skillsList?.manufacturingValue + statList?.craftsmanshipValue}</div>
          </div>
          <div>
            <h6>Воля</h6>
            <div>Запугивание {skillsList?.intimidationValue + statList?.willpowerValue}</div>
            <div>Наведение порчи {skillsList?.corruptionValue + statList?.willpowerValue}</div>
            <div>Проведение ритуалов {skillsList?.ritualsValue + statList?.willpowerValue}</div>
            <div>Сопротивление магии {skillsList?.magicResistanceValue + statList?.willpowerValue}</div>
            <div>Сопротивление убеждению {skillsList?.persuasionResistanceValue + statList?.willpowerValue}</div>
            <div>Сотворение заклинаний {skillsList?.spellcastingValue + statList?.willpowerValue}</div>
            <div>Храбрость {skillsList?.courageValue + statList?.willpowerValue}</div>
          </div>
        </div>
      ) : (
        <div>
          {skillsList?.attentionValue !== 0 ? (<div>Внимание {skillsList?.attentionValue + statList?.intellectValue}</div>) : "" }
          {skillsList?.survivalValue !== 0 ? (<div>Выживание в дикой природе {skillsList?.survivalValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.deductionValue !== 0 ? (<div>Дедукция {skillsList?.deductionValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.monsterologyValue !== 0 ? (<div>Монстрология {skillsList?.monsterologyValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.educationValue !== 0 ? (<div>Образование {skillsList?.educationValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.cityOrientationValue !== 0 ? (<div>Ориентирование в городе {skillsList?.cityOrientationValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.knowledgeTransferValue !== 0 ? (<div>Передача знаний {skillsList?.knowledgeTransferValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.tacticsValue !== 0 ? (<div>Тактика {skillsList?.tacticsValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.tradingValue !== 0 ? (<div>Торговля {skillsList?.tradingValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.etiquetteValue !== 0 ? (<div>Этикет {skillsList?.etiquetteValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.languageGeneralValue !== 0 ? (<div>Язык: всеобщий {skillsList?.languageGeneralValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.languageHighValue !== 0 ? (<div>Язык: Старшая Речь {skillsList?.languageHighValue + statList?.intellectValue}</div>) : ""}
          {skillsList?.languageDwarfValue !== 0 ? (<div>Язык: язык краснолюдов {skillsList?.languageDwarfValue + statList?.intellectValue}</div>) : ""}
          
          {skillsList?.meleeCombatValue !== 0 ? (<div>Ближний бой {skillsList?.meleeCombatValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.wrestlingValue !== 0 ? (<div>Борьба {skillsList?.wrestlingValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.ridingValue !== 0 ? (<div>Верховая езда {skillsList?.ridingValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.poleWeaponMasteryValue !== 0 ? (<div>Владение древковым оружием {skillsList?.poleWeaponMasteryValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.lightBladeMasteryValue !== 0 ? (<div>Владение легкими клинками {skillsList?.lightBladeMasteryValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.swordsmanshipValue !== 0 ? (<div>Владение мечом {skillsList?.swordsmanshipValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.seamanshipValue !== 0 ? (<div>Мореходство {skillsList?.seamanshipValue + statList?.reactionValue}</div>) : ""}
          {skillsList?.evasionValue !== 0 ? (<div>Уклонение/Изворотливость {skillsList?.evasionValue + statList?.reactionValue}</div>) : ""}

          {skillsList?.athleticsValue !== 0 ? (<div>Атлетика {skillsList?.athleticsValue + statList?.dexterityValue}</div>) : ""}
          {skillsList?.manualDexterityValue !== 0 ? (<div>Ловкость рук {skillsList?.manualDexterityValue + statList?.dexterityValue}</div>) : ""}
          {skillsList?.stealthValue !== 0 ? (<div>Скрытность {skillsList?.stealthValue + statList?.dexterityValue}</div>) : ""}
          {skillsList?.crossbowMasteryValue !== 0 ? (<div>Стрельба из арбалета {skillsList?.crossbowMasteryValue + statList?.dexterityValue}</div>) : ""}
          {skillsList?.crossbowMasteryValue !== 0 ? (<div>Стрельба из лука {skillsList?.crossbowMasteryValue + statList?.dexterityValue}</div>) : ""}

          {skillsList?.strengthValue !== 0 ? (<div>Сила {skillsList?.strengthValue + statList?.constitutionValue}</div>) : ""}
          {skillsList?.enduranceValue !== 0 ? (<div>Стойкость {skillsList?.enduranceValue + statList?.constitutionValue}</div>) : ""}

          {skillsList?.gamblingValue !== 0 ? (<div>Азартные игры {skillsList?.gamblingValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.appearanceValue !== 0 ? (<div>Внешний вид {skillsList?.appearanceValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.publicSpeakingValue !== 0 ? (<div>Выступление {skillsList?.publicSpeakingValue + statList?.empathyValue}</div>) : ""}            
          {skillsList?.artistryValue !== 0 ? (<div>Искусство {skillsList?.artistryValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.leadershipValue !== 0 ? (<div>Лидерство {skillsList?.leadershipValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.deceptionValue !== 0 ? (<div>Обман {skillsList?.deceptionValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.understandingPeopleValue !== 0 ? (<div>Понимание людей {skillsList?.understandingPeopleValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.seductionValue !== 0 ? (<div>Соблазнение {skillsList?.seductionValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.persuasionValue !== 0 ? (<div>Убеждение {skillsList?.persuasionValue + statList?.empathyValue}</div>) : ""}
          {skillsList?.charismaValue !== 0 ? (<div>Харизма {skillsList?.charismaValue + statList?.empathyValue}</div>) : ""}

          {skillsList?.alchemyValue !== 0 ? (<div>Алхимия {skillsList?.alchemyValue + statList?.craftsmanshipValue}</div>) : ""}
          {skillsList?.lockpickingValue !== 0 ? (<div>Взлом замков {skillsList?.lockpickingValue + statList?.craftsmanshipValue}</div>) : ""}
          {skillsList?.trapKnowledgeValue !== 0 ? (<div>Знание ловушек {skillsList?.trapKnowledgeValue + statList?.craftsmanshipValue}</div>) : ""}
          {skillsList?.forgeryValue !== 0 ? (<div>Изготовление {skillsList?.forgeryValue + statList?.craftsmanshipValue}</div>) : ""}
          {skillsList?.camouflageValue !== 0 ? (<div>Маскировка {skillsList?.camouflageValue + statList?.craftsmanshipValue}</div>) : ""}
          {skillsList?.firstAidValue !== 0 ? (<div>Первая помощь {skillsList?.firstAidValue + statList?.craftsmanshipValue}</div>) : ""}
          {skillsList?.manufacturingValue !== 0 ? (<div>Подделывание {skillsList?.manufacturingValue + statList?.craftsmanshipValue}</div>) : ""}

          {skillsList?.intimidationValue !== 0 ? (<div>Запугивание {skillsList?.intimidationValue + statList?.willpowerValue}</div>) : ""}
          {skillsList?.corruptionValue !== 0 ? (<div>Наведение порчи {skillsList?.corruptionValue + statList?.willpowerValue}</div>) : ""}
          {skillsList?.ritualsValue !== 0 ? (<div>Проведение ритуалов {skillsList?.ritualsValue + statList?.willpowerValue}</div>) : ""}
          {skillsList?.magicResistanceValue !== 0 ? (<div>Сопротивление магии {skillsList?.magicResistanceValue + statList?.willpowerValue}</div>) : ""}
          {skillsList?.persuasionResistanceValue !== 0 ? (<div>Сопротивление убеждению {skillsList?.persuasionResistanceValue + statList?.willpowerValue}</div>) : ""}
          {skillsList?.spellcastingValue !== 0 ? (<div>Сотворение заклинаний {skillsList?.spellcastingValue + statList?.willpowerValue}</div>) : ""}
          {skillsList?.courageValue !== 0 ? (<div>Храбрость {skillsList?.courageValue + statList?.willpowerValue}</div>) : ""}
        </div>
      )}
    </div>
  );
};
