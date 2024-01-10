import {
  API_ALCHEMICALITEM,
  API_ARMOR,
  API_BASEITEM,
  API_BLUEPRINT,
  API_COMPONENT,
  API_FORMULA,
  API_ITEM,
  API_TOOL,
  API_WEAPON,
} from "shared/api/api_const";
import $api from "shared/api/axiosInstance";
import { CommandEnum } from "shared/enums/GeneralEnums";
import { ItemRequestDTO } from "shared/models";

export class ItemService {
  async getItems({ itemType, toast, params }: ItemRequestDTO) {
    return await this.execute({
      itemType: itemType,
      toast: toast,
      command: CommandEnum.GetList,
      params: params,
    });
  }

  async getItem({ itemType, toast }: ItemRequestDTO) {
    return await this.execute({
      itemType: itemType,
      toast: toast,
      command: CommandEnum.Get,
    });
  }

  async createItem({ item, toast }: ItemRequestDTO) {
    return await this.execute({
      item: item,
      itemType: item.itemType,
      toast: toast,
      command: CommandEnum.Create,
    });
  }

  async updateItem({ item, toast }: ItemRequestDTO) {
    return await this.execute({
      item: item,
      itemType: item.itemType,
      toast: toast,
      command: CommandEnum.Update,
    });
  }

  async deleteItem({ id, itemType, toast }: ItemRequestDTO) {
    return await this.execute({
      itemType: itemType,
      toast: toast,
      id: id,
      command: CommandEnum.Delete,
    });
  }

  async execute({
    item,
    itemType,
    toast,
    id,
    command,
    params,
  }: ItemRequestDTO) {
    let apiString = "";

    switch (itemType) {
      case 1:
        apiString = API_BASEITEM;
        break;
      case 2:
        apiString = API_TOOL;
        break;
      case 3:
        apiString = API_ALCHEMICALITEM;
        break;
      case 4:
        apiString = API_ARMOR;
        break;
      case 5:
        apiString = API_WEAPON;
        break;
      case 6:
        apiString = API_FORMULA;
        break;
      case 7:
        apiString = API_BLUEPRINT;
        break;
      case 8:
        apiString = API_COMPONENT;
        break;
      case 9:
        apiString = API_ITEM;
        break;
    }

    if (command === CommandEnum.GetList) {
      return await $api.get(apiString, { params: params });
    } else if (command === CommandEnum.Get) {
      return await $api.get(apiString + "/" + String(id));
    } else if (command === CommandEnum.Create) {
      return await $api.post(apiString, {
        weaponRequest: item,
      });
    } else if (command === CommandEnum.Update) {
      return await $api.put(apiString, {
        weaponRequest: item,
      });
    } else if (command === CommandEnum.Delete) {
      return await $api.delete(apiString + "/" + String(id));
    }

    toast.current.show({
      severity: "error",
      summary: "Произошла ошибка",
      detail: "Запрос не выполнен",
    }); // Отображаем сообщение об ошибке в Toast
    return false;
  }
}

const itemService = new ItemService();
export default itemService;
