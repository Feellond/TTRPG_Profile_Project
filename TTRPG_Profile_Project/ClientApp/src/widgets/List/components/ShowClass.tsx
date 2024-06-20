import React from "react";
import { IClass, IRace } from "shared/models";

interface IShowClass {
  data: IClass;
}

export const ShowClass = ({ data }: IShowClass) => {
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
          <i>{data.source.name}</i>
        </li>
        <li>
          <span>Энергия: {data.energy}</span>
        </li>
        <li>
          <div className="flex">
            <span>Дерево навыков:</span>
            <div>
              <div className="text-center mb-2">
                Основной Id:{data.skillsTree.mainSkillId} Value:
                {data.skillsTree.mainSkillValue}
              </div>
              <div className="flex text-center">
                <div className="flex flex-column">
                  <span className="text-center">Первая ветка</span>
                  <div>
                    Первый Id:{data.skillsTree.firstLeftSkillId} Value:
                    {data.skillsTree.firstLeftSkillValue}
                  </div>
                  <div>
                    Второй Id:{data.skillsTree.secondLeftSkillId} Value:
                    {data.skillsTree.secondLeftSkillValue}
                  </div>
                  <div>
                    Третий Id:{data.skillsTree.thirdLeftSkillId} Value:
                    {data.skillsTree.thirdLeftSkillValue}
                  </div>
                </div>
                <div className="flex flex-column ml-3">
                  <span className="text-center">Вторая ветка</span>
                  <div>
                    Первый Id:{data.skillsTree.firstMiddleSkillId} Value:
                    {data.skillsTree.firstMiddleSkillValue}
                  </div>
                  <div>
                    Второй Id:{data.skillsTree.secondMiddleSkillId} Value:
                    {data.skillsTree.secondMiddleSkillValue}
                  </div>
                  <div>
                    Третий Id:{data.skillsTree.thirdMiddleSkillId} Value:
                    {data.skillsTree.thirdMiddleSkillValue}
                  </div>
                </div>
                <div className="flex flex-column ml-3">
                  <span className="text-center">Третья ветка</span>
                  <div>
                    Первый Id:{data.skillsTree.firstRightSkillId} Value:
                    {data.skillsTree.thirdRightSkillValue}
                  </div>
                  <div>
                    Второй Id:{data.skillsTree.secondRightSkillId} Value:
                    {data.skillsTree.secondRightSkillValue}
                  </div>
                  <div>
                    Третий Id:{data.skillsTree.thirdRightSkillId} Value:
                    {data.skillsTree.thirdRightSkillValue}
                  </div>
                </div>
              </div>
            </div>
          </div>
        </li>
        <li>
          <span>Описание: {data.description}</span>
        </li>
      </ul>
    </div>
  );
};
