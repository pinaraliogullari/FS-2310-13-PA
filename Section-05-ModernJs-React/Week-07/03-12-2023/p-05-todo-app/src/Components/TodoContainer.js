import React from 'react'
import Todo from './Todo'
import TodoEditForm from './TodoEditForm'
const TodoContainer = ({ todos, toggleComplete, deleteTask, editTodo, saveTodo }) => {
    return (
        <>
            <div className='TodoContainer'>
                {
                    todos.map((todo) => {
                        if (todo.isEditing) {
                            return <TodoEditForm key={todo.id} task={todo} saveTodo={saveTodo} />
                        } else {
                            return <Todo
                                key={todo.id}
                                task={todo}
                                toggleComplete={toggleComplete}
                                deleteTask={deleteTask}
                                editTodo={editTodo}
                            />
                        }
                    })
                }
            </div>
        </>
    )
}

export default TodoContainer;



// return todo.isEditing ? (<TodoEditForm />)
//     : (<Todo
//         key={todo.id}
//         task={todo}
//         toggleComplete={toggleComplete}
//         deleteTask={deleteTask}
//     />
//     )