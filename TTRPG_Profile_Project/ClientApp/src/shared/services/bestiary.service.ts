import { API_SKILL } from "shared/api/api_const";
import $api from "shared/api/axiosInstance";

export class BestiaryService {
    async getSkills() {
        return await $api.get(API_SKILL);
      }
}

const bestiaryService = new BestiaryService();
export default bestiaryService;