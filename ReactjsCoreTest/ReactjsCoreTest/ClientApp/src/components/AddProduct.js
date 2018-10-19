import React, { Component } from 'react';

export class AddProduct extends Component {
    displayName = AddProduct.name

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

        fetch('api/ProductApi/GetAll')
            .then(response => response.json())
            .then(data => {
                this.setState({ forecasts: data, loading: false });
            });
    }

    static renderForecastsTable(forecasts) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Id</th>
                        <th>Price</th>
                        <th>DataCreate</th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(forecast =>
                        <tr key={forecast.Id}>
                            <td>{forecast.Name}</td>
                            <td>{forecast.Price}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading? <p><em>Loading...</em></p>: AddProduct.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1>Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
}
