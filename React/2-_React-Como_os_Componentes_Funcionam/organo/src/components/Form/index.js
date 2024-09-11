import { useState } from "react";
import Button from "../Button";
import InputText from "../InputText";
import Select from "../Select";
import "./Form.css";
import ColorInput from "../ColorInput";

const Form = (props) => {

    const [name, setName] = useState('');
    const [role, setRole] = useState('');
    const [image, setImage] = useState('');
    const [team, setTeam] = useState('Programação');
    const [newTeamName, setNewTeamName] = useState('');
    const [newTeamColor, setNewTeamColor] = useState('#FFFFFF');

    const onHandleSubmit = (event) => {
        event.preventDefault();
        props.onHandleSubmit({
            name,
            role,
            image,
            team
        });
        setName('');
        setRole('');
        setImage('');
        setTeam('Programação');
    }

    const onHandleSubmitNewTeam = (event) => {
        event.preventDefault();
        props.onHandleSubmitNewTeam({
            name: newTeamName,
            color: newTeamColor
        });
        setNewTeamName('');
        setNewTeamColor('');
    }

    return (
        <section className="form">
            <form onSubmit={onHandleSubmit}>
                <h2>Preencha os dados para criar o card do colaborador</h2>
                <InputText
                    label="Nome"
                    value={name}
                    placeholder="Digite o seu nome"
                    required={true}
                    onChange={value => setName(value)}
                />
                <InputText
                    label="Cargo"
                    value={role}
                    placeholder="Digite o seu cargo"
                    required={true}
                    onChange={value => setRole(value)}
                />
                <InputText
                    label="Imagem"
                    value={image}
                    placeholder="Digite o endereço da imagem"
                    required={true}
                    onChange={value => setImage(value)}
                />
                <Select
                    label="Time"
                    value={team}
                    items={props.teamNames}
                    required={true}
                    onChange={value => setTeam(value)}
                />
                <Button>
                    Criar card
                </Button>
            </form>
            <form onSubmit={onHandleSubmitNewTeam}>
                <h2>Preencha os dados para criar um novo time</h2>
                <InputText
                    label="Nome"
                    value={newTeamName}
                    placeholder="Digite o nome do time"
                    required={true}
                    onChange={value => setNewTeamName(value)}
                />
                <ColorInput
                    label="Cor"
                    value={newTeamColor}
                    onChange={value => setNewTeamColor(value)}
                    insideForm
                />
                <Button>
                    Criar time
                </Button>
            </form>
        </section>
    );
}

export default Form;