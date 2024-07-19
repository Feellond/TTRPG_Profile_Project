import React, {useEffect, useState } from "react";
import { Outlet } from "react-router-dom";
import "../scss/layoutStyle.scss";
import { Button } from "primereact/button";

const LayoutCommon = () => {
  const [isActive, setActive] = useState(false);
  const [isVisible, setIsVisible] = useState(false);

  const handleClick = () => {
    setActive(!isActive);
  }

  // Плавное перемещение к началу страницы
  const scrollToTop = () => {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    });
  };

  // Проверка текущей позиции прокрутки страницы и включение/выключение видимости кнопки
  const toggleVisibility = () => {
    if (window.scrollY > 100) {
      setIsVisible(true);
    } else {
      setIsVisible(false);
    }
  };

  // Добавление слушателя события для отслеживания прокрутки
  useEffect(() => {
    window.addEventListener('scroll', toggleVisibility);
    return () => {
      window.removeEventListener('scroll', toggleVisibility);
    };
  }, []);
  
  return (
    <div>
      <div>
        {isVisible && (
          <Button 
            icon="pi pi-arrow-up"
            className="scrollToTopButton" 
            onClick={(e) => {
              e.preventDefault();
              scrollToTop();
            }}>
          </Button>
        )}
      </div>
      <header className="flex flex-row layout-header p-1 z-5 relative align-items-center justify-content-between">
        <div
          className="flex flex-row align-items-center"
          style={{ height: "100%" }}
        >
          <div className="flex flex-row">
            <h3 className="layout-header__text mx-4">
              <a href="/">thewitcher-su.ru</a>
            </h3>
          </div>
        </div>
        <div
          className={
            isActive
              ? "layout-header__hamburger active"
              : "layout-header__hamburger"
          }
          onClick={handleClick}
        >
          <span></span>
          <span></span>
          <span></span>
        </div>
      </header>
      <div className="layout-content">
        <aside
          className={isActive ? "layout__left active" : "layout__left"}
          onClick={handleClick}
        >
          <nav>
            <ul className="layout__left-menu">
              <li className="layout__left-menu__item">
                <a href="/" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Главная</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="bestiary" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">
                    Бестиарий
                  </span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="spells" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">
                    Заклинания
                  </span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="listitem" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Предметы</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="races" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Расы</span>
                </a>
              </li>
              <li className="layout__left-menu__item">
                <a href="classes" className="layout__left-menu__item-link">
                  <span className="layout__left-menu__item-text">Классы</span>
                </a>
              </li>
            </ul>
          </nav>
        </aside>
        <div className="center w-full">
          <Outlet />
        </div>
      </div>
    </div>
  );
};

export { LayoutCommon };
