import { MutableRefObject } from 'react';
import { ICreature } from './../DTO/BestiaryDTO';
import { Toast } from 'primereact/toast';

export interface CreatureRequestDTO {
    id?: number | string,
    entity?: ICreature,
    toast?: MutableRefObject<Toast>,
    command?: string,
    params?: any,
}

export interface CreatureRequest {
    entity: ICreature
}