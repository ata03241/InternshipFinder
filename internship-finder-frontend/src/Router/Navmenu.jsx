import React from "react";
import { Link } from "react-router";
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import "./Router.css";

export default function Navmenu() {
    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-light bg-light shadow-sm -100">
                <div className="container">
                    <img src="../../public/logg.png" alt="Logo" id="logo" className="navbar-brand" />
                    <button
                        className="navbar-toggler"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#navbarNav"
                        aria-controls="navbarNav"
                        aria-expanded="false"
                        aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav ms-auto">
                            <li className="nav-item">
                                <Link className="nav-link" to="/about">About</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/Contact">Contact</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/internships">Internships</Link>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </>
    );
}
