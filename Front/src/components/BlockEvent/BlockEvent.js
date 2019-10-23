import React from "react";
import "./BlockEvent.css";

class BlockEvent extends React.Component {
  render() {
    return (
      <div className="block1">
        <div className="event-date">
          <p>{this.props.date}</p>
          <p>{this.props.month}</p>
        </div>
        <img src={this.props.src} />
        <p>{this.props.p}</p>
      </div>
    );
  }
}

export default BlockEvent;
