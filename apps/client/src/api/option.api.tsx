import { Option } from "@/models/option.model"
import { OptionAdapter, toOption } from "@/adapter/option.adapter"
import { API_URL } from "./api.constants"

export async function getAllOptions(): Promise<Option[]> {
    const response = await fetch($"{API_URL}/options");
    const data = (await response.json()) as OptionAdapter[];
    const options = data.map(ma => toOption(ma));

    return options;
}
