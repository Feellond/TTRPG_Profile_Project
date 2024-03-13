import { Card } from "primereact/card";
import React from "react";
import { SpellList } from "widgets/List";

const SpellsListPage = () => {

    return (
        <Card style={{ minHeight: "500px", margin: "0 auto" }}>
            <SpellList/>
        </Card>
    )
}

export {SpellsListPage}