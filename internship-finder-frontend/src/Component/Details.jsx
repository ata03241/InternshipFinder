import React from 'react';
import './detail.css';




export function Details() {
    return (
        <>
            <div class="blog-single gray-bg">
                <div class="containerrr">
                    <div class="row align-items-start">
                        <div class="col-lg-8 m-15px-tb">
                            <article class="article">
                                <div class="article-title">
                                    <h6><a href="#">Lifestyle</a></h6>
                                    <h2>They Now Bade Farewell To The Kind But Unseen People</h2>
                                    <div class="media">
                                        <div class="media-body">
                                            <label>Rachel Roth</label>
                                            <span>26 FEB 2020</span>
                                        </div>
                                    </div>
                                </div>
                                <div class="article-content">
                                    <p>Aenean eleifend ante maecenas pulvinar montes lorem et pede dis dolor pretium donec dictum. Vici consequat justo enim. Venenatis eget adipiscing luctus lorem. Adipiscing veni amet luctus enim sem libero tellus viverra venenatis aliquam. Commodo natoque quam pulvinar elit.</p>
                                    <p>Eget aenean tellus venenatis. Donec odio tempus. Felis arcu pretium metus nullam quam aenean sociis quis sem neque vici libero. Venenatis nullam fringilla pretium magnis aliquam nunc vulputate integer augue ultricies cras. Eget viverra feugiat cras ut. Sit natoque montes tempus ligula eget vitae pede rhoncus maecenas consectetuer commodo condimentum aenean.</p>
                                    <h4>What are my payment options?</h4>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                    <blockquote>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                                        <p class="blockquote-footer">Someone famous in <cite title="Source Title">Dick Grayson</cite></p>
                                    </blockquote>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                                </div>
                                <div class="nav tag-cloud">
                                    <a href="#">Design</a>
                                    <a href="#">Development</a>
                                    <a href="#">Travel</a>
                                    <a href="#">Web Design</a>
                                    <a href="#">Marketing</a>
                                    <a href="#">Research</a>
                                    <a href="#">Managment</a>
                                </div>
                            </article>
                        </div>
                        <div class="col-lg-4 m-15px-tb blog-aside">
                            {/* Author */}
                            <div class="widget widget-author">
                                <div class="widget-title">
                                    <h3>Author</h3>
                                </div>
                                <div class="widget-body">
                                    <div class="media align-items-center">
                                        <div class="avatar">
                                            <img src="https://bootdey.com/img/Content/avatar/avatar6.png" title="" alt="" />
                                        </div>
                                        <div class="media-body">
                                            <h6>Hello, I'm<br /> Rachel Roth</h6>
                                        </div>
                                    </div>
                                    <p>I design and develop services for customers of all sizes, specializing in creating stylish, modern websites, web services and online stores</p>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}