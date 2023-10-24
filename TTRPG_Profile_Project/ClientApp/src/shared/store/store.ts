import { makeAutoObservable } from 'mobx'
import { ILoginDTO } from '../../models/DTO/ILoginDTO';
import authService from '../services/auth.service';
import tokenService from '../services/token.service';
import { IRegisterDTO } from '../../models/DTO/IRegisterDTO';
import { Toast } from 'primereact/toast';
import { MutableRefObject } from 'react';

export default class Store {
    isAuth = false;
    isLoading = true;
    isJustRegistered = false;
    globalToast = null;

    constructor() {
        makeAutoObservable(this);
    }

    setAuth(bool: boolean) {
        this.isAuth = bool;
    }

    setLoading(bool: boolean) {
        this.isLoading = bool;
    }

    setJustRegistered(bool: boolean) {
        this.isJustRegistered = bool;
    }

    setGlobalToast(toast: MutableRefObject<Toast>) {
        this.globalToast = toast
    }

    async login({ userName, password, isRemember }: ILoginDTO) {
        const responce = await authService.login({ userName, password, isRemember });
        console.log(responce);
        tokenService.setAccessToken(responce.data.accessToken);
        tokenService.setRefreshToken(responce.data.refreshToken);
        this.setAuth(true);
    }

    async registration({ userName, password, passwordReply, firstName, middleName, lastName, companyName, birthDate,
        gender, studyGroup, educations, placeWorks, positionPracticeId, phone, email }: IRegisterDTO) {
        try {
            console.log('store registration');
            const responce = await authService.registration({
                userName, password, passwordReply, firstName, middleName, lastName, companyName, birthDate,
                gender, studyGroup, educations, placeWorks, positionPracticeId, phone, email
            });
            console.log(responce);
            tokenService.setAccessToken(responce.data.accessToken);
            tokenService.setRefreshToken(responce.data.refreshToken);
            //this.setAuth(true);
            return responce
        }
        catch (ex) {
            console.error(ex);
            return ex;
        }
    }

    async logout() {
        try {
            const responce = await authService.logout();
            console.log(responce);
            tokenService.clearTokens();
            this.setAuth(false);
        }
        catch (ex) {
            console.log(ex.responce?.data?.message);
        }
    }

    async checkAuth() {
        this.setLoading(true);
        try {
            this.setAuth(await authService.checkAuth());
        }
        catch (ex) {
            console.log(ex.responce?.data?.message);
        }
        finally {
            this.setLoading(false);
        }
    }
}