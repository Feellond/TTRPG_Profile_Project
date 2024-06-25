import { OptionsParamsLoad } from "entities/Interface";
import bestiaryService from "shared/services/bestiary.service";

const SkillOptionsLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await bestiaryService.getSkills();
    if (responce && responce.data) {

      const options = responce.data.skills.map((data, index) => ({
        label: data.name,
        value: data,
      }));

      setItems(options);
    }
  } catch (error) {
    console.error("Error fetching skills:", error);
  }
};

export { SkillOptionsLoad };
