import { Context } from "index";
import React, { useContext } from "react";
import { Outlet, useLocation, useNavigate } from "react-router-dom";
import "../scss/layoutStyle.scss";

const LayoutCommon = () => {
  const { store } = useContext(Context);
  const navigate = useNavigate();

  let location = useLocation();

  return (
    <div>
      <div className="flex flex-row layout-header p-2 z-5 relative align-items-center justify-content-between">
        <div
          className="flex flex-row align-items-center"
          style={{ height: "100%" }}
        >
          <div className="flex flex-row">
            <div className="layout-header__text mx-4">
              <h3>witcher.su</h3>
            </div>
          </div>
        </div>
      </div>
      <div className="layout-content">
        <aside className="aside">
          <nav>
            <ul className="layout__left-menu">
              <li className="layout__left-menu__item">
                <a href="#" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Главная</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="#" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Бестиарий</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="#" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Заклинания</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="#" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Предметы</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="#" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Расы</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="#" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Классы</span>
                </a>
              </li>
            </ul>
          </nav>
        </aside>
        <div className="center">
          <Outlet />
        </div>
      </div>
    </div>
  );
};

export { LayoutCommon };
