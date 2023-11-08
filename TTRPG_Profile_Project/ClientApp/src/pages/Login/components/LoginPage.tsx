import { Context } from "index";
import React, { useContext } from "react";
import { AuthorizationForm } from "widgets/Login";

const LoginPage = () => {
  const { store } = useContext(Context);

  return (
    <div>
      <AuthorizationForm store={store} />
    </div>
  );
};

export { LoginPage };
