import React from 'react';
import { useParams, useNavigate } from "react-router-dom";
import useFetch from "../infrastructure/http/useFetch";
import { sendHttpRequest } from "../infrastructure/http/httpService";
import Spinner from "./Spinner";
import PageNotFound from "./PageNotFound";
import TodoItemForm from "./TodoItemForm";

export default function EditItem() {
    const { id } = useParams();
    const navigate = useNavigate();
    const { data: todo, loading, error } = useFetch(`/todos/${id}`, 'GET');

    const handleEditForm = async (todoState) => {
        console.log(todoState);
        await sendHttpRequest('/todos', 'PUT', todoState);
        navigate('/todoList');
    };

    if (loading) return <Spinner />;
    if (!todo) return <PageNotFound />;
    if (error) throw error;

    return (
        <div className="container">
            <h1>Edit Item</h1>
            <TodoItemForm todo={todo} submitted={ handleEditForm }/>
        </div>
    );
}