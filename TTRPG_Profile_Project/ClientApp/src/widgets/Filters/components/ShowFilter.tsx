import React, { FC } from "react";
import {
  CreatureFilterDTO,
  ItemFilterDTO,
  SpellFilterDTO,
} from "shared/models";
import { ItemFilter } from "./ItemFilter";
import { BestiaryFilter, SpellFilter } from "..";

type Props = {
  filter: ItemFilterDTO | CreatureFilterDTO | SpellFilterDTO;
  setFilter: React.Dispatch<
    React.SetStateAction<ItemFilterDTO | CreatureFilterDTO | SpellFilterDTO>
  >;
};

const ShowFilter: FC<Props> = ({ filter, setFilter }) => {
  let content: JSX.Element;

  if ("itemType" in filter) {
    // Переменная data имеет тип ItemDTO
    content = (
      <div>
        <ItemFilter filter={filter as ItemFilterDTO} setFilter={setFilter} />
      </div>
    );
  } else if ("spellLevel" in filter) {
    // Переменная data имеет тип SpellDTO
    content = (
      <div>
        <SpellFilter filter={filter as SpellFilterDTO} setFilter={setFilter} />
      </div>
    );
  } else {
    // Переменная data имеет тип BestiaryDTO
    console.log("filter: ", filter);
    content = (
      <div>
        <BestiaryFilter
          filter={filter as CreatureFilterDTO}
          setFilter={setFilter}
        />
      </div>
    );
  }

  return <div>{content}</div>;
};

export { ShowFilter };
