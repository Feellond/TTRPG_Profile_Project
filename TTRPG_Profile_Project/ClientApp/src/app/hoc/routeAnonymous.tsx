import React, { useContext } from "react";
import { Navigate } from "react-router-dom";
import { Context } from "../..";
import { NAV_MAIN } from "../../shared/api/const";

const RouteAnonymous = ({jsx}) => {
    const {store} = useContext(Context);

    if(store.isAuth)
    {
        return <Navigate replace to={NAV_MAIN} />
    }
    else
    {
        return jsx;
    }
}

export default RouteAnonymous;