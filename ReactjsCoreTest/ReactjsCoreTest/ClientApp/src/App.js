import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Product } from './components/Product';
import { AddProduct } from './components/AddProduct';

export default class App extends Component {
    displayName = App.name

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/Product' component={Product} />
                <Route path='/AddProduct' component={AddProduct} />
                <Route path='/AddProduct/edit/:id' component={AddProduct} />
            </Layout>
        );
    }
}
