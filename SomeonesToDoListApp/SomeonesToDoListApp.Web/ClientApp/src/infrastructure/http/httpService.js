const baseUrl = process.env.REACT_APP_API_BASE_URL;

const sendHttpRequest = (url, method, data) => {
    const jsonData = { id: data.id, toDoItem: data.toDoItemName };
    return fetch(baseUrl + url, {
        method: method,
        body: JSON.stringify(jsonData),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(response => {
        if (!(response.status >= 200 && response.status < 300)) {
            return response.json().then(errData => {
                console.log(errData);
                throw new Error('Something went wrong - server-side.');
            });
        }
    })
        .catch(error => {
            console.log(error);
            throw new Error('Something went wrong!');
        });

};

export {
    sendHttpRequest
};