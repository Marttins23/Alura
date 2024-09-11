import { useState } from "react";
import { v4 as uuidv4 } from 'uuid';
import { getTeams } from '../../services/Teams/TeamsService.js';
import { getMembers } from '../../services/Members/MembersService.js';

const useTeamMembers = () => {
    const teamsData = getTeams();
    const [teams, setTeams] = useState(teamsData);
    const [members, setMembers] = useState(getMembers(teamsData));

    const onHandleSubmit = (member) => {
        setMembers([...members, member]);
    }

    const onHandleSubmitNewTeam = (newTeam) => {
        setTeams( [ ...teams, { ...newTeam, id: uuidv4() } ] )
    }

    const onDeleteTeamMember = (id) => {
        setMembers(members.filter((member) => member.id !== id));
    }

    const onChangeColor = (color, teamId) => {
        setTeams(teams.map(team => {
            if (team.id === teamId) {
                team.color = color;
            }
            return team;
        }));
    }

    const onResolveFavorite = (id) => {
        setMembers(members.map(member => {
            if (member.id === id) {
                member.favorite = !member.favorite;
            }
            return member;
        }));
    }

    return {
        teams,
        setTeams,
        members,
        setMembers,
        onHandleSubmit,
        onHandleSubmitNewTeam,
        onDeleteTeamMember,
        onChangeColor,
        onResolveFavorite
    };
}

export default useTeamMembers;