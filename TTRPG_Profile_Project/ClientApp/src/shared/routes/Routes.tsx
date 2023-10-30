import React from 'react'
import { Route, createBrowserRouter, createRoutesFromElements } from 'react-router-dom'
import { ItemsListPage } from 'pages/Items'
import Home from 'pages/Home/Home'
import { LayoutCommon } from 'pages/Layouts'
import RouteAnonymous from 'app/hoc/routeAnonymous'
import { BestiaryListPage, ClassesPage, RacesPage } from 'pages/Bestiary'
import { SpellEntityPage } from 'pages/Spells'

export const router = createBrowserRouter(createRoutesFromElements(
    <>
        <Route path='/' element={<RouteAnonymous jsx={<LayoutCommon />} />}>
            <Route path='listitem' element={<RouteAnonymous jsx={<ItemsListPage/>} />} />
            <Route path='bestiary' element={<RouteAnonymous jsx={<BestiaryListPage/>} />} />
            <Route path='spells' element={<RouteAnonymous jsx={<SpellEntityPage/>} />} />
            <Route path='races' element={<RouteAnonymous jsx={<RacesPage/>} />} />
            <Route path='classes' element={<RouteAnonymous jsx={<ClassesPage/>} />} />
            <Route index element={<RouteAnonymous jsx={<Home />} />} />
        </Route>
    </>))