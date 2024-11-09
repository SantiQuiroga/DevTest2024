import { Option } from "@/models/option.model";

export type OptionAdapter = {
    id: string,
    name: string,
    votePercentage: number

};

export function toOption(adapter: OptionAdapter): Option {
    return {
        id: adapter.id,
        name: adapter.name,
        votePercentage: adapter.votePercentage
    }
}