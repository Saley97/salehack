import React from "react";
import "./Button.css";

class Button extends React.Component {
  render() {
    if (this.props.color === "white") {
      return <button className="white"> {this.props.name} </button>;
    } else {
      return <button className="black"> {this.props.name} </button>;
    }
  }
}

export default Button;
