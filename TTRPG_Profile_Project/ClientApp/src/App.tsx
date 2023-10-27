import React, { RefObject, createContext, useContext, useEffect, useRef } from 'react';
import { RouterProvider } from 'react-router-dom';
import { router } from './shared/routes/Routes'
// import "primereact/resources/themes/saga-blue/theme.css"
// import "primereact/resources/primereact.min.css";
// import 'primeflex/primeflex.css';
// import 'primeicons/primeicons.css';
import { observer } from 'mobx-react-lite';
import { Navigate } from "react-router-dom";
import { Toast } from 'primereact/toast';
import Store from './shared/store/store';
import { Context } from '.';

export type IContextProps ={
  globalToast?:RefObject<Toast>
  store?: Store 
}

export const App = () => {
  const { store } = useContext(Context);

  const contextProps: IContextProps = {
    globalToast: undefined,
    store: undefined
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