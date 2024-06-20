import {
  drawSpellCategory,
  drawSpellLevel,
  drawSpellSourceType,
  drawSpellType,
} from "entities/DrawSpell";
import React, { useEffect } from "react";
import { SpellCategory, SpellType } from "shared/enums/SpellEnums";
import { ISpell } from "shared/models";

interface IShowSpellProps {
  data: ISpell;
}

const ShowSpell = ({ data }: IShowSpellProps) => {
  useEffect(() => {}, [data]);

  return (
    <div>
      <div
        className="p-2 text-2xl font-semibold cursor-pointer"
        style={{ marginBottom: "-10px" }}
      >
        <a>{data.name}</a>
      </div>
      <ul className="p-2 params">
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
            <span>Затраты вын: {data.enduranceCost}</span>
          </div>
        </li>
        <li className="my-2">
          <div>
            <span>Эффект: {data.description}</span>
          </div>
        </li>
        {data.spellType !== SpellType.Ritual &&
        data.spellType !== SpellType.Hex ? (
          <li>
            <div>
              <span>
                Дистанция: {data.distance === 0 ? "на себя" : data.distance}
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
                Длительность: {data.duration}{" "}
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
              <span>Время подготовки: {data.preparationTime}</span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType === SpellType.Ritual ? (
          <li>
            <div>
              <span>СЛ проверки: {data.checkDC}</span>
            </div>
          </li>
        ) : (
          <div></div>
        )}
        {data.spellType === SpellType.Ritual ? (
          <li>
            <div>
              <span>
                Ингредиенты:{" "}
                {data.spellComponentList.map((component, index) => (
                  <span>
                    {index !== 0 ? ", " : ""}
                    {component.component.name} (x{component.amount})
                  </span>
                ))}
              </span>
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
                Защита:{" "}
                {data.spellSkillProtectionList.length > 0 ? (
                  <span>
                    {data.spellSkillProtectionList.map((skill, index) => (
                      <span>
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
            <span>Условия снятия: {data.withdrawalCondition}</span>
          </li>
        ) : (
          <div></div>
        )}
      </ul>
    </div>
  );
};

export { ShowSpell };
