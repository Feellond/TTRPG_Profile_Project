import React from "react";
import { IRace } from "shared/models";

interface IShowRace {
    data: IRace;
  }

export const ShowRace = ({data}: IShowRace) => {
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
                <i>{data.source?.name}</i>
            </li>
            <li>
                <span>
                    Описание: {data.description}
                </span>
            </li>
          </ul>
        </div>
      );
}