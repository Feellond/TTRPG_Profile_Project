import axios, { AxiosResponse } from "axios";
import $api from "../api/axiosInstance";
import { ILoginDTO } from "../../models/DTO/ILoginDTO";
import { TokenResponceDTO } from "../../models/responce/TokenResponceDTO";
import {
  API_LOGIN,
  API_LOGOUT,
  API_REFRESH_TOKEN,
  API_REGISTER,
  BASE_URL,
} from "../api/const";
import tokenService from "./token.service";
import { IRegisterDTO } from "../../models/DTO/IRegisterDTO";
import jwt_decode from "jwt-decode";
import { IUserInfo } from "models/responce/IUserInfo";

export class AuthService {
  getUser(): IUserInfo | null {
    try {
      let token = tokenService.getAccessToken();
      let decode = jwt_decode(token) as IUserInfo;
      return decode;
    } catch (ex) {
      console.error(ex);
      return {} as IUserInfo;
    }
  }

  async login({
    userName,
    password,
    isRemember,
  }: ILoginDTO): Promise<AxiosResponse<TokenResponceDTO>> {
    return $api.post<TokenResponceDTO>(API_LOGIN, {
      userName,
      password,
      isRemember,
    });
  }

  async logout(): Promise<void> {
    return $api.post(API_LOGOUT);
  }

  async checkAuth() {
    try {
      if (tokenService.getAccessToken()) {
        const responce = await $api.post<TokenResponceDTO>(
          `${BASE_URL}${API_REFRESH_TOKEN}`,
          {
            accessToken: tokenService.getAccessToken(),
            refreshToken: tokenService.getRefreshToken(),
          },
          { withCredentials: true }
        );

        tokenService.setAccessToken(responce.data.accessToken);
        tokenService.setRefreshToken(responce.data.refreshToken);
        return true;
      }
      return false;
    } catch (error) {
      if (error.response.status === 404) {
        setTimeout(() => {
          //history?.navigate("/error/camunda");
        }, 100);
      }
      return false;
    }
  }

  async registration({
    userName,
    password,
    passwordReply,
    firstName,
    middleName,
    lastName,
    companyName,
    birthDate,
    gender,
    studyGroup,
    educations,
    placeWorks,
    positionPracticeId,
    phone,
    email,
  }: IRegisterDTO): Promise<AxiosResponse<TokenResponceDTO>> {
    return $api.post<TokenResponceDTO>(API_REGISTER, {
      userName,
      password,
      passwordReply,
      firstName,
      middleName,
      lastName,
      companyName,
      birthDate,
      gender,
      studyGroup,
      educations,
      placeWorks,
      positionPracticeId,
      phone,
      email,
    });
  }

  async createTestUser(): Promise<void> {
    return $api.post("api/auth/createTestUser");
  }

  checkPrivilage(role: string): boolean {
    const user = this.getUser();
    return user?.role?.includes(role) ?? false;
  }
}

const authService = new AuthService();
export default authService;
