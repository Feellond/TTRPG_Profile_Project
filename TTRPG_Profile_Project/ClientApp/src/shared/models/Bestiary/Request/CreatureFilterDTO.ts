import { IRace } from "../DTO/BestiaryDTO";

export interface CreatureFilterDTO {
    name: string | null,
    complexity: number | null,
    race: IRace | null,
}