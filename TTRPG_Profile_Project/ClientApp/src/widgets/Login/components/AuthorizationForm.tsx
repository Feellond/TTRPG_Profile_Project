import { Button } from "primereact/button";
import { Password } from "primereact/password";
import { InputText } from "primereact/inputtext";
import { Toast } from "primereact/toast";
import React, { useRef, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { classNames } from "primereact/utils";
import Store from "shared/store/store";
import { ILoginDTO } from "shared/models";

interface AuthorizationFormProps {
    store?: Store,
}

const AuthorizationForm = ({store} : AuthorizationFormProps) => {
  const toast = useRef<Toast>(null);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const {
    register,
    setValue,
    getValues,
    control,
    formState: { errors },
    handleSubmit,
  } = useForm();

  const onSubmit = async (data) => {
    console.log(data);
    setIsLoading(true);

    let loginData: ILoginDTO = {
      userName: String(data.username),
      password: String(data.password),
    };

    try {
      await store.login(loginData);
    } catch (error) {
      console.log(error);
    }

    if (store.isAuth) {
      const url = `/`;
      window.open(url, "_blank");
    } else toastShow("Ошибка", "Не правильный логин или пароль");

    setIsLoading(false);
  };

  const toastShow = (title: string, text: string) => {
    toast.current?.show({
      severity: "error",
      summary: title,
      detail: text,
      life: 5000,
    });
  };

  const getFormErrorMessage = (name) => {
    return errors[name] ? (
      <small className="p-error">{(errors as any)[name].message}</small>
    ) : (
      <small className="p-error">&nbsp;</small>
    );
  };

  return (
    <div className="w-full" style={{ marginTop: "-20px" }}>
      <div className="card block bg-bluegray-50">
        <div className="text-center">
          <h2>Авторизация</h2>
        </div>
        <form>
          <Controller
            name="username"
            control={control}
            rules={{ required: "Заполните обязательное поле" }}
            render={({ field, fieldState }) => (
              <>
                <div className="p-inputgroup">
                  <span className="p-inputgroup-addon">
                    <i className="pi pi-user"></i>
                  </span>
                  <InputText
                    id={field.name}
                    value={field.value}
                    className={classNames({ "p-invalid": fieldState.error })}
                    placeholder="Логин"
                    onChange={(e) => field.onChange(e.target.value)}
                  />
                </div>
                {getFormErrorMessage(field.name)}
              </>
            )}
          />
          <Controller
            name="password"
            control={control}
            rules={{ required: "Заполните обязательное поле" }}
            render={({ field, fieldState }) => (
              <>
                <div className="p-inputgroup">
                  <span className="p-inputgroup-addon">
                    <i className="pi pi-lock"></i>
                  </span>
                  <Password
                    id={field.name}
                    value={field.value}
                    {...field}
                    inputRef={field.ref}
                    className={classNames({ "p-invalid": fieldState.error })}
                    placeholder="Пароль"
                    feedback={false}
                  />
                </div>
                {getFormErrorMessage(field.name)}
              </>
            )}
          />
          <div className="d-grid gap-2">
            <Button
              loading={isLoading}
              onClick={handleSubmit(onSubmit)}
              label="Авторизация"
            />
          </div>
        </form>
      </div>
    </div>
  );
};

export { AuthorizationForm };
