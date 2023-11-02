export interface ListInputProps {
    id: string,
    data: any[],
    value: any[] | any
    onChange: (e: any) => void;
    filter?: boolean,
    multiselect?: boolean,
    display?: "chip" | "comma",
    placeholder: string
    className?: string,
    optionLabel? : string,
    onFilter?: (e: any) => void,
}