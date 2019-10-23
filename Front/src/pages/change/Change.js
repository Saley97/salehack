import React from "react";
import "./Change.css";
import Change from "../../components/Block/Block";
import Header from "../../components/Header/Header";
import { Link } from "react-router-dom";
class Changes extends React.Component {
  render() {
    return (
      <div>
        <Header />
        <div className="camp">
          <Link to="/change/info">
            {" "}
            <Change
              src="https://avatars.mds.yandex.net/get-zen_doc/168601/pub_5c63ea4b84e0ea00aebfa927_5c63ea8173490c00ae7ef656/scale_1200"
              p="Спортивная смена "
            />{" "}
          </Link>
          <Link to="/change/info">
            {" "}
            <Change
              src="http://millardayo.com/wp-content/uploads/2014/04/Screen-Shot-2014-04-30-at-4.21.09-AM.png "
              p=" Comedy смена"
            />{" "}
          </Link>
          <Link to="/change/info">
            {" "}
            <Change
              src="https://www.culture.ru/storage/images/1ae126c88d41d156c700f9df83309efa/fef8346826dd97efd4a1c7ab060eb460.jpeg "
              p=' "Твори и созидай"'
            />{" "}
          </Link>
        </div>
      </div>
    );
  }
}

export default Changes;
