import React, { useState } from 'react';
import { useParams, useNavigate } from "react-router-dom";
import useFetch from "../infrastructure/http/useFetch";
import { sendHttpRequest } from "../infrastructure/http/httpService";
import Spinner from "./Spinner";
import PageNotFound from "./PageNotFound";
import TodoItemForm from "./TodoItemForm";
import ValidationSummary from "./ValidationSummary";

export default function EditItem() {
    const [validations, setValidations] = useState([]);
    const { id } = useParams();
    const navigate = useNavigate();
    const { data: todo, loading, error } = useFetch(`/todos/${id}`, 'GET');

    const handleEditForm = async (todoState) => {
        const editTodoItem = { id: todoState.id, toDoItem: todoState.toDoItemName };
        try {
            await sendHttpRequest('/todos', 'PUT', editTodoItem);
            navigate('/todoList');
        } catch (errors) {
            if (Array.isArray(errors)) {
                setValidations([...errors]);
            }
        }
    };

    if (loading) return <Spinner />;
    if (!todo) return <PageNotFound />;
    if (error) throw error;

    return (
        <div className="container">
            <h1>Edit Item</h1>

            {validations.length > 0 && <ValidationSummary validations={validations} />}

            <TodoItemForm todo={todo} submitted={handleEditForm} />
        </div>
    );
}