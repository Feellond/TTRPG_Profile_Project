import { API_CLASS, API_CREATURE, API_RACE, API_SKILL } from "shared/api/api_const";
import $api from "shared/api/axiosInstance";
import { CreatureRequestDTO } from "shared/models";

export class BestiaryService {
  async getClasses({ params }) {
    return await $api.get(API_CLASS, { params: params });
  }

  async getRaces({ params }) {
    return await $api.get(API_RACE, { params: params });
  }

  async getSkills() {
    return await $api.get(API_SKILL);
  }
  async getEntitys({ params }: CreatureRequestDTO) {
    return await $api.get(API_CREATURE, { params: params });
  }

  async getEntity({ id }: CreatureRequestDTO) {
    return await $api.get(API_CREATURE + "/" + String(id));
  }

  async createEntity({ entity }: CreatureRequestDTO) {
    console.log(entity);
    //return await $api.post(API_CREATURE, {request: entity});
    return await $api.post(API_CREATURE, entity);
  }

  async updateEntity({ entity }: CreatureRequestDTO) {
    return await $api.put(API_CREATURE, entity);
    // return await $api.put(API_CREATURE, entity, {
    //   headers: {
    //     "Content-Type": "multipart/form-data",
    //   },
    // });
  }

  async deleteEntity({ id }: CreatureRequestDTO) {
    return await $api.delete(API_CREATURE + "/" + String(id));
  }
}

const bestiaryService = new BestiaryService();
export default bestiaryService;