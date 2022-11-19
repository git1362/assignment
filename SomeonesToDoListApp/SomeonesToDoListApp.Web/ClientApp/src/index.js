import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ErrorBoundary from "./components/ErrorBoundary";
import { createRoot } from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import App from './App';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <ErrorBoundary>
        <BrowserRouter basename={baseUrl}>
            <App />
        </BrowserRouter>
    </ErrorBoundary>
);