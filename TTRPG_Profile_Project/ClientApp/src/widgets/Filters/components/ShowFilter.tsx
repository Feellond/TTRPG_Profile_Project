import React, { FC } from "react";
import {
  ClassFilterDTO,
  CreatureFilterDTO,
  ItemFilterDTO,
  RaceFilterDTO,
  SpellFilterDTO,
} from "shared/models";
import { ItemFilter } from "./ItemFilter";
import { BestiaryFilter, SpellFilter } from "..";
import { RaceFilter } from "./RaceFilter";
import { ClassFilter } from "./ClassFilter";

type Props = {
  filter: ItemFilterDTO | CreatureFilterDTO | SpellFilterDTO | RaceFilterDTO | ClassFilterDTO;
  setFilter: React.Dispatch<
    React.SetStateAction<ItemFilterDTO | CreatureFilterDTO | SpellFilterDTO | RaceFilterDTO | ClassFilterDTO>
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
  } else if ("race" in filter) {
    // Переменная data имеет тип BestiaryDTO
    content = (
      <div>
        <BestiaryFilter
          filter={filter as CreatureFilterDTO}
          setFilter={setFilter}
        />
      </div>
    );
  } else if ("onlyPlayable" in filter) {
    content = (
      <div>
        <RaceFilter
          filter={filter as RaceFilterDTO}
          setFilter={setFilter}
        />
      </div>
    );
  } else if ("classSkill" in filter) {
    content = (
      <div>
        <ClassFilter
          filter={filter as ClassFilterDTO}
          setFilter={setFilter}
        />
      </div>
    );
  }

  return <div>{content}</div>;
};

export { ShowFilter };
