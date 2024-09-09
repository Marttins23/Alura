import TeamMember from "../TeamMember";
import "./Team.css";

const Team = (props) => {

    const sectionCss = { backgroundColor: props.secondaryColor };
    const h3Css = { borderColor: props.primaryColor };

    return (
        (props.members.length > 0) && <section className="team" style={sectionCss}>
            <h3 style={h3Css}>{props.name}</h3>
            <div className="team-members">
                {
                    props.members.map(teamMember =>
                        <TeamMember
                            key={teamMember.name+teamMember.role+Math.floor(Math.random() * 1000)}
                            name={teamMember.name}
                            imageUrl={teamMember.image}
                            role={teamMember.role}
                            backgroundColor={props.primaryColor}
                        />
                    )
                }
            </div>
        </section>
    );
}

export default Team;