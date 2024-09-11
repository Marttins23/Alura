import Banner from './components/Banner';
import Form from './components/Form';
import Team from "./components/Team";
import Footer from "./components/Footer";
import useTeamMembers from './hooks/TeamMembers/useTeamMebers';

function App() {
  
  const {
    teams,
    members,
    onHandleSubmit,
    onHandleSubmitNewTeam,
    onDeleteTeamMember,
    onChangeColor,
    onResolveFavorite
  } = useTeamMembers();

  return (
    <div className="App">
      <Banner />
      <Form
        teamNames={teams.map(team => team.name)}
        onHandleSubmit={member => onHandleSubmit(member)}
        onHandleSubmitNewTeam={newTeam => onHandleSubmitNewTeam(newTeam)}
      />
      { 
        teams.map(team =>
          <Team
            key={team.id}
            team={team}
            members={members.filter(member => member.team === team.name)}
            onDeleteTeamMember={onDeleteTeamMember}
            onChangeColor={onChangeColor}
            onResolveFavorite={onResolveFavorite}
          />
        )
      }
      <Footer />
    </div>
  );
}

export default App;
