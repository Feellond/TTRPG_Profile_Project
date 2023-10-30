import { Context } from "index";
import React, { useContext } from "react";

const RouteAnonymous = ({ jsx }) => {
  const { store } = useContext(Context);

  return jsx;
};

export default RouteAnonymous;
