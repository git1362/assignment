const baseUrl = process.env.REACT_APP_API_BASE_URL;

const sendHttpRequest = (url, method, data) => {
    return fetch(baseUrl + url, {
        method: method,
        body: JSON.stringify(data),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(response => {
        if (response.ok) {
            return;
        }
        else if (!response.ok && response.status === 400) {
            return response.json().then(errData => {
                throw errData;
            });
        } else {
            throw new Error('Something went wrong!'); 
        }
    })
        .catch(error => {
            throw error;
        });

};

export {
    sendHttpRequest
};