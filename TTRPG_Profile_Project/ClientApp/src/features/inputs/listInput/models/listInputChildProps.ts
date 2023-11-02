export interface ListInputChildProps {
    id: string,
    value: any[] | any
    onChange: (e: any) => void;
    filter?: boolean,
    multiselect?: boolean,
    display?: "chip" | "comma",
    className?: string
}