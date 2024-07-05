import React from "react";
import { ItemDTO } from "shared/models";
import {
  AetherSVG,
  CaelumSVG,
  FulgurSVG,
  HydragenumSVG,
  QuebrithSVG,
  RebisSVG,
  SolSVG,
  VermilionSVG,
  VitriolSVG,
} from "img";
import { AttackTypeToShortString, AttackTypeToString } from "entities/BestiaryFunc";

const drawWeaponEquipmentType = (data: ItemDTO) => {
  switch (data.equipmentType) {
    case 1:
      return ", Мечи";
    case 2:
      return ", Кинжалы";
    case 3:
      return ", Топоры";
    case 4:
      return ", Дробящее";
    case 5:
      return ", Копья";
    case 6:
      return ", Посохи";
    case 7:
      return ", Метательное";
    case 8:
      return ", Луки";
    case 9:
      return ", Арбалеты";
    case 10:
      return ", Боеприпас";
    default:
      return "";
  }
};

const drawArmorEquipmentType = (data: ItemDTO) => {
  switch (data.equipmentType) {
    case 1:
      return ", Голова";
    case 2:
      return ", Тело";
    case 3:
      return ", Ноги";
    case 4:
      return ", Щит";
    case 5:
      return ", Ведьмачий";
    default:
      return "";
  }
};

const drawArmorType = (data: ItemDTO) => {
  switch (data.type) {
    case 1:
      return "Легкий";
    case 2:
      return "Средний";
    case 3:
      return "Тяжелый";
    default:
      return "";
  }
};

const drawItemOriginType = (data: ItemDTO) => {
  switch (data.itemOriginType) {
    case 1:
      return "Люди";
    case 2:
      return "Старший народ";
    case 3:
      return "Ведьмачий";
    case 4:
      return "Реликт";
    default:
      return "";
  }
};

const drawStealthType = (data: ItemDTO) => {
  switch (data.stealthType) {
    case 1:
      return "Н/С";
    case 2:
      return "М";
    case 3:
      return "Н";
    case 4:
      return "К";
  }
};

const StealthTypeTooltip = (stealthType: number) => {
  switch (stealthType) {
    case 1:
      return "(Не спрятать) Невозможно спрятать под одеждой";
    case 2:
      return "(Маленькое) Можно спрятать в кармане";
    case 3:
      return "(Небольшое) Можно спрятать под курткой";
    case 4:
      return "(Крупное) Можно спрятать под плащом";
  }
}

const drawAvailabilityType = (data: ItemDTO) => {
  switch (data.availabilityType) {
    case 1:
      return ", Повсеместное";
    case 2:
      return ", Обычное";
    case 3:
      return ", Редкое";
    case 4:
      return ", Уникальное";
  }
};

const AvailabilityTypeTooltip = (availabilityType : number) => {
  switch (availabilityType) {
    case 1:
      return "Можно найти даже в небольших поселках";
    case 2:
      return "Можно найти на рынках большинства городов";
    case 3:
      return "Оружие для армии или изготавливаемое в определенных местах";
    case 4:
      return "Очень трудно найти, обычно продается только в одном месте у определенных торговцев";
  }
}

const drawItemEntityType = (data: ItemDTO) => {
  switch (data.itemType) {
    case 1:
      return "";
    case 2:
      return "Инструмент";
    case 3:
      return "Алхимия";
    case 4:
      return "Броня";
    case 5:
      return "Оружие";
    case 6:
      return "Формула";
    case 7:
      return "Чертеж";
    case 8:
      return "Компонент";
    case 9:
      return "Предмет";
  }
};

const drawSubstanceType = (substanceType: number, amount: number) => {
  switch (substanceType) {
    case 1:
      return (
        <div className="flex m-auto">
          <span>Аэр</span>
          <div className="ml-1">{CaelumSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 2:
      return (
        <div className="flex m-auto">
          <span>Гидраген</span>
          <div className="ml-1">{HydragenumSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 3:
      return (
        <div className="flex m-auto">
          <span>Квебрит</span>
          <div className="ml-1">{QuebrithSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 4:
      return (
        <div className="flex m-auto">
          <span>Киноварь</span>
          <div className="ml-1">{VermilionSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 5:
      return (
        <div className="flex m-auto">
          <span>Купорос</span>
          <div className="ml-1">{VitriolSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 6:
      return (
        <div className="flex m-auto">
          <span>Рэбис</span>
          <div className="ml-1">{RebisSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 7:
      return (
        <div className="flex m-auto">
          <span>Солнце</span>
          <div className="ml-1">{SolSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 8:
      return (
        <div className="flex m-auto">
          <span>Фульгор</span>
          <div className="ml-1">{FulgurSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
    case 9:
      return (
        <div className="flex m-auto">
          <span>Эфир</span>
          <div className="ml-1">{AetherSVG()}</div>
          {amount !== 0 ? <p>(x{amount});</p> : <p></p>}
        </div>
      );
  }
};

/////////////////////////////////////////////////////

const drawArmor = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Тип брони">
        <div>Тип брони</div>
        <div>{drawArmorType(data)}</div>
      </div>
      <div className="stat" title="Надежность">
        <div>Над</div>
        <div>{data.reliability}</div>
      </div>
      <div className="stat" title="Количество улучшений">
        <div>Улуч</div>
        <div>{data.amountOfEnhancements}</div>
      </div>
      <div className="stat" title="Скованность движений">
        <div>СД</div>
        <div>{data.stiffness}</div>
      </div>
      <div className="stat" title="Создатель">
        <div>Создатель</div>
        <div>{drawItemOriginType(data)}</div>
      </div>
      <div className="stat" title="Свойства">
        <div>
          <div>Свойства</div>
          {data.itemBaseEffectList.length > 0 ? (
            <div>
              {data.itemBaseEffectList.map((effect, index) => (
                <a key={index} title={effect.effect.description}>
                  {effect.effect.name}({effect.chancePercent}%);{" "}
                </a>
              ))}
            </div>
          ) : (
            <div>-</div>
          )}
        </div>
      </div>
    </li>
  );
};

const drawFormula = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Сложность">
        <div>СЛ</div>
        <div>{data.complexity}</div>
      </div>
      <div className="stat" title="Количество затрачеваемого времени">
        <div>Время</div>
        <div>{data.timeSpend}</div>
      </div>
      <div className="stat" title="Доплата">
        <div>Доплата</div>
        <div>{data.additionalPayment}</div>
      </div>
      <div className="stat" title="Компоненты">
        <div>Компоненты</div>
        {data.formulaSubstanceList.length > 0 ? (
          data.formulaSubstanceList.map((item, index) =>
            drawSubstanceType(item.substanceType, item.amount)
          )
        ) : (
          <div>-</div>
        )}
      </div>
    </li>
  );
};

const drawBlueprint = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Сложность">
        <div>СЛ</div>
        <div>{data.complexity}</div>
      </div>
      <div className="stat" title="Количество затрачеваемого времени">
        <div>Время</div>
        <div>{data.timeSpend}</div>
      </div>
      <div className="stat" title="Доплата">
        <div>Доплата</div>
        <div>{data.additionalPayment}</div>
      </div>
      <div className="stat" title="Компоненты">
        <div>Компоненты</div>
        {data.blueprintComponentList.length > 0 ? (
          <div>
            {data.blueprintComponentList.map((item, index) => (
              <a key={index}>
                {item.component.name}(x{item.amount});{" "}
              </a>
            ))}
          </div>
        ) : (
          <div>-</div>
        )}
      </div>
    </li>
  );
};

const drawComponent = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Местность">
        <div>Местность</div>
        <div>{data.whereToFind}</div>
      </div>
      <div className="stat" title="Количество">
        <div>Количество</div>
        <div>{data.amount}</div>
      </div>
      <div className="stat" title="Сложность">
        <div>СЛ</div>
        <div>{data.complexity}</div>
      </div>
      {data.isAlchemical ? (
        <div className="stat" title="Тип субстанции">
          <div>Тип субстанции</div>
          {drawSubstanceType(data.substanceType, 0)}
        </div>
      ) : (
        <div></div>
      )}
    </li>
  );
};

const drawItem = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Скрытность">
        <div>Скрыт</div>
        <div title={StealthTypeTooltip(data.stealthType)}>{drawStealthType(data)}</div>
      </div>
    </li>
  );
};

const drawTool = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Скрытность">
        <div>Скрыт</div>
        <div title={StealthTypeTooltip(data.stealthType)}>{drawStealthType(data)}</div>
      </div>
    </li>
  );
};

const drawWeapon = (data: ItemDTO) => {
  return (
    <li className="stats flex flex-row py-2 flex-wrap">
      <div className="stat" title="Точность">
        <div>Тип</div>
        <div title={AttackTypeToString(data.type)}>{AttackTypeToShortString(data.type)}</div>
      </div>
      <div className="stat" title="Точность">
        <div>Точ</div>
        <div>{data.accuracy}</div>
      </div>
      <div className="stat" title="Урон">
        <div>Урон</div>
        <div>{data.damage}</div>
      </div>
      <div className="stat" title="Надежность">
        <div>Над</div>
        <div>{data.reliability}</div>
      </div>
      <div className="stat" title="Хват">
        <div>Хват</div>
        <div>{data.grip}</div>
      </div>
      <div className="stat" title="Дистанция">
        <div>Дист</div>
        <div>{data.distance}</div>
      </div>
      <div className="stat" title="Скрытность">
        <div>Скрыт</div>
        <div title={StealthTypeTooltip(data.stealthType)}>{drawStealthType(data)}</div>
      </div>
      <div className="stat" title="Количество улучшений">
        <div>Улуч</div>
        <div>{data.amountOfEnhancements}</div>
      </div>
      <div className="stat" title="Создатель">
        <div>Создатель</div>
        <div>{drawItemOriginType(data)}</div>
      </div>
      <div className="stat" title="Свойства">
        <div>
          <div>Свойства</div>
          {data.itemBaseEffectList.length > 0 ? (
            <div>
              {data.itemBaseEffectList.map((effect, index) => (
                <a key={index} title={effect.effect.description}>
                  {effect.effect.name}({effect.chancePercent}%);{" "}
                </a>
              ))}
            </div>
          ) : (
            <div>-</div>
          )}
        </div>
      </div>
    </li>
  );
};

const drawItemFromType = (data: ItemDTO) => {
  switch (data.itemType) {
    case 1:
      return <div></div>;
    case 2:
      return drawTool(data);
    case 3:
      return (
        <li className="stats flex flex-row py-2 flex-wrap">
          <div className="stat" title="Свойства">
            <div>
              <div>Свойства</div>
              {data.itemBaseEffectList.length > 0 ? (
                <div>
                  {data.itemBaseEffectList.map((effect, index) => (
                    <a key={index} title={effect.effect.description}>
                      {effect.effect.name}(
                        {effect.chancePercent && effect.chancePercent !== 0 ? (effect.chancePercent + "%") : (effect.damage)}
                        );{" "}
                    </a>
                  ))}
                </div>
              ) : (
                <div>-</div>
              )}
            </div>
          </div>
        </li>
      );
    case 4:
      return drawArmor(data);
    case 5:
      return drawWeapon(data);
    case 6:
      return drawFormula(data);
    case 7:
      return drawBlueprint(data);
    case 8:
      return drawComponent(data);
    case 9:
      return drawItem(data);
  }
};

export {
  drawArmor,
  drawArmorEquipmentType,
  drawArmorType,
  drawAvailabilityType,
  drawBlueprint,
  drawComponent,
  drawFormula,
  drawItem,
  drawItemEntityType,
  drawItemFromType,
  drawItemOriginType,
  drawStealthType,
  drawTool,
  drawWeapon,
  drawWeaponEquipmentType,
  drawSubstanceType,

  StealthTypeTooltip,
  AvailabilityTypeTooltip,
};