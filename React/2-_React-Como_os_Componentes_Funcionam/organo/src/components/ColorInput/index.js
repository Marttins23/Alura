import "./ColorInput.css";

const ColorInput = ({value, onChange, insideForm, label}) => {

    let containerClass = "color-input-container ";
    containerClass += insideForm ? 'inside-form' : '';

    return (
        <div className={containerClass}>
            {
                label !== '' && label !== undefined ? <label>{label}</label> : ''
            }
            <input
                type="color"
                value={value}
                onChange={event => onChange(event.target.value)}
            />
        </div>
    );
}

export default ColorInput;