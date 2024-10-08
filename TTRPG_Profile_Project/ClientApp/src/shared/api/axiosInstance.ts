import axios from "axios";
import { API_REFRESH_TOKEN, BASE_URL } from "./api_const";
import tokenService, {
  ACCESS_TOKEN_ITEM,
  REFREST_TOKEN_ITEM,
} from "shared/services/token.service";
import { useRef } from "react";
import { Toast } from "primereact/toast";

const $api = axios.create({
  withCredentials: true,
  baseURL: BASE_URL,
});

$api.interceptors.request.use((config) => {
  config.headers.Authorization = `Bearer ${localStorage.getItem("token")}`;
  return config;
});

$api.interceptors.response.use(
  (config) => {
    return config;
  },
  async (error) => {
    const toast = useRef<Toast>(null);
    const originalRequest = error.config;
    if (
      error.response.status === 401 &&
      error.config &&
      !error.config._isRetry
    ) {
      try {
        originalRequest._isRetry = true;
        const resp = await axios.post(
          `${BASE_URL}${API_REFRESH_TOKEN}`,
          {
            accessToken: localStorage.getItem(ACCESS_TOKEN_ITEM),
            refreshToken: localStorage.getItem(REFREST_TOKEN_ITEM),
          },
          { withCredentials: true }
        );
        tokenService.setAccessToken(resp.data.accessToken);
        tokenService.setRefreshToken(resp.data.refreshToken);

        return await $api.request(originalRequest);
      } catch (ex) {
        toast.current.show({
          severity: "error",
          summary: "Не авторизован",
          detail: ex.message,
        }); // Отображаем сообщение об ошибке в Toast
      }
    }
    else {
        toast.current.show({
            severity: "error",
            summary: "Произошла ошибка",
            detail: error.message,
          }); // Отображаем сообщение об ошибке в Toast
    }
    throw error;
  }
);

export default $api;
