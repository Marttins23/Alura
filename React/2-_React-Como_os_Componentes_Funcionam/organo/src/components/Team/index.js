import ColorInput from "../ColorInput";
import TeamMember from "../TeamMember";
import hexToRgba from 'hex-to-rgba';
import { useState } from "react";
import "./Team.css";

const Team = ({team, members, onChangeColor, onDeleteTeamMember, onResolveFavorite}) => {

    const sectionCss = { backgroundColor: hexToRgba(team.color, 0.4) };
    const h3Css = { borderColor: team.color };
    const [teamColor, setTeamColor] = useState(team.color);

    return (
        (members.length > 0) && <section className="team" style={sectionCss}>
            <ColorInput
                value={teamColor}
                onChange={value => {
                    setTeamColor(value)
                    onChangeColor(value, team.id);
                }}
            />
            <h3 style={h3Css}>{team.name}</h3>
            <div className="team-members">
                {
                    members.map(teamMember =>
                        <TeamMember
                            key={teamMember.name+teamMember.role+Math.floor(Math.random() * 1000)}
                            teamMember={teamMember}
                            backgroundColor={team.color}
                            onDeleteTeamMember={onDeleteTeamMember}
                            onResolveFavorite={onResolveFavorite}
                        />
                    )
                }
            </div>
        </section>
    );
}

export default Team;