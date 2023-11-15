const FindIndexById = (id: number | string, itemList) => {
  try {
    let index = -1;

    for (let i = 0; i < itemList.length; i++) {
      if (itemList[i].id === id) {
        index = i;
        break;
      }
    }

    return index;
  } catch (error) {
    console.error(error)
  }
};

export { FindIndexById };
