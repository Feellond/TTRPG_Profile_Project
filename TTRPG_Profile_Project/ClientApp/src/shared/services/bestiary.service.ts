import { API_CREATURE, API_SKILL } from "shared/api/api_const";
import $api from "shared/api/axiosInstance";
import { CreatureRequestDTO } from "shared/models";

export class BestiaryService {
    async getSkills() {
      return await $api.get(API_SKILL);
    }
    async getEntitys({params}: CreatureRequestDTO) {
      return await $api.get(API_CREATURE, {params: params});
    }

    async getEntity({id}: CreatureRequestDTO) {
      return await $api.get(API_CREATURE + "/" + String(id));
    }

    async createEntity({entity}: CreatureRequestDTO) {
      return await $api.post(API_CREATURE, entity)
    }

    async updateEntity({entity}: CreatureRequestDTO) {
      return await $api.put(API_CREATURE, entity)
    }

    async deleteEntity({id}: CreatureRequestDTO) {
      return await $api.delete(API_CREATURE + "/" + String(id));
    }
}

const bestiaryService = new BestiaryService();
export default bestiaryService;