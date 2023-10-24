import React, { useContext } from "react";
import { Navigate } from "react-router-dom";

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