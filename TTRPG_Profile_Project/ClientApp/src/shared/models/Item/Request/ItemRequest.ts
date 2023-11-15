import { MutableRefObject } from "react"
import { ItemDTO } from "../DTO/ItemsDTO"
import { Toast } from "primereact/toast"

interface ItemRequestDTO {
    id?: number | string,
    item?: ItemDTO,
    itemType?: number,
    toast?: MutableRefObject<Toast>,
    command?: string,
}

interface ItemRequest {
    item: ItemDTO
}

export {ItemRequest, ItemRequestDTO}