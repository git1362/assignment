import React, { useState } from 'react';
import { useNavigate } from "react-router-dom";
import { sendHttpRequest } from "../infrastructure/http/httpService";
import TodoItemForm from "./TodoItemForm";
import Spinner from "./Spinner";
import ValidationSummary from "./ValidationSummary";
import { STATUS } from "../common/enums";

export default function CreateItem() {
    const [validations, setValidations] = useState([]);
    const [status, setStatus] = useState(STATUS.IDLE);
    const navigate = useNavigate();

    const handleCreateForm = async (todoState) => {
        const newTodo = { toDoItem: todoState.toDoItemName };
        try {
            setStatus(STATUS.SUBMITTING);
            await sendHttpRequest('/todos', 'POST', newTodo);
            setStatus(STATUS.COMPLETED);
            navigate('/todoList');
        } catch (errors) {
            setStatus(STATUS.COMPLETED);
            if (Array.isArray(errors)) {
                setValidations([...errors]);
            }
        }
    };

    if (status == STATUS.SUBMITTING) return <Spinner />;

    return (
        <div className="container">
            <h1>Create Item</h1>

            {validations.length > 0 && <ValidationSummary validations={validations } />}

             <TodoItemForm submitted={handleCreateForm} />
        </div>
    );
}