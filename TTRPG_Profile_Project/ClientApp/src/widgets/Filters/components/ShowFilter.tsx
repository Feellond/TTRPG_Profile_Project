import React, { FC } from "react";
import { ItemFilterDTO } from "shared/models";
import { ItemFilter } from "./ItemFilter";
import { BestiaryFilter, SpellFilter } from "..";

type Props = {
  filter: ItemFilterDTO;
  setFilter: React.Dispatch<React.SetStateAction<ItemFilterDTO>>;
};

const ShowFilter: FC<Props> = ({ filter, setFilter }) => {
  let content: JSX.Element;

  if ("availabilityType" in filter) {
    // Переменная data имеет тип ItemDTO
    content = (
      <div>
        <ItemFilter filter={filter} setFilter={setFilter} />
      </div>
    );
  } else if ("spellLevel" in filter) {
    // Переменная data имеет тип SpellDTO
    content = (
      <div>
        <SpellFilter />
      </div>
    );
  } else {
    // Переменная data имеет тип BestiaryDTO
    content = (
      <div>
        <BestiaryFilter />
      </div>
    );
  }

  return <div>{content}</div>;
};

export { ShowFilter };
