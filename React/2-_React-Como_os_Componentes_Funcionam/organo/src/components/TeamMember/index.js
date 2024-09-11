import "./TeamMember.css";
import { FaWindowClose, FaRegHeart, FaHeart } from "react-icons/fa";

const TeamMember = ({teamMember, backgroundColor, onDeleteTeamMember, onResolveFavorite}) => {

    const onFavorite = () => {
        onResolveFavorite(teamMember.id);
    }

    const favoriteProps = {
        onClick : onFavorite
    }

    return (
        <div className="team-member">
            <div className="header" style={{ backgroundColor: backgroundColor }}>
                <div className="delete-icon-container">
                    <FaWindowClose
                        className="delete-icon"
                        size={24}
                        color="white"
                        onClick={() => onDeleteTeamMember(teamMember.id)}
                    />
                </div>
                <img src={teamMember.image} alt="team member" />
            </div>
            <div className="footer">
                <h4>{teamMember.name}</h4>
                <h5>{teamMember.role}</h5>
                <div className="favorite">
                    {
                        teamMember.favorite
                            ? <FaHeart {...favoriteProps} color="red"/>
                            : <FaRegHeart {...favoriteProps} color="black"/>
                    }
                </div>
            </div>
        </div>
    );
}

export default TeamMember;