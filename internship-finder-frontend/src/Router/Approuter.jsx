import React from "react";
import {Routes, Route } from "react-router";
import { Contact } from "../Pages/Contact";
import { About } from "../Pages/About";

export function AppRouter() {
    return(
        <>
        <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/Contact" element={<Contact />} />
            <Route path0="/about" element={<About/>} />
        </Routes>       
        
        </>
    )
}