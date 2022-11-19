import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import TodoList from "./components/TodoList";
import Home from "./components/Home";
import EditItem from "./components/EditItem";
import { Layout } from './components/Layout';

export default function App() {
    return (
        <Layout>
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/todolist" element={<TodoList />} />
                <Route path="/:category/:id" element={<EditItem />} />
            </Routes>
        </Layout>
    );
}
