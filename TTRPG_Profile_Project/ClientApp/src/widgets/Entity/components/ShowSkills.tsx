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
    <div className="flex m-2 text-center showSkills">
      {isAllSkills ? (
        <div className="flex flex-wrap">
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
            <div className="mt-2">
              <h6>Телосложение</h6>
              <div>Сила {skillsList?.strengthValue + statList?.constitutionValue}</div>
              <div>Стойкость {skillsList?.enduranceValue + statList?.constitutionValue}</div>
            </div>
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
        <table>
          <tbody>
            {skillsList?.attentionValue !== 0 ? (<tr><td>Внимание</td><td>{skillsList?.attentionValue + statList?.intellectValue}</td></tr>) : "" }
            {skillsList?.survivalValue !== 0 ? (<tr><td>Выживание в дикой природе</td><td>{skillsList?.survivalValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.deductionValue !== 0 ? (<tr><td>Дедукция</td><td>{skillsList?.deductionValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.monsterologyValue !== 0 ? (<tr><td>Монстрология</td><td>{skillsList?.monsterologyValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.educationValue !== 0 ? (<tr><td>Образование</td><td>{skillsList?.educationValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.cityOrientationValue !== 0 ? (<tr><td>Ориентирование в городе</td><td>{skillsList?.cityOrientationValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.knowledgeTransferValue !== 0 ? (<tr><td>Передача знаний</td><td>{skillsList?.knowledgeTransferValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.tacticsValue !== 0 ? (<tr><td>Тактика</td><td>{skillsList?.tacticsValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.tradingValue !== 0 ? (<tr><td>Торговля</td><td>{skillsList?.tradingValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.etiquetteValue !== 0 ? (<tr><td>Этикет</td><td>{skillsList?.etiquetteValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.languageGeneralValue !== 0 ? (<tr><td>Язык: всеобщий</td><td>{skillsList?.languageGeneralValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.languageHighValue !== 0 ? (<tr><td>Язык: Старшая Речь</td><td>{skillsList?.languageHighValue + statList?.intellectValue}</td></tr>) : ""}
            {skillsList?.languageDwarfValue !== 0 ? (<tr><td>Язык: язык краснолюдов</td><td>{skillsList?.languageDwarfValue + statList?.intellectValue}</td></tr>) : ""}
            
            {skillsList?.meleeCombatValue !== 0 ? (<tr><td>Ближний бой</td><td>{skillsList?.meleeCombatValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.wrestlingValue !== 0 ? (<tr><td>Борьба</td><td>{skillsList?.wrestlingValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.ridingValue !== 0 ? (<tr><td>Верховая езда</td><td>{skillsList?.ridingValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.poleWeaponMasteryValue !== 0 ? (<tr><td>Владение древковым оружием</td><td>{skillsList?.poleWeaponMasteryValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.lightBladeMasteryValue !== 0 ? (<tr><td>Владение легкими клинками</td><td>{skillsList?.lightBladeMasteryValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.swordsmanshipValue !== 0 ? (<tr><td>Владение мечом</td><td>{skillsList?.swordsmanshipValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.seamanshipValue !== 0 ? (<tr><td>Мореходство</td><td>{skillsList?.seamanshipValue + statList?.reactionValue}</td></tr>) : ""}
            {skillsList?.evasionValue !== 0 ? (<tr><td>Уклонение/Изворотливость</td><td>{skillsList?.evasionValue + statList?.reactionValue}</td></tr>) : ""}

            {skillsList?.athleticsValue !== 0 ? (<tr><td>Атлетика</td><td>{skillsList?.athleticsValue + statList?.dexterityValue}</td></tr>) : ""}
            {skillsList?.manualDexterityValue !== 0 ? (<tr><td>Ловкость рук</td><td>{skillsList?.manualDexterityValue + statList?.dexterityValue}</td></tr>) : ""}
            {skillsList?.stealthValue !== 0 ? (<tr><td>Скрытность</td><td>{skillsList?.stealthValue + statList?.dexterityValue}</td></tr>) : ""}
            {skillsList?.crossbowMasteryValue !== 0 ? (<tr><td>Стрельба из арбалета</td><td>{skillsList?.crossbowMasteryValue + statList?.dexterityValue}</td></tr>) : ""}
            {skillsList?.crossbowMasteryValue !== 0 ? (<tr><td>Стрельба из лука</td><td>{skillsList?.crossbowMasteryValue + statList?.dexterityValue}</td></tr>) : ""}

            {skillsList?.strengthValue !== 0 ? (<tr><td>Сила</td><td>{skillsList?.strengthValue + statList?.constitutionValue}</td></tr>) : ""}
            {skillsList?.enduranceValue !== 0 ? (<tr><td>Стойкость</td><td>{skillsList?.enduranceValue + statList?.constitutionValue}</td></tr>) : ""}

            {skillsList?.gamblingValue !== 0 ? (<tr><td>Азартные игры</td><td>{skillsList?.gamblingValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.appearanceValue !== 0 ? (<tr><td>Внешний вид</td><td>{skillsList?.appearanceValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.publicSpeakingValue !== 0 ? (<tr><td>Выступление</td><td>{skillsList?.publicSpeakingValue + statList?.empathyValue}</td></tr>) : ""}            
            {skillsList?.artistryValue !== 0 ? (<tr><td>Искусство</td><td>{skillsList?.artistryValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.leadershipValue !== 0 ? (<tr><td>Лидерство</td><td>{skillsList?.leadershipValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.deceptionValue !== 0 ? (<tr><td>Обман</td><td>{skillsList?.deceptionValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.understandingPeopleValue !== 0 ? (<tr><td>Понимание людей</td><td>{skillsList?.understandingPeopleValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.seductionValue !== 0 ? (<tr><td>Соблазнение</td><td>{skillsList?.seductionValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.persuasionValue !== 0 ? (<tr><td>Убеждение</td><td>{skillsList?.persuasionValue + statList?.empathyValue}</td></tr>) : ""}
            {skillsList?.charismaValue !== 0 ? (<tr><td>Харизма</td><td>{skillsList?.charismaValue + statList?.empathyValue}</td></tr>) : ""}

            {skillsList?.alchemyValue !== 0 ? (<tr><td>Алхимия</td><td>{skillsList?.alchemyValue + statList?.craftsmanshipValue}</td></tr>) : ""}
            {skillsList?.lockpickingValue !== 0 ? (<tr><td>Взлом замков</td><td>{skillsList?.lockpickingValue + statList?.craftsmanshipValue}</td></tr>) : ""}
            {skillsList?.trapKnowledgeValue !== 0 ? (<tr><td>Знание ловушек</td><td>{skillsList?.trapKnowledgeValue + statList?.craftsmanshipValue}</td></tr>) : ""}
            {skillsList?.forgeryValue !== 0 ? (<tr><td>Изготовление</td><td>{skillsList?.forgeryValue + statList?.craftsmanshipValue}</td></tr>) : ""}
            {skillsList?.camouflageValue !== 0 ? (<tr><td>Маскировка</td><td>{skillsList?.camouflageValue + statList?.craftsmanshipValue}</td></tr>) : ""}
            {skillsList?.firstAidValue !== 0 ? (<tr><td>Первая помощь</td><td>{skillsList?.firstAidValue + statList?.craftsmanshipValue}</td></tr>) : ""}
            {skillsList?.manufacturingValue !== 0 ? (<tr><td>Подделывание</td><td>{skillsList?.manufacturingValue + statList?.craftsmanshipValue}</td></tr>) : ""}

            {skillsList?.intimidationValue !== 0 ? (<tr><td>Запугивание</td><td>{skillsList?.intimidationValue + statList?.willpowerValue}</td></tr>) : ""}
            {skillsList?.corruptionValue !== 0 ? (<tr><td>Наведение порчи</td><td>{skillsList?.corruptionValue + statList?.willpowerValue}</td></tr>) : ""}
            {skillsList?.ritualsValue !== 0 ? (<tr><td>Проведение ритуалов</td><td>{skillsList?.ritualsValue + statList?.willpowerValue}</td></tr>) : ""}
            {skillsList?.magicResistanceValue !== 0 ? (<tr><td>Сопротивление магии</td><td>{skillsList?.magicResistanceValue + statList?.willpowerValue}</td></tr>) : ""}
            {skillsList?.persuasionResistanceValue !== 0 ? (<tr><td>Сопротивление убеждению</td><td>{skillsList?.persuasionResistanceValue + statList?.willpowerValue}</td></tr>) : ""}
            {skillsList?.spellcastingValue !== 0 ? (<tr><td>Сотворение заклинаний</td><td>{skillsList?.spellcastingValue + statList?.willpowerValue}</td></tr>) : ""}
            {skillsList?.courageValue !== 0 ? (<tr><td>Храбрость</td><td>{skillsList?.courageValue + statList?.willpowerValue}</td></tr>) : ""}
          </tbody>
        </table>
      )}
    </div>
  );
};
