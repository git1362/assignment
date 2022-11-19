import React from 'react';


export default function ValidationSummary({ validations }) {

    const renderValidations = () => {
        return (
            validations.map((validation, index) => <li key={index}>{validation}</li>)
        );
    }

    return (
        <div className="text-danger"> Please fix the following:
            <ul>
                {renderValidations()}
            </ul>
        </div>
    );
} 