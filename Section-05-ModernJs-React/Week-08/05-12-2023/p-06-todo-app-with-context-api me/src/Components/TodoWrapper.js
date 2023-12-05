import React, { useState } from 'react';
import { TodoContext } from '../Contexts/TodoContext';
import TodoAddForm from './TodoAddForm';
import TodoContainer from './TodoContainer';
import TodoFilter from './TodoFilter';
import { v4 as idGenerate } from 'uuid';

const TodoWrapper = ({ tasks }) => {
    const [taskList, setTaskList] = useState(tasks);

    const addTask = _desc => {
        setTaskList(
            [...taskList, {
                id: idGenerate(),
                desc: _desc,
                isCompleted: false,
                isEditing: false
            }]
        );
        console.log(taskList);
    }

    const toggleComplete = id => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isCompleted: !task.isCompleted } : task)
        );
    }
    const all=()=>{
        setTaskList(tasks);
    }
    const pending = (taskId) => {
        setTaskList(
            taskList.map((task) => {
                // Eğer task'ın id'si, bekleyen görevin id'sine eşitse durumu değiştir
                if (task.id === taskId) {
                    return { ...task, isCompleted: !task.isCompleted };
                }
                // Eğer id eşleşmiyorsa task'ı olduğu gibi bırak
                return task;
            })
        );
    };

    const deleteTask = id => {
        setTaskList(
            taskList.filter(task => task.id != id)
        );
    }

    const clearAll = () => {
        setTaskList([]);
    }


    const toggleEditing = id => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isEditing: true } : { ...task, isEditing: false })
        );
    }

    const updateTask = (id, _desc) => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, desc: _desc, isEditing: !task.isEditing } : task)
        );
    }


    return (
        <TodoContext.Provider value={{ taskList, addTask, toggleComplete, deleteTask, toggleEditing, updateTask, clearAll,all,pending }} >
            <div className='container w-50 p-5'>
                <TodoAddForm />
                <TodoFilter />
                <TodoContainer />
            </div>
        </TodoContext.Provider>
    )
}

export default TodoWrapper;