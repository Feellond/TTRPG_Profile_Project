import { API_EFFECT, API_SOURCE } from "shared/api/api_const";
import $api from "shared/api/axiosInstance";

export class GeneralService {
    async sourceListLoad() {
        return await $api.get(API_SOURCE);
    }

    async effectListLoad() {
        return await $api.get(API_EFFECT);
    }
}

const generalService = new GeneralService();
export default generalService;