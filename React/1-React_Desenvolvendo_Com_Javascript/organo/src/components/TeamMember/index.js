import "./TeamMember.css";

const TeamMember = ({name, imageUrl, role, backgroundColor}) => {
    return (
        <div className="team-member">
            <div className="header" style={{ backgroundColor: backgroundColor }}>
                <img src={imageUrl} alt="team member" />
            </div>
            <div className="footer">
                <h4>{name}</h4>
                <h5>{role}</h5>
            </div>
        </div>
    );
}

export default TeamMember;