import { AetherSVG, CaelumSVG, FulgurSVG, HydragenumSVG, QuebrithSVG, RebisSVG, SolSVG, VermilionSVG, VitriolSVG } from "img";
import React, { useEffect } from "react";
import { ItemDTO } from "shared/models";

interface ShowItemProps {
  data: ItemDTO;
}

const ShowItem = ({ data }: ShowItemProps) => {
  const drawWeaponEquipmentType = () => {
    switch (data.equipmentType) {
      case 1:
        return "Мечи";
      case 2:
        return "Кинжалы";
      case 3:
        return "Топоры";
      case 4:
        return "Дробящее";
      case 5:
        return "Копья";
      case 6:
        return "Посохи";
      case 7:
        return "Метательное";
      case 8:
        return "Луки";
      case 9:
        return "Арбалеты";
      case 10:
        return "Боеприпас";
    }
  };

  const drawArmorEquipmentType = () => {
    switch (data.equipmentType) {
      case 1:
        return "Голова";
      case 2:
        return "Тело";
      case 3:
        return "Ноги";
      case 4:
        return "Щит";
      case 5:
        return "Ведьмачий";
    }
  };

  const drawArmorType = () => {
    switch (data.type) {
      case 1:
        return "Легкий";
      case 2:
        return "Средний";
      case 3:
        return "Тяжелый";
    }
  };

  const drawItemOriginType = () => {
    switch (data.itemOriginType) {
      case 1:
        return "Люди";
      case 2:
        return "Старший народ";
      case 3:
        return "Ведьмачий";
      case 4:
        return "Реликт";
    }
  };

  const drawStealthType = () => {
    switch (data.stealthType) {
      case 1:
        return "Н/С";
      case 2:
        return "Б";
      case 3:
        return "С";
      case 4:
        return "Н";
    }
  };

  const drawAvailabilityType = () => {
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

  const drawSubstanceType = (substanceType: number, amount: number) => {
    switch (substanceType) {
      case 1:
        return (
          <div className="flex m-auto">
            Аэр
            {CaelumSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 2:
        return (
          <div className="flex m-auto">
            Гидраген
            {HydragenumSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 3:
        return (
          <div className="flex m-auto">
            Квебрит
            {QuebrithSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 4:
        return (
          <div className="flex m-auto">
            Киноварь
            {VermilionSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 5:
        return (
          <div className="flex m-auto">
            Купорос
            {VitriolSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 6:
        return (
          <div className="flex m-auto">
            Рэбис
            {RebisSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 7:
        return (
          <div className="flex m-auto">
            Солнце
            {SolSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 8:
        return (
          <div className="flex m-auto">
            Фульгор
            {FulgurSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
      case 9:
        return (
          <div className="flex m-auto">
            Эфир
            {AetherSVG()}
            {amount !== 0 ? (<p>(x{amount});</p>) : (<p></p>)}
          </div>
        );
    }
  };

  const drawItemEntityType = () => {
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

  /////////////////////////////////////////////////////

  const drawArmor = () => {
    return (
      <li className="stats flex flex-row py-2">
        <div className="stat" title="Тип брони">
          <div>Тип брони</div>
          <div>{drawArmorType()}</div>
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
      </li>
    );
  };

  const drawFormula = () => {
    return (
      <li className="stats flex flex-row py-2">
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

  const drawBlueprint = () => {
    return (
      <li className="stats flex flex-row py-2">
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

  const drawComponent = () => {
    return (
      <li className="stats flex flex-row py-2">
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
        ) : (<div></div>)}
      </li>
    );
  };

  const drawItem = () => {
    return (
      <li className="stats flex flex-row py-2">
        <div className="stat" title="Скрытность">
          <div>Скрыт</div>
          <div>{drawStealthType()}</div>
        </div>
      </li>
    );
  };

  const drawTool = () => {
    return (
      <li className="stats flex flex-row py-2">
        <div className="stat" title="Скрытность">
          <div>Скрыт</div>
          <div>{drawStealthType()}</div>
        </div>
      </li>
    );
  };

  const drawWeapon = () => {
    return (
      <li className="stats flex flex-row py-2">
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
          <div>{drawStealthType()}</div>
        </div>
        <div className="stat" title="Количество улучшений">
          <div>Улуч</div>
          <div>{data.amountOfEnhancements}</div>
        </div>
        <div className="stat" title="Свойства">
          <div>
            <div>Свойства</div>
            {data.itemBaseEffectList.length > 0 ? (
              <div>
                {data.itemBaseEffectList.map((effect, index) => (
                  <a key={index}>
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

  const drawItemFromType = () => {
    switch (data.itemType) {
      case 1:
        return <div></div>;
      case 2:
        return drawTool();
      case 3:
        return <div></div>;
      case 4:
        return drawArmor();
      case 5:
        return drawWeapon();
      case 6:
        return drawFormula();
      case 7:
        return drawBlueprint();
      case 8:
        return drawComponent();
      case 9:
        return drawItem();
    }
  };

  useEffect(() => {}, [data]);

  //Когда будут добавлены изображения, то добавить это после <ul className="p-2 params">
  //<li style={{ float: "right" }}>Изображение</li>
  return (
    <div>
      <div
        className="p-2 text-2xl font-semibold cursor-pointer"
        style={{ marginBottom: "-10px" }}
      >
        <a href="listitem/">{data.name}</a>
      </div>
      <ul className="p-2 params">
        <li>
          <i>
            {drawItemEntityType()}
            {drawAvailabilityType()}
          </i>
        </li>
        <li>
          <strong>Стоимость</strong> {data.price},<strong> Вес:</strong>{" "}
          {data.weight}кг
        </li>
        {data.skill !== null ? (
          <li>
            <strong>Требуемый навык:</strong>
            <a>{data.skill.name}</a>
          </li>
        ) : (
          <div></div>
        )}
        {drawItemFromType()}
        <li className="my-2">
          <div>{data.description}</div>
        </li>
      </ul>
    </div>
  );
};

export { ShowItem };
