import { Card } from "primereact/card";
import React from "react";
import { ItemList } from "widgets/List";

const ItemsListPage = () => {

  return (
    <Card style={{ minHeight: "500px", width: "1500px", margin: "0 auto" }}>
      <ItemList></ItemList>
    </Card>
  );
};

export { ItemsListPage };
