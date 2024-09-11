import { v4 as uuidv4 } from 'uuid';

export const getTeams = () => {
    return [
        {
          id: uuidv4(),
          name: 'Programação',
          color: '#57C278'
        },
        {
          id: uuidv4(),
          name: 'Front-End',
          color: '#82CFFA'
        },
        {
          id: uuidv4(),
          name: 'Data Science',
          color: '#A6D157'
        },
        {
          id: uuidv4(),
          name: 'Devops',
          color: '#E06B69'
        },
        {
          id: uuidv4(),
          name: 'UX e Design',
          color: '#D86EBF'
        },
        {
          id: uuidv4(),
          name: 'Mobile',
          color: '#FEBA05'
        },
        {
          id: uuidv4(),
          name: 'Inovação e Gestão',
          color: '#FF8A29'
        }
    ];
}