import $api from "shared/api/axiosInstance";
import { IListOptions, IListOptionsString } from "../models/listOptions";

const fetchItems = async (path: string) => {
    return await $api.get<IListOptions[]>(path);
}

const fetchItemsString = async (path: string) => {
    return await $api.get<IListOptionsString[]>(path);
}

export {fetchItems}