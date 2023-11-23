import { EntityBase, EntityDescriptionBase } from "shared/models/Base";

interface Stat extends EntityDescriptionBase {}

interface Skill extends EntityDescriptionBase {
  isDifficult: boolean;
  isClassSkill: boolean;
  statId: number;
  stat: Stat;
}

interface CreatureReward extends EntityBase {
  itemBaseId: number;
  creatureId: number;
  amount: string | null;
}

export { Stat, Skill, CreatureReward };
