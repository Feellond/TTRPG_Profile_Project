import { MutableRefObject } from "react"
import { ItemDTO } from "../DTO/ItemsDTO"
import { Toast } from "primereact/toast"

interface ItemRequestDTO {
    id?: number | string,
    entity?: ItemDTO,
    itemType?: number,
    toast?: MutableRefObject<Toast>,
    command?: string,
    params?: any,
}

interface ItemRequest {
    item: ItemDTO
}

export {ItemRequest, ItemRequestDTO}