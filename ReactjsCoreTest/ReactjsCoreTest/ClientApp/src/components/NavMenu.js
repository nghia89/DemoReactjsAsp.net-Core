import React, { Component } from 'react';
import { Link, NavLink } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export class NavMenu extends Component {
    displayName = NavMenu.name

    render() {
        return (
            <nav className="navbar navbar-expand-lg navbar-light bg-left">
                <div className="container-fluid">
                    <ul className="nav navbar-nav">
                        <li >
                            <NavLink to={'/'} exact className='active'>
                                <span className='glyphicon glyphicon-home'></span> Home
                            </NavLink>
                        </li>
                        <li >
                            <Link to={'/product'} className='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Product
                            </Link>
                        </li>
                    </ul>
                </div>
            </nav>

        );
    }
}
