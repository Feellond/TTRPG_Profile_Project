import { IRace } from "../DTO/BestiaryDTO";

export interface CreatureFilterDTO {
    name: string,
    complexity: number,
    race: IRace,
}