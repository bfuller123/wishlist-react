import React, { Component } from 'react';

export class Item extends Component {
    constructor(props) {
        super(props);
        this.state = {}
    }

    render() {
        return(
            <tr>
                <td>{this.props.item.name}</td>
                <td>{this.props.item.cost}</td>
                <td>{this.props.item.purchased}</td>
                <td>{this.props.item.dateAdded}</td>
            </tr>
        );
    }
}