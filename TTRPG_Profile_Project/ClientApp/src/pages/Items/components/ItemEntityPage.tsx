import { Card } from "primereact/card";
import React from "react";
import { useParams } from "react-router-dom";

const ItemEntityPage = () => {
    const { id } = useParams();

    return (
        <Card style={{minHeight: '500px', width: '1500px', margin: '0 auto' }} >
            Конкретный элемент
        </Card>
    )
}

export {ItemEntityPage}