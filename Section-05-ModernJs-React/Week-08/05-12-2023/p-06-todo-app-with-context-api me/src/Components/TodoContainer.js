import React, { useContext } from 'react';
import { TodoContext } from '../Contexts/TodoContext';
import Todo from './Todo';
import TodoEditForm from './TodoEditForm';
const TodoContainer = () => {
    const context = useContext(TodoContext);
    return (
        <>
            <ul className='list-group'>
                {
                    context.taskList.map(task => {
                        if (task.isEditing) {
                            return <TodoEditForm />
                        } else {
                            return <Todo key={task.id} task={task} />

                        }
                    })
                }
            </ul>
        </>
    )
}

export default TodoContainer;