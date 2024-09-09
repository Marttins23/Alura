import "./InputText.css";

const InputText = (props) => {
    return (
        <div className="input-text">
            <label htmlFor="">{props.label}</label>
            <input
                type="text"
                value={props.value}
                onChange={(event) => {props.onChange(event.target.value)}}
                placeholder={props.placeholder}
                required={props.required}
            />
        </div>
    );
};

export default InputText;