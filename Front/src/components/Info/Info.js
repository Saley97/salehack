import React from "react";
import "./Info.css";

import { Link } from "react-router-dom";

class Info extends React.Component {
  render() {
    return (
      <div className="info">
        <h2 className="H2"> {this.props.h2} </h2>
        <div className="content-info">
          <div className=" imgInfo">
            <img className=" imgInfo" src={this.props.src} />
            <Link to="/change">
              {" "}
              <button className=" btn_see"> Посмотреть смены</button>{" "}
            </Link>
          </div>

          <div className="content-text-info">
            <h3>Местоположение</h3>
            <p> {this.props.place} </p>
            <h3>Территория</h3>
            <p> {this.props.content}</p>
            <h3>Проживание</h3>
            <p> {this.props.life}</p>
            <h3>Питание</h3>
            <p> {this.props.food}</p>
            <h3>Пляж</h3>
            <p> {this.props.beach}</p>
          </div>
        </div>
      </div>
    );
  }
}

export default Info;
