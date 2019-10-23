import React from "react";
import "./Info1.css";
import { Link } from "react-router-dom";

class Info extends React.Component {
  constructor(props) {
    super(props);
    this.state = { isButtonOn: true };
    this.handleClick = this.handleClick.bind(this);
  }

  handleClick() {
    this.setState(prevState => ({
      isButtonOn: !prevState.isButtonOn
    }));
  }

  render() {
    return (
      <div className="info">
        <h2 className="H22"> {this.props.h2} </h2>
        <div className="content-info">
          <div className=" imgInfo">
            <img className=" imgInfo" src={this.props.src} />
          </div>

          <div className="content-text-info1">
            <h3>Начало: </h3> <p> {this.props.data1} </p>
            <h3>Окончание: </h3>
            <p> {this.props.data2} </p>
            <p> {this.props.p}</p>
            <div className="Row">
              <Link to="/change/info/menu">
                {" "}
                <button className=" btn_see1"> Меню</button>{" "}
              </Link>
              <Link to="/change/info/event">
                {" "}
                <button className=" btn_see1"> Мероприятия</button>{" "}
              </Link>

              <Link to="/change/info/move">
                {" "}
                <button className=" btn_see1"> Прямая трансляция</button>{" "}
              </Link>

              <button className=" see" onClick={this.handleClick}>
                {this.state.isButtonOn
                  ? "Оставить заявку!"
                  : "Заявка отправлена!"}
              </button>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Info;
