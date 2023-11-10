import $api from "shared/api/axiosInstance";
import { ItemRequestDTO } from "shared/models";

export class ItemService {
  async createItem({ item, toast }: ItemRequestDTO): Promise<boolean> {
    switch (item.itemType) {
      case 1:
        //content = BaseItem();
        break;
      case 2:
        //content = ToolItem();
        break;
      case 3:
        //content = AlchemicalItem();
        break;
      case 4:
        //content = ArmorItem();
        break;
      case 5:
        //content = WeaponItem();
        break;
      case 6:
        //content = FormulaItem();
        break;
      case 7:
        //content = BlueprintItem();
        break;
      case 8:
        //content = ComponentItem();
        break;
      default:
        toast.current.show({
          severity: "error",
          summary: "Произошла ошибка",
          detail: "Выберите правильный тип предмета",
        }); // Отображаем сообщение об ошибке в Toast
        return false;
    }
  }
}

const itemService = new ItemService();
export default itemService;
