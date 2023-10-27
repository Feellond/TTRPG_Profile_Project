import React, { useContext, useEffect } from "react";
import { Outlet, redirect, useLocation, useNavigate } from "react-router-dom";
import { Context } from "../../..";

const LayoutCommon = () => {
  const { store } = useContext(Context);
  const navigate = useNavigate()

  let location = useLocation()

  return (
    <div>
      <div className="flex flex-row layout-header p-3 z-5 relative align-items-center justify-content-between">
        <div className="flex flex-row align-items-center" style={{ height: '100%' }}>
          <div className='flex flex-row' onClick={() => navigate('/')}>
            <div className="layout-header__logo" style={{ cursor: 'pointer' }}>
            </div>
            <div className="layout-header__text" style={{ cursor: 'pointer' }}>
              <h3>
                witcher.su
              </h3>
            </div>
          </div>
          <div style={{ fontFamily: 'sans-serif', fontWeight: "normal", color: "#fff", marginLeft: '5rem', fontSize: '25px', cursor: 'pointer' }}>
            {location.pathname === '/userstable' && <div style={{ height: '100%', display: "inline-block", marginRight:'25px'}} onClick={() => navigate('/ctsvinfo')}>Добавить должность</div>}
            {(location.pathname === '/' || location.pathname === '/ctsvinfo') && <div style={{ height: '100%', display: "inline-block" }} onClick={() => navigate('/userstable')}>Войти в ЦТСВ</div>}
            {(location.pathname === '/userstable'  || location.pathname === '/ctsvinfo') && <div style={{ height: '100%', display: "inline-block", marginLeft: '25px' }} onClick={() => navigate('/')}>Вернуться в меню</div>}
          </div>
        </div>
      </div>
      <Outlet />
    </div>
  );
};

export { LayoutCommon };
