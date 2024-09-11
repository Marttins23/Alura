import "./Select.css";

const Select = (props) => {
    return (
        <div className="select">
            <label htmlFor="">{props.label}</label>
            <select name={props.name} value={props.value} onChange={(e) => props.onChange(e.target.value)}>
                {props.items.map((item) => {
                    return <option key={item}>{item}</option>
                })}
            </select>
        </div>
    );
}

export default Select;