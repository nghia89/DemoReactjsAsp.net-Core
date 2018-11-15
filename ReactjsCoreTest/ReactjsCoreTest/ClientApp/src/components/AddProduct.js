import React, { Component } from 'react';
import { Link, NavLink } from 'react-router-dom';
import { EmployeeData } from './Product';

interface AddDataState {
    title: string;
    loading: boolean;
    Data: EmployeeData;
}
export class AddProduct extends Component {

    constructor(props) {
        super(props);
        this.state = {
            loading: true, 
            Data: new EmployeeData
        };
       
    }
   
    onSubmit =(event)=> {
        event.preventDefault();
        const data = new FormData(event.target);
        
        // PUT request for Edit employee.
        if (this.state.Data.ObjectId) {
            fetch('api/ProductApi/Update', {
                method: 'PUT',
                body: data
            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/Product");
                });
        }

        // POST request for Add employee.
        else {
            fetch('api/ProductApi/Add', {
                method: 'PUT',
                body: data
            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/Product");
                });
        }
    }

   
    render() {

        var {Data } = this.state;
        return (
            <div>
                <h1>Employee Data</h1>
                <p>This component demonstrates fetching Employee data from the server.</p>
                <p>
                    <Link to="AddProduct">Cteate </Link>
                </p>
                <form onSubmit={this.onSubmit} >
                    <input className="form-control"hidden  type="text" name="ObjectId" defaultValue={Data.ObjectId} />
                        < div className="form-group row" >
                            <label className=" control-label col-md-12" htmlFor="Name">Name</label>
                        <div className="col-md-4">
                            <input className="form-control" type="text" name="Name" defaultValue={Data.Name}/>
                            </div>
                        </div >
                        < div className="form-group row" >
                            <label className=" control-label col-md-12" htmlFor="Name">Price</label>
                            <div className="col-md-4">
                            <input className="form-control" type="text" name="Price" defaultValue={Data.Price} />
                            </div>
                        </div >

                        <div className="form-group">
                            <button type="submit" className="btn btn-default">Save</button>
                            <button className="btn" onClick={this.handleCancel}>Cancel</button>
                        </div >
                    </form >
                </div>
        );
    }
}