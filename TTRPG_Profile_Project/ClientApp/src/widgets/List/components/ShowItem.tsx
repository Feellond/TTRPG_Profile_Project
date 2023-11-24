import { InputNumber } from "primereact/inputnumber";
import React, { useEffect } from "react";
import { ItemDTO } from "shared/models";

interface ShowItemProps {
  data: ItemDTO;
}

const ShowItem = ({ data }: ShowItemProps) => {
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
        return "Повсеместное";
      case 2:
        return "Обычное";
      case 3:
        return "Редкое";
      case 4:
        return "Уникальное";
    }
  };

  const drawSubstanceType = () => {
    switch (data.substanceType) {
      case 1:
        return "Аэр";
      case 2:
        return "Гидраген";
      case 3:
        return "Квебрит";
      case 4:
        return "";
      case 5:
        return "";
      case 6:
        return "Рэбис";
      case 7:
        return "";
      case 8:
        return "";
      case 9:
        return "Эфир";
    }
  }

  const drawItemType = () => {
    switch (data.itemType) {
      case 1:
        return "";
      case 2:
        return "Инстурмент";
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

  const drawItemFromType = () => {
    switch (data.itemType) {
      case 1:
        return (<div></div>);
      case 2:
        return (<div></div>);
      case 3:
        return (<div></div>);
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
  }

  const drawArmor = () => {
    return (
      <li className="stats flex flex-row py-2">
        <div className="stat" title="Тип брони">
          <div>Тип брони</div>
          <div>{}</div>
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
  }

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
          {data.formulaComponentLists.length > 0 ? (
              <div>
                {data.formulaComponentLists.map((item, index) => (
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
  }

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
          {data.blueprintComponentLists.length > 0 ? (
              <div>
                {data.blueprintComponentLists.map((item, index) => (
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
  }

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
        <div className="stat" title="Тип субстанции">
          <div>Тип субстанции</div>
          <div>{drawSubstanceType()}</div>
        </div>
      </li>
    );
  }

  const drawItem = () => {
    return (
      <li className="stats flex flex-row py-2">
        <div className="stat" title="Скрытность">
          <div>Скрыт</div>
          <div>{drawStealthType()}</div>
        </div>
      </li>
    );
  }

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
            {data.itemBaseEffectLists.length > 0 ? (
              <div>
                {data.itemBaseEffectLists.map((effect, index) => (
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

  useEffect(() => {}, [data]);

  //Когда будут добавлены изображения, то добавить это после <ul className="p-2 params">
  //<li style={{ float: "right" }}>Изображение</li>
  return (
    <div>
      <div
        className="p-2 text-2xl font-semibold cursor-pointer"
        style={{ marginBottom: "-10px" }}
      >
        <a href="listitem/1">{data.name}</a>
      </div>
      <ul className="p-2 params">
        <li>
          <i>{drawItemType()}, {drawAvailabilityType()}</i>
        </li>
        <li>
          <strong>Стоимость в кронах:</strong> {data.price},
          <strong> Вес:</strong> <InputNumber value={data.weight} suffix="кг" />
        </li>
        <li>
          <strong>Требуемый навык:</strong>
          <a>{data.skill.name}</a>
        </li>
        {drawItemFromType()}
        <li className="my-2">
          <div>
            {data.description}
          </div>
        </li>
      </ul>
    </div>
  );
};

export { ShowItem };
