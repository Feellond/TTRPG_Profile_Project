import React from "react";
import { ItemDTO } from "shared/models";

interface ShowItemProps {
  data: ItemDTO;
}

const ShowItem = ({
  data,
}: ShowItemProps) => {
  return (
    <div>
      <div
        className="p-2 text-2xl font-semibold cursor-pointer"
        style={{ marginBottom: "-10px" }}
      >
        <a href="listitem/1">Элемент под наименованием 1 item.Name</a>
      </div>
      <ul className="p-2 params">
        <li style={{ float: "right" }}>Изображение</li>
        <li>
          <i>Оружие, Редкий</i>
        </li>
        <li>
          <strong>Стоимость в кронах:</strong> 1000,
          <strong> Вес:</strong> 0,5кг
        </li>
        <li>
          <strong>Требуемый навык:</strong>
          <a> Владение мечом</a>
        </li>
        <li className="stats flex flex-row py-2">
          <div className="stat" title="Точность">
            <div>Точ</div>
            <div>+0</div>
          </div>
          <div className="stat" title="Урон">
            <div>Урон</div>
            <div>3к6+2</div>
          </div>
          <div className="stat" title="Надежность">
            <div>Над</div>
            <div>10</div>
          </div>
          <div className="stat" title="Хват">
            <div>Хват</div>
            <div>1</div>
          </div>
          <div className="stat" title="Дистанция">
            <div>Дист</div>
            <div>-</div>
          </div>
          <div className="stat" title="Скрытность">
            <div>Скрыт</div>
            <div>Н/С</div>
          </div>
          <div className="stat" title="Количество улучшений">
            <div>Улуч</div>
            <div>1</div>
          </div>
          <div className="stat" title="Свойства">
            <div>Свойства</div>
            <div>
              <a>Горение(75%); </a>
              <a>Кровотечение(25%) </a>
              <a>Отравление(25%) </a>
            </div>
          </div>
        </li>
        <li className="my-2">
          <div>
            Дополнительная информация о предмете и возможно наиболее полная
          </div>
        </li>
      </ul>
    </div>
  );
};

export { ShowItem };
