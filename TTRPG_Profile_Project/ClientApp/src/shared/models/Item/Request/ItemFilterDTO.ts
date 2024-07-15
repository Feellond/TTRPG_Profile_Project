interface ItemFilterDTO {
    name: string | null,
    itemType: number | null,
    equipmentType: number | null,   //
    type: number | null,
    itemAvailabilityType: number | null,

    complexityDesc: number | null,
    priceDesc: number | null,

    componentIsAlchemical: boolean | null,
    substanceType: number | null,
    itemOriginType: number | null,
    stealthType: number | null,
    whereToFind: string | null,
    priceRange: number[] | null,
}

export  {ItemFilterDTO}