import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons';
import React from 'react';

const Todo = ({ task, toggleComplete, deleteTask }) => {
    return (
        <>
            <div className='Todo'>

                <p onClick={()=>{toggleComplete(task.id)}} className={ task.completed? "Completed TodoTask" :"TodoTask"} >
                    {task.desc}
                </p>
                <div className='TodoButtons'>
                    <FontAwesomeIcon icon={faPenToSquare} />
                    <FontAwesomeIcon icon={faTrash}  onClick={()=>deleteTask(task.id)}/>
                </div>


            </div>
        </>
    )
}

export default Todo;
