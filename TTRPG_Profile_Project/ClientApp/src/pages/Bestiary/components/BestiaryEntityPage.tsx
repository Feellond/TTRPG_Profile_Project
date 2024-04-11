import { Card } from "primereact/card";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { emptyCreature, ICreature } from "shared/models";
import bestiaryService from "shared/services/bestiary.service";
import { CreatureEntity } from "widgets/Entity";

const BestiaryEntityPage = () => {
  const [data, setData] = useState<ICreature>(emptyCreature);
  const { id } = useParams();

  useEffect(() => {}, []);

  useEffect(() => {
    fetchData(); 
  }, [id]);

  const fetchData = async () => {
    let responce = await bestiaryService.getEntity({ id: Number(id) });
    console.log(responce);

    if (responce && responce.data) {
      console.log(responce.data);
      let entityList: ICreature[] = responce.data.entitys;
      setData(entityList[0]);
    }
  };

  return (
    <Card style={{ minHeight: "500px", margin: "0 auto" }}>
      <CreatureEntity data={data} setData={setData}/>
    </Card>
  );
};

export { BestiaryEntityPage };
