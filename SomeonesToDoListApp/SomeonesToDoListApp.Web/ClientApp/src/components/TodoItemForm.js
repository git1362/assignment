import React, { useState } from "react";

export default function TodoItemForm({ todo, submitted }) {
    const [todoState, setTodoState] = useState({ ...todo });

    const onSubmit = (e) => {
        e.preventDefault();
        submitted(todoState);
    }

    return (
        <form className="mt-2">
            <div className="form-group">
                <label htmlFor="title">Change Title</label>
                <input
                    type="text"
                    className="form-control"
                    placeholder="Title"
                    value={todoState.toDoItemName}
                    onChange={(e) =>
                        setTodoState({ ...todoState, toDoItemName: e.target.value })
                    }
                />
            </div>
            <button
                className="btn btn-primary mt-2"
                disabled={!todoState.toDoItemName}
                onClick={onSubmit}>
                Submit
            </button>
        </form>
    );
}