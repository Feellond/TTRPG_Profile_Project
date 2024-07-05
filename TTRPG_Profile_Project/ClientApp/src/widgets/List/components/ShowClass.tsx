import React, { useEffect, useRef, useState } from "react";
import { IClass, ISkill } from "shared/models";
import { OverlayPanel } from "primereact/overlaypanel";

interface IShowClass {
  data: IClass;
}

export const ShowClass = ({ data }: IShowClass) => {
  const [width, setWidth] = useState(window.innerWidth);
  const overlayPanel = useRef(null);
  const [skillDescription, setSkillDescription] = useState<string>("");

  const skillClick = (
    skill: ISkill,
    e: React.MouseEvent<HTMLDivElement, MouseEvent>
  ) => {
    setSkillDescription(skill.description);
    overlayPanel.current.toggle(e);
  };

  useEffect(() => {
    const handleResize = (event) => {
      setWidth(event.target.innerWidth);
    };
    window.addEventListener("resize", handleResize);
    return () => {
      window.removeEventListener("resize", handleResize);
    };
  }, []);

  return (
    <div>
      <OverlayPanel
        ref={overlayPanel}
        showCloseIcon
        closeOnEscape
        style={{
          width: width > 700 ? "40rem" : "auto",
          margin: "0px 20px"
        }}
      >
        <span>{skillDescription}</span>
      </OverlayPanel>
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
          <div className="flex flex-wrap">
            <span>Дерево навыков:</span>
            <div>
              <div
                className="text-center mb-2 cursor-pointer"
                onClick={(e) => skillClick(data.skillsTree.mainSkill, e)}
              >
                {data.skillsTree.mainSkill.name}
              </div>
              <div className="flex text-center">
                <div className="flex flex-column">
                  <span className="text-center font-semibold underline">
                    {data.skillsTree.leftBranchName}
                  </span>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.firstLeftSkill, e)
                    }
                  >
                    {data.skillsTree.firstLeftSkill.name}
                    {data.skillsTree.firstLeftSkill.stat ? (<span>({data.skillsTree.firstLeftSkill.stat.name})</span>) : ""}
                  </div>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.secondLeftSkill, e)
                    }
                  >
                    {data.skillsTree.secondLeftSkill.name}
                    {data.skillsTree.secondLeftSkill.stat ? (<span>({data.skillsTree.secondLeftSkill.stat.name})</span>) : ""}
                  </div>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.thirdLeftSkill, e)
                    }
                  >
                    {data.skillsTree.thirdLeftSkill.name}
                    {data.skillsTree.thirdLeftSkill.stat ? (<span>({data.skillsTree.thirdLeftSkill.stat.name})</span>) : ""}
                  </div>
                </div>
                <div className="flex flex-column ml-3">
                  <span className="text-center font-semibold underline">
                    {data.skillsTree.middleBranchName}
                  </span>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.firstMiddleSkill, e)
                    }
                  >
                    {data.skillsTree.firstMiddleSkill.name}
                    {data.skillsTree.firstMiddleSkill.stat ? (<span>({data.skillsTree.firstMiddleSkill.stat.name})</span>) : ""}
                  </div>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.secondMiddleSkill, e)
                    }
                  >
                    {data.skillsTree.secondMiddleSkill.name}
                    {data.skillsTree.secondMiddleSkill.stat ? (<span>({data.skillsTree.secondMiddleSkill.stat.name})</span>) : ""}
                  </div>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.thirdMiddleSkill, e)
                    }
                  >
                    {data.skillsTree.thirdMiddleSkill.name}
                    {data.skillsTree.thirdMiddleSkill.stat ? (<span>({data.skillsTree.thirdMiddleSkill.stat.name})</span>) : ""}
                  </div>
                </div>
                <div className="flex flex-column ml-3">
                  <span className="text-center font-semibold underline">
                    {data.skillsTree.rightBranchName}
                  </span>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.firstRightSkill, e)
                    }
                  >
                    {data.skillsTree.firstRightSkill.name}
                    {data.skillsTree.firstRightSkill.stat ? (<span>({data.skillsTree.firstRightSkill.stat.name})</span>) : ""}
                  </div>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.secondRightSkill, e)
                    }
                  >
                    {data.skillsTree.secondRightSkill.name}
                    {data.skillsTree.secondRightSkill.stat ? (<span>({data.skillsTree.secondRightSkill.stat.name})</span>) : ""}
                  </div>
                  <div className="cursor-pointer"
                    onClick={(e) =>
                      skillClick(data.skillsTree.thirdRightSkill, e)
                    }
                  >
                    {data.skillsTree.thirdRightSkill.name}
                    {data.skillsTree.thirdRightSkill.stat ? (<span>({data.skillsTree.thirdRightSkill.stat.name})</span>) : ""}
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
