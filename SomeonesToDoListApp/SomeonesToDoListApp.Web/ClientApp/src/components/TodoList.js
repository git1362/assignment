import React from 'react';
import useFetch from "../infrastructure/http/useFetch";
import Spinner from "./Spinner";
import PageNotFound from "./PageNotFound";
import TodoItem from "./TodoItem";
import { Link } from "react-router-dom";

export default function TodoList() {
    const { data: todos, loading, error } = useFetch('/todos');
    if (loading) return <Spinner />;
    if (!todos || todos.length === 0) return <PageNotFound />;
    if (error) throw error;

    return (
        <div className="container">
            <p>Todo List</p>
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Item Name</th>
                        <th scope="col">Actions </th>
                    </tr>
                </thead>
                <tbody>
                    {todos.map((todo, index) => (
                        <TodoItem key={index} {...todo} />
                    ))}
                </tbody>
            </table>

            <div>
                <Link to={'/createItem'}>
                    <span>Create New Todo Item</span>
                </Link>
            </div>
        </div>
    );
}