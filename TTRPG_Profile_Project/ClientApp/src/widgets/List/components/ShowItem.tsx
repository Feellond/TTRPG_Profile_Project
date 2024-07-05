import React, { useEffect } from "react";
import { ItemDTO } from "shared/models";
import {
  drawArmorEquipmentType,
  drawAvailabilityType,
  drawItemEntityType,
  drawItemFromType,
  drawWeaponEquipmentType,
} from "..";

interface ShowItemProps {
  data: ItemDTO;
}

const ShowItem = ({ data }: ShowItemProps) => {
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
            {drawItemEntityType(data)}
            {drawAvailabilityType(data)}
            {drawWeaponEquipmentType(data)}
            {drawArmorEquipmentType(data)}, {data.source?.name}
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
        {drawItemFromType(data)}
        <li className="my-2">
          <div>{data.description}</div>
        </li>
      </ul>
    </div>
  );
};

export { ShowItem };
