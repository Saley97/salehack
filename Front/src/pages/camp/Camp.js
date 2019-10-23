import React from "react";
import "./Camp.css";
import Camp from "../../components/Block/Block";
import Header from "../../components/Header/Header";
import { Link } from "react-router-dom";
import Img from "../../components/all.png";

class Camps extends React.Component {
  render() {
    return (
      <div>
        <Header />

        <div className="camp">
          <Link to="/camp/info">
            {" "}
            <Camp
              src="http://www.molcentr.ru/upload/resize_cache/alt/ec5/ec557f350b2ad3aa59b33d9552803954_688_404.jpeg"
              p="Детский лагерь Smart Camp"
            />{" "}
          </Link>
          <Link to="/camp/info">
            {" "}
            <Camp
              src="http://www.molcentr.ru/upload/resize_cache/alt/90c/90c2d11573fb9a0ed24d64e882822727_688_404.jpeg"
              p="Молодёжный оздоровительный лагерь 'Ямал'"
            />
          </Link>
          <Link to="/camp/info">
            {" "}
            <Camp
              src="http://www.molcentr.ru/upload/resize_cache/alt/689/6896e20b77510ee40bea805bf8e12872_688_404.jpeg"
              p="Международный молодежный центр I&Camp 2019 Республика Крым"
            />
          </Link>
          <Link to="/camp/info">
            {" "}
            <Camp
              src="http://www.molcentr.ru/upload/resize_cache/alt/ba1/ba14382c3b41f0dfba7a6365b373522d_688_404.jpeg "
              p=" Детский оздоровительный лагерь Питер ЯМАЛ"
            />
          </Link>
          <Link to="/camp/info">
            {" "}
            <Camp
              src="http://www.molcentr.ru/upload/resize_cache/alt/32a/32a30a6c69c1976067a9867cd62ba2b6_688_404.jpeg "
              p=" Культурно-оздоровительный центр Премьера г. Анапа"
            />
          </Link>
          <Link to="/camp/info">
            {" "}
            <Camp
              src=" http://www.molcentr.ru/upload/resize_cache/alt/626/626d2b17e397500defe5e6ec15985dcc_688_404.png"
              p="ПО СТКД 'Шахтинский текстильщик' "
            />
          </Link>
        </div>

        <img className="All" src={Img} />
      </div>
    );
  }
}

export default Camps;
