export const ComplexityValueToString = (value) => {
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