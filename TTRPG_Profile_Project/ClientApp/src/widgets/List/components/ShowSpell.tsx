import {
  drawSpellCategory,
  drawSpellLevel,
  drawSpellSourceType,
  drawSpellType,
} from "entities/DrawSpell";
import React, { useEffect, useRef, useState } from "react";
import { WEBSITE } from "shared/api/api_const";
import { SpellCategory, SpellType } from "shared/enums/SpellEnums";
import { ISpell } from "shared/models";

interface IShowSpellProps {
  data: ISpell;
}

const ShowSpell = ({ data }: IShowSpellProps) => {
  let name_href = WEBSITE + "spells?name=" + String(data.name);

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
      <ul className="p-2 params" style={{width: "fit-content"}}>
        <li>
          <i>{drawSpellType(data.spellType)}, </i>
          <i>{drawSpellLevel(data.spellLevel)}, </i>
          <i>{drawSpellSourceType(data.sourceType)}</i>
          {data.isDruidSpell ? (
            <i>, {drawSpellCategory(SpellCategory.DruidInvocation)}</i>
          ) : (
            ""
          )}
          {data.isPriestSpell ? (
            <i>, {drawSpellCategory(SpellCategory.PriestInvocation)}</i>
          ) : (
            ""
          )}
          <i>, {data.source?.name}</i>
        </li>
        <li>
          <div>
            <span><strong>Затраты вын:</strong> {data.enduranceCost}</span>
          </div>
        </li>
        <li className="my-2">
          <div>
            <span><strong>Эффект:</strong> {data.description}</span>
          </div>
        </li>
        {data.spellType !== SpellType.Ritual &&
        data.spellType !== SpellType.Hex ? (
          <li>
            <div>
              <span>
                <strong>Дистанция:</strong> {data.distance === 0 ? "на себя" : data.distance}
              </span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType !== SpellType.Hex ? (
          <li>
            <div>
              <span>
                <strong>Длительность:</strong> {data.duration}{" "}
                {data.isConcentration ? (
                  <span>({data.concentrationEnduranceCost} Вын)</span>
                ) : (
                  ""
                )}
              </span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType === SpellType.Ritual ? (
          <li>
            <div>
              <span><strong>Время подготовки:</strong> {data.preparationTime}</span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType === SpellType.Ritual ? (
          <li>
            <div>
              <span><strong>Сложность проверки:</strong> {data.checkDC}</span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType === SpellType.Ritual ? (
          <li>
              <div>
                <strong>Ингредиенты:</strong>{" "}
                <div className="flex flex-column line-height-3">
                {data.spellComponentList.map((component, index) => (
                  <a key={index} href={"listitem?name=" + component.component.name} target="_blank" rel="noreferrer">
                    {component.component.name} (x{component.amount})
                  </a>
                ))}
                </div>
              </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType !== SpellType.Ritual &&
        data.spellType !== SpellType.Hex ? (
          <li>
            <div>
              <span>
                <strong>Защита:</strong>{" "}
                {data.spellSkillProtectionList.length > 0 ? (
                  <span>
                    {data.spellSkillProtectionList.map((skill, index) => (
                      <span key={index}>
                        {index !== 0 ? ", " : ""}
                        {skill.skill?.name}
                        {skill.moreInfo}
                      </span>
                    ))}
                  </span>
                ) : (
                  <span>Нет</span>
                )}
              </span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType === SpellType.Hex ? (
          <li>
            <span><strong>Условия снятия:</strong> {data.withdrawalCondition}</span>
          </li>
        ) : (
          <div></div>
        )}
      </ul>
    </div>
  );
};

export { ShowSpell };
