import React, { RefObject, useContext, useEffect, useRef } from 'react';
import { RouterProvider } from 'react-router-dom';
import './scss/main.scss';
import "primereact/resources/themes/saga-blue/theme.css"
import "primereact/resources/primereact.min.css";

import { observer } from 'mobx-react-lite';
import { Toast } from 'primereact/toast';
import { Context } from '.';
import { router } from 'shared/routes/Routes';
import Store from 'shared/store/store';

export type IContextProps ={
  globalToast?:RefObject<Toast>
  store?: Store 
}

export const App = () => {
  const { store } = useContext(Context);

  const contextProps: IContextProps = {
    globalToast: null,
    store: null
  };
  const toastRef = useRef<Toast>(null);

  contextProps.globalToast = toastRef
  contextProps.store = store

  useEffect(() => {
    (async () => {
      //await store.checkAuth();
    })();
  }, [])

  if (store.isLoading) {
    return <div>Загрузка...</div> //Loader
  }

  return (
    <Context.Provider value={{
      store
    }}>
      <Toast ref={toastRef} position='bottom-right' />
      <RouterProvider router={router} />
    </Context.Provider>
  );
}

export default observer(App);