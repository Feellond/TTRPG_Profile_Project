import { AxiosResponse } from "axios";
import $api from "../api/axiosInstance";
import { API_LOGIN, API_LOGOUT, API_REFRESH_TOKEN, BASE_URL } from "../api/api_const";
import tokenService from "./token.service";
import {jwtDecode} from "jwt-decode";
import { ILoginDTO, ITokenResponceDTO, IUserInfo } from "shared/models";

export class AuthService {
  getUser(): IUserInfo | null {
    try {
      let token = tokenService.getAccessToken();
      let decode = jwtDecode(token) as IUserInfo;
      return decode;
    } catch (ex) {
      console.error(ex);
      return {} as IUserInfo;
    }
  }

  async login({
    login,
    password,
  }: ILoginDTO): Promise<AxiosResponse<ITokenResponceDTO>> {
    return $api.post<ITokenResponceDTO>(API_LOGIN, {
      login,
      password,
    });
  }

  async logout(): Promise<void> {
    return $api.post(API_LOGOUT);
  }

  async checkAuth() {
    try {
      if (tokenService.getAccessToken()) {
        const responce = await $api.post<ITokenResponceDTO>(
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
      return false;
    }
  }

  // async registration({
  //   userName,
  //   password,
  //   passwordReply,
  //   firstName,
  //   middleName,
  //   lastName,
  //   companyName,
  //   birthDate,
  //   gender,
  //   studyGroup,
  //   educations,
  //   placeWorks,
  //   positionPracticeId,
  //   phone,
  //   email,
  // }: IRegisterDTO): Promise<AxiosResponse<TokenResponceDTO>> {
  //   return $api.post<TokenResponceDTO>(API_REGISTER, {
  //     userName,
  //     password,
  //     passwordReply,
  //     firstName,
  //     middleName,
  //     lastName,
  //     companyName,
  //     birthDate,
  //     gender,
  //     studyGroup,
  //     educations,
  //     placeWorks,
  //     positionPracticeId,
  //     phone,
  //     email,
  //   });
  // }

  // async createTestUser(): Promise<void> {
  //   return $api.post("api/auth/createTestUser");
  // }

  checkPrivilage(role: string): boolean {
    const user = this.getUser();
    return user?.role?.includes(role) ?? false;
  }
}

const authService = new AuthService();
export default authService;
