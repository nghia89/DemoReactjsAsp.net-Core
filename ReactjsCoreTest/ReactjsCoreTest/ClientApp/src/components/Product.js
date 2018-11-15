import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import './AddProduct';


export class Product extends React.Component<RouteComponentProps<{}>, FetchEmployeeDataState> {
    displayName = Product.name

    constructor(props) {
        super(props);
        this.state = {
            forecasts: [], loading: true
        };
        fetch('api/ProductApi/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ forecasts: data, loading: false });
            });
    }

    Edit =(ObjectId) =>{
        
        this.props.history.push("/AddProduct/edit/" + ObjectId);
    }  

    static renderForecastsTable(forecasts) {
        return (
            <div>
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
                                <td>
                                    <button type="button" className="btn btn-warning"
                                        onClick={this.onUpdate}
                                    >
                                        <span className="fa fa-pencil mr-5"></span>Sửa</button>
                                    <a className="action" onClick={(ObjectId) => this.Edit(forecast.ObjectId)}>Edit</a>  |
                                 <a className="action" onClick={(ObjectId) => this.handleDelete(forecast.ObjectId)}>Delete</a>
                                </td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }

    render() {
        let contents = this.state.loading ? <p><em>Loading...</em></p> : Product.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1>Employee Data</h1>
                <p>This component demonstrates fetching Employee data from the server.</p>
                <p>
                    <Link to="AddProduct">Cteate</Link>
                </p>
                {contents}
            </div>
        );
    }
}
export class EmployeeData {
    ObjectId: string = '';
    Name: string = "";
    Price: string = "";
} 