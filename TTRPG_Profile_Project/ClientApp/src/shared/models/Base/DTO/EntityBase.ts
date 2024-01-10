interface EntityBase {
  id: number;
}

interface EntityDescriptionBase extends EntityBase {
  name: string | null;
  description: string | null;
  source: string | null;
}

interface EntityItemBase extends EntityDescriptionBase {
  availabilityType: number | null;
  weight: number | null;
  price: number | null;
}
export { EntityBase, EntityDescriptionBase, EntityItemBase };
