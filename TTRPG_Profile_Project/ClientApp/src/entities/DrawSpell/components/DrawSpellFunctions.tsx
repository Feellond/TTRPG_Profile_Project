import { SpellCategory } from "shared/enums/SpellEnums";

const drawSpellSourceType = (type: number) => {
  switch (type) {
    case 1:
      return "Смешанный";
    case 2:
      return "Земля";
    case 3:
      return "Огонь";
    case 4:
      return "Воздух";
    case 5:
      return "Вода";
  }
};

const drawSpellLevel = (type: number) => {
  switch (type) {
    case 1:
      return "Новичок";
    case 2:
      return "Подмастерье";
    case 3:
      return "Мастер";
    case 4:
      return "Верховный жрец";
  }
};

const drawSpellType = (type: number) => {
  switch (type) {
    case 1:
      return "Заклинание";
    case 2:
      return "Инвокация";
    case 3:
      return "Знак";
    case 4:
      return "Ритуал";
    case 5:
      return "Порча";
  }
};

const drawSpellCategory = (type: SpellCategory) => {
  switch (type) {
    case SpellCategory.Magic:
      return "Магия";
    case SpellCategory.Necromancy:
      return "Некромантия";
    case SpellCategory.Goethia:
      return "Гоэтия";
    case SpellCategory.PriestInvocation:
      return "Инвокация жреца";
    case SpellCategory.DruidInvocation:
      return "Инвокация друида";
  }
};

export {
  drawSpellCategory,
  drawSpellLevel,
  drawSpellSourceType,
  drawSpellType,
};
