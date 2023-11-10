import { MutableRefObject } from "react"
import { ItemDTO } from "../DTO/ItemsDTO"
import { Toast } from "primereact/toast"

interface ItemRequestDTO {
    item: ItemDTO,
    toast: MutableRefObject<Toast>
}

interface ItemRequest {
    item: ItemDTO
}

export {ItemRequest, ItemRequestDTO}