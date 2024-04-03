import { Toast } from "primereact/toast";
import { MutableRefObject } from "react";
import { ISpell } from "../DTO/SpellDTO";

export interface SpellRequestDTO {
    id?: number | string,
    entity?: ISpell,
    itemType?: number,
    toast?: MutableRefObject<Toast>,
    command?: string,
    params?: any,
}