import { API_EFFECT, API_IMAGEDELETE, API_IMAGEGET, API_IMAGELOAD, API_SOURCE } from "shared/api/api_const";
import $api from "shared/api/axiosInstance";

export class GeneralService {
  async sourceListLoad() {
    return await $api.get(API_SOURCE);
  }

  async effectListLoad() {
    return await $api.get(API_EFFECT);
  }

  async getImage(filename: string) {
    return await $api.post(API_IMAGEGET, filename);
  }

  async loadImage(formdata) {
    return await $api.post(API_IMAGELOAD, formdata, {
      headers: {
        "Content-Type": "multipart/form-data",
      },
    });
  }

  async deleteImage(filename: string, foldername: string) {
    return await $api.post(
      API_IMAGEDELETE,
      { filename: filename, foldername: foldername },
      {
        headers: {
          "Content-Type": "application/json",
        },
      }
    );
  }
}

const generalService = new GeneralService();
export default generalService;
