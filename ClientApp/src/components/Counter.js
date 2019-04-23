import React, { Component } from 'react';

export class Counter extends Component {

  constructor (props) {
    super(props);
    this.state = { currentCount: 0 };
  }

  changeCounter (amountToChangeBy) {
    this.setState({
      currentCount: this.state.currentCount + amountToChangeBy
    })
  }

  render () {
    return (
      <div>
        <h1>{this.props.counterName}</h1>

        <p>This is a simple example of a React component.</p>

        <p>Current count: <strong>{this.state.currentCount}</strong></p>

        <button className="btn btn-primary" onClick={() => this.changeCounter(1)}>Increment</button>
        <button className="btn btn-primary" onClick={() => this.changeCounter(-1)}>Decrement</button>
      </div>
    );
  }
}
