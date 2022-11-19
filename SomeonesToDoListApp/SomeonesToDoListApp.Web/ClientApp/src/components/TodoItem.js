import React from 'react';
import { Link } from "react-router-dom";

export default function TodoItem({ id, toDoItemName }) {
    return (
        <tr key={id}>
            <td>{ id }</td>
            <td>{toDoItemName}</td>
            <td>
                <Link to={`/todos/${id}`}>
                    <span>Edit</span>
                </Link>
            </td>
        </tr>
    );
}