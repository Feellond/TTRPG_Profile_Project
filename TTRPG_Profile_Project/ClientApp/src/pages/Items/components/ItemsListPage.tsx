import { Card } from "primereact/card";
import React from "react";
import { EntityList } from "widgets/List";

const ItemsListPage = () => {

    return (
        <Card style={{minHeight: '500px', width: '1500px', margin: '0 auto' }} >
            <EntityList></EntityList>
        </Card>
    );
}

export {ItemsListPage}