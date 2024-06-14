export const ComplexityValueToString = (value: number) => {
    switch (value) {
      case 1:
        return "Простой обычный [1]";
      case 2:
        return "Простой незаурядный [2]";
      case 3:
        return "Простой трудный [3]";
      case 4:
        return "Средний обычный [4]";
      case 5:
        return "Средний незаурядный [5]";
      case 6:
        return "Средний трудный [6]";
      case 7:
        return "Сложный обычный [7]";
      case 8:
        return "Сложный незаурядный [8]";
      case 9:
        return "Сложный трудный [9]";
      case 10:
        return "Уникальный [10]";
      default:
        return value;
    }
  };

  export const AttackTypeToShortString = (type: number) => {
    switch (type) {
      case 1: 
        return "К";
      case 2:
        return "Р";
      case 3:
        return "Д";
      case 4:
        return "К/Р";
      case 5:
        return "Р/Д";
      case 6:
        return "К/Д";
      case 7:
        return "К/Р/Д";
    }
  }

  export const AttackTypeToString = (type: number) => {
    switch (type) {
      case 1: 
        return "Колющий";
      case 2:
        return "Рубящий";
      case 3:
        return "Дробящий";
      case 4:
        return "Колющий/Рубящий";
      case 5:
        return "Рубящий/Дробящий";
      case 6:
        return "Колющий/Дробящий";
      case 7:
        return "Колющий/Рубящий/Дробящий";
    }
  }