import React from 'react'
import { Route } from 'react-router-dom'
import RouteAnonymous from '../../app/hoc/routeAnonymous'

export const router = createBrowserRouter(createRoutesFromElements(
    <>
        <Route path='/' element={<RouteAnonymous jsx={<LayoutCommon />} />}>
            <Route index element={<RouteAnonymous jsx={<Home />} />} />
        </Route>
    </>))