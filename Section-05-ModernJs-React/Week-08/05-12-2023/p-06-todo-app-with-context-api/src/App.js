import './App.css';
import TodoWrapper from './Components/TodoWrapper';
import { v4 as idGenerate } from 'uuid';

const INITIAL_STATE = [
  { id: idGenerate(), desc: "Ayşe Nuru aramayı unutma!", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Sinemaya git, Ölümlü Dünya 2 gelmiş", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Feyyaz Yiğit'i ara", isCompleted: true, isEditing: false },
  { id: idGenerate(), desc: "Gibi 5.sezon için heyecanlan", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Javascript konferansını unutma", isCompleted: true, isEditing: false }
];

function App() {
  return (
    <>
      <TodoWrapper tasks={INITIAL_STATE} />
    </>
  );
}

export default App;
