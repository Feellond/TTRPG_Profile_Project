import { ItemFilter } from "features/Filter";
import React, { useEffect } from "react";

const ItemList = () => {



  useEffect(() => {

  }, [])

  const handleClick = (id, e) => {
    e.preventDefault(); // Предотвращаем переход по ссылке

    const url = `listitem/${id}`;
    window.open(url, "_blank");
  };

  return (
    <div>
      <ItemFilter></ItemFilter>
      map of EntityList
      <div>
        <a href="#" onClick={(e) => handleClick(1, e)}>
          Элемент 1
        </a>
      </div>
      <div>
        <a href="#" onClick={(e) => handleClick(2, e)}>
          Элемент 2
        </a>
      </div>
      <div>
        <a href="#" onClick={(e) => handleClick(3, e)}>
          Элемент 3
        </a>
      </div>
    </div>
  );
};

export { ItemList };
