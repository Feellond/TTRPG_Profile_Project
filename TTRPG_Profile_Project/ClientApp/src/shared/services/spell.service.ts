import { API_SPELL } from "shared/api/api_const";
import $api from "shared/api/axiosInstance";
import { SpellRequestDTO } from "shared/models/Spell/Request/SpellRequestDTO";

export class SpellService {
    async getEntitys({params}: SpellRequestDTO) {
        return await $api.get(API_SPELL, {params: params});
      }
  
      async getEntity({id}: SpellRequestDTO) {
        return await $api.get(API_SPELL + "/" + String(id));
      }
  
      async createEntity({entity}: SpellRequestDTO) {
        return await $api.post(API_SPELL, entity)
      }
  
      async updateEntity({entity}: SpellRequestDTO) {
        return await $api.put(API_SPELL, entity)
      }
  
      async deleteEntity({id}: SpellRequestDTO) {
        return await $api.delete(API_SPELL + "/" + String(id));
      }
}

const spellService = new SpellService();
export default spellService;