import { Dropdown } from "primereact/dropdown";
import { MultiSelect } from "primereact/multiselect";
import React, { FC } from "react"
import { ListInputProps } from "../models/listInputProps";

const ListInput : FC<ListInputProps> = ({
    id,
    data, 
    value, 
    onChange, 
    filter=false, 
    multiselect=false, 
    display="comma",
    placeholder="",
    onFilter = null, 
    optionLabel = null,
    className=null} ) => {  // data : Array<any> Array<namable>  

    if (multiselect)
    {
        return ( 
        <MultiSelect
            id={id}
            placeholder={placeholder}
            value={value}
            options = {data}
            onChange = {onChange}
            display={display}
            filter={filter}
            className={className}
            optionLabel = {optionLabel}
            maxSelectedLabels={3}
            emptyFilterMessage={"Ничего не найдено"}
        />)
    } 
    else 
    {
        return ( 
        <Dropdown
            id={id}
            value={value}
            placeholder={placeholder}
            options = {data}
            onChange = {onChange}
            filter={filter}
            showClear
            onFilter={onFilter}
            optionLabel = {optionLabel}
            className={className}
            emptyFilterMessage={"Ничего не найдено"}
            emptyMessage={"Ничего не найдено"}
        />)
    }
}

export { ListInput };