import React from "react";

export default function Spinner() {
    return (
        <div className="spinner-border text-primary" role="status">
            <div className="sr-only">Loading...</div>
        </div>
    );
}