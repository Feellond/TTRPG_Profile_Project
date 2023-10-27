import React from 'react'
import { Route, createBrowserRouter, createRoutesFromElements } from 'react-router-dom'
import RouteAnonymous from '../../app/hoc/routeAnonymous'
import { LayoutCommon } from '../../pages/Layouts'
import Home from '../../pages/Home/Home'

export const router = createBrowserRouter(createRoutesFromElements(
    <>
        <Route path='/' element={<RouteAnonymous jsx={<LayoutCommon />} />}>
            <Route index element={<RouteAnonymous jsx={<Home />} />} />
        </Route>
    </>))