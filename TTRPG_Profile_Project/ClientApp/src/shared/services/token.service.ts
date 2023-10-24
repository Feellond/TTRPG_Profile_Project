export const ACCESS_TOKEN_ITEM = "token";
export const REFREST_TOKEN_ITEM = "refreshToken";

export class TokenService {
    getRefreshToken() {
        return localStorage.getItem(REFREST_TOKEN_ITEM);
    }

    setRefreshToken(refreshToken: string) {
        localStorage.setItem(REFREST_TOKEN_ITEM, refreshToken);
    }

    getAccessToken() {
        return localStorage.getItem(ACCESS_TOKEN_ITEM);
    }

    setAccessToken(accessToken: string) {
        localStorage.setItem(ACCESS_TOKEN_ITEM, accessToken);
    }

    clearTokens(){
        localStorage.removeItem(ACCESS_TOKEN_ITEM);
        localStorage.removeItem(REFREST_TOKEN_ITEM);
    }
}

export default new TokenService();