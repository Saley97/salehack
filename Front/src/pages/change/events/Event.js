import React from "react";
import "./Event.css";
import { Link } from "react-router-dom";
import Header from "../../../components/Header/Header";
import Block from "../../../components/BlockEvent/BlockEvent";

class Events extends React.Component {
  render() {
    return (
      <>
        <Header />
        <div className="event">
          <Block
            date="4"
            month="Июля"
            src="https://topstudents.ru/wp-content/uploads/2019/10/eda17604651973da5c32132879f7775c-1024x683.jpeg"
            p="Мастер-класс «Школа дикторов»"
          />
          <Block
            date="5"
            month="Июля"
            src="https://topstudents.ru/wp-content/uploads/2019/10/957486882e3a3fd16d820d7bfab91d07-1024x535.jpeg "
            p="Лекторий «Как сериалы стали важнее кино» "
          />
          <Block
            date="7"
            month="Июля"
            src="https://topstudents.ru/wp-content/uploads/2019/10/Many_Book_Library_468620_2048x1536-1024x768.jpg "
            p="Книжный стендап WonderBooks "
          />
          <Block
            date="9"
            month="Июля"
            src="http://www.ngpavlograd.org.ua/wp-content/uploads/2014/06/kak-veselo-provesti-leto5.jpg "
            p=" Водное безумие"
          />
          <Block
            date="11"
            month="Июля"
            src="https://topstudents.ru/wp-content/uploads/2019/10/19a1b21b2f80a18b8a652fa7242f1183.jpg "
            p="Праздничный концерт «Лето» "
          />
          <Block
            date="13"
            month="Июля"
            src="https://topstudents.ru/wp-content/uploads/2019/10/0d6a41d8cdad356ccece3b4ca4a25be8.jpeg "
            p=" Вечер джаза"
          />
          <Block
            date="15"
            month="Июля"
            src="https://www.culture.ru/storage/images/ea26d195a606959615d5386995425515/c626749378661a8b417c6f6aa740e840.jpeg "
            p=" Кинопоказ"
          />
          <Block
            date="17"
            month="Июля"
            src="http://i41-cdn.woman.ru/images/gallery/f/3/g_f3beef970fac7f4191a43b6afadb8dd5_2_1400x1100.jpg?02"
            p=" КВН"
          />
          <Block
            date="19"
            month="Июля"
            src="http://i41-cdn.woman.ru/images/gallery/c/7/g_c7beef1788b01b004b17f886e133c38f_2_1400x1100.jpg?02 "
            p=" Закрытие смены"
          />
        </div>
      </>
    );
  }
}

export default Events;
