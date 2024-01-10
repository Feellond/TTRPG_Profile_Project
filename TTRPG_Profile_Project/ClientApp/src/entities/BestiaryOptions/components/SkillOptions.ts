import { OptionsParamsLoad } from "entities/Interface";
import bestiaryService from "shared/services/bestiary.service";

const SkillOptionsLoad = async ({ setItems }: OptionsParamsLoad) => {
  try {
    let responce = await bestiaryService.getSkills();
    if (responce && responce.data) {
        console.log("Skill responce data:");
        console.log(responce.data);

      const options = responce.data.map((data, index) => ({
        label: data.name,
        value: data,
      }));

      console.log("Skill options:");
      console.log(options);

      setItems(options);
    }
  } catch (error) {
    console.error("Error fetching skills:", error);
  }
};

export { SkillOptionsLoad };
