import React, { useState } from 'react'
import TodoForm from './TodoForm';
import { v4 as uuidv4 } from 'uuid';
import Todo from './Todo';
import TodoContainer from './TodoContainer';

const TodoWrapper = () => {
    //let todos=[];
    let [todos, setTodos] = useState([]);
    //bir functionda props olarak gönderilebilir. 
    const addTodo = todo => {

        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false,
        }]);

    };


    const toggleComplete = (id) => {
        setTodos(
            todos.map((todo) => todo.id == id ? { ...todo, completed: !todo.completed } : todo)
        );
    }

    const deleteTask=(id)=> setTodos(todos.filter((todo)=>todo.id!=id));


    
    return (
        <>

            <div className='TodoWrapper'>
                <h1>FS-2310-13 Todo App</h1>
                <TodoForm addTodo={addTodo} todos={todos} />
                <TodoContainer todos={todos}toggleComplete={toggleComplete}  deleteTask={deleteTask}/>


            </div >
        </>
    )
}

export default TodoWrapper;