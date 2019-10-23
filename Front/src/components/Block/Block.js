import React from "react";
import "./Block.css";

class Block extends React.Component {
  render() {
    return (
      <div className="block">
        <img src={this.props.src} />
        <p>{this.props.p}</p>
      </div>
    );
  }
}

export default Block;
