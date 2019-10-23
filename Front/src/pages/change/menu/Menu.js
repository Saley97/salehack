import React from "react";
import "./Menu.css";
import Img from "./menu.jpg";
import Header from "../../../components/Header/Header";
import { Link } from "react-router-dom";
class Menu extends React.Component {
  render() {
    return (
      <div>
        <Header />

        <img className=" Img1" src={Img} />
      </div>
    );
  }
}

export default Menu;
