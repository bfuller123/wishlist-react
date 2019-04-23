import React, {Component} from 'react';
import './AddItem.css'

export class AddItem extends Component {

    constructor(props) {
        super(props);
        this.state = {}
    }

    render () {
        return (
            <div>
                <h1>Add Item</h1>
                <br />
                <label>Item</label>
                <input placeholder="Item Name" className="wide-margin"></input>
                <br />
                <label>Cost</label>
                <input placeholder="0.00" type="number" step='any' className="wide-margin"></input>
                <br />
                <button className="btn btn-primary wide-margin" onClick="Submit">Save</button>
                <button className="btn btn-warning wide-margin" onClick="Clear">Clear</button>
            </div>
        )
    }
}
