import React from "react";
import "./home.css"
import { Details } from "../Component/Details";
import { Footer } from "../Component/footer";


export function Home() {
    const swedenort = [
        "Stockholm län",
        "Uppsala län",
        "Södermanlands län",
        "Östergötlands län",
        "Jönköpings län",
        "Kronobergs län",
        "Kalmar län",
        "Gotlands län",
        "Blekinge län",
        "Skåne län",
        "Hallands län",
        "Västra Götalands län",
        "Värmlands län",
        "Örebro län",
        "Västmanlands län",
        "Dalarnas län",
        "Gävleborgs län",
        "Västernorrlands län",
        "Jämtlands län",
        "Norrbottens län",
        "Lapplands län"
    ];

    return (
        <>
            <div className="containerr">
                <div className="row">
                    <div className="col-lg-12 card-margin">
                        <div className="card search-form">
                            <div className="card-body p-0">
                                <form id="search-form">
                                    <div className="row">
                                        <div className="col-12">
                                            <div className="row no-gutters">
                                                <div className="col-lg-3 col-md-3 col-sm-12 p-0">
                                                    <select className="form-control" id="exampleFormControlSelect1">
                                                        <option value="">Select Location</option>
                                                        {swedenort.map((location, index) => (
                                                            <option key={index} value={location}>{location}</option>
                                                        ))}
                                                    </select>
                                                </div>
                                                <div className="col-lg-8 col-md-6 col-sm-12 p-0">
                                                    <input type="text" placeholder="Search..." className="form-control" id="search" name="search" />
                                                </div>
                                                <div className="col-lg-1 col-md-3 col-sm-12 p-0">
                                                    <button type="submit" className="btn btn-base">
                                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round" className="feather feather-search"><circle cx="11" cy="11" r="8"></circle><line x1="21" y1="21" x2="16.65" y2="16.65"></line></svg>
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div className="contain d-flex flex-column" >
                <div style={{ width: "70%", marginLeft: "5%"}} className="d-flex flex-column align-items-center">
                    <WorkCards />
                    <WorkCards />
                    <WorkCards />
                </div>
                
                <div>
                    <Details />
                </div>                                        
            </div>
        </>
    )
}

export function WorkCards()
{
    return(
        <>
        <div className="container">
            <div className="row">
                <div className="col-sm-6 col-md-6  mb-3">
                    <div className="card">
                        <div
                            className="card-body"
                            style={{ padding: "20px" }}
                        >

                            {/* Profile picture and short information */}
                            <div className="d-flex align-items-center position-relative pb-3" style={{ borderBottom: "1px solid #eee", marginBottom: "10px" }}>
                                <div className="flex-grow-2" style={{ fontSize: "1rem" }}>
                                    <a href="#" className="h3 btn-link" style={{ color: "#007bff", textDecoration: "none" }}>Sjuksköterska</a>
                                    <p className="text-muted m-0" style={{ fontWeight: 500 }}>Nässjö kommun</p>
                                    <p className="text-muted m-0" style={{ fontSize: "0.95rem" }}>Socialförvaltningen - Nässjö</p>
                                </div>
                            </div>
                            <p style={{ color: "#888", fontSize: "0.9rem", marginBottom: 0 }}>Publicerad 23 juni, kl. 13.45</p>
                            {/* END : Profile picture and short information */}                            

                        </div>
                    </div>
                </div>
            </div>
        </div>
        </>
    )
}