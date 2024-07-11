import React, { useEffect, useRef, useState } from "react";
import { ItemDTO } from "shared/models";
import {
  drawArmorEquipmentType,
  drawAvailabilityType,
  drawItemEntityType,
  drawItemFromType,
  drawWeaponEquipmentType,
} from "..";
import { WEBSITE } from "shared/api/api_const";

interface ShowItemProps {
  data: ItemDTO;
}

const ShowItem = ({ data }: ShowItemProps) => {
  let name_href = WEBSITE + "listitem?name=" + String(data.name);

  const fadeRef = useRef(null);
  const linkRef = useRef(null);
  const [copied, setCopied] = useState(false);

  const handleCopy = (event) => {
    navigator.clipboard.writeText(linkRef.current.dataset.href).then(() => {
      setCopied(true);
      fadeRef.current.classList.add("copied-indicator-fade"); // Добавление класса для плавного исчезновения
      setTimeout(() => {
        setCopied(false);
        fadeRef.current.classList.remove("copied-indicator-fade"); // Удаление класса после задержки
      }, 1500); // Через 1.5 секунды сбросить состояние
    });
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
        <span
          className="cursor-pointer targetName"
          ref={linkRef}
          onClick={(e) => handleCopy(e)}
          data-href={name_href}
        >
          {data.name}
        </span>
        <span ref={fadeRef} className="copied-indicator">
          {copied && (
            <span
              className="text-base font-normal"
              style={{ marginLeft: "1rem" }}
            >
              <i>Скопировано</i>
            </span>
          )}
        </span>
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
        {data.description && data.description !== "" ? (
          <li className="my-2">
            <div className="text-justify">{data.description}</div>
          </li>
        ) : (
          ""
        )}
      </ul>
    </div>
  );
};

export { ShowItem };
