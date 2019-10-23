import React from 'react';
import './Header.css';
import Logo from './logo.png'
import Button from '../Button/Button'
import { Link } from 'react-router-dom';
import Form from '../form/form'

class Header extends React.Component {
  constructor(props) {
    super(props);
    this.state = { isFormOn: false };

    // This binding is necessary to make `this` work in the callback
    this.handleClick = this.handleClick.bind(this);
  }

  handleClick() {
    this.setState(prevState => ({
      isFormOn: !prevState.isFormOn
    }));
  }

  render() {
    return (
      <header>
        <img src={Logo} className="Img" />
        <Link to='/camp'> <div className="header_li li"> ЛАГЕРЯ </div>  </Link>
        <Link to='/change'>  <div className="header_li li"> СМЕНЫ </div> </Link>
        <Link to='/FAQ'>  <div className="header_li li"> FAQ </div> </Link>
        <div className="header_li ">
          <div className="header_li">
            <Button name="Войти" color="white" />
            <div onClick={this.handleClick}>
              <Button name="Регистрация" color="white" />
              {this.state.isFormOn ? <Form className="Form" /> : ''}
            </div>


          </div>
        </div>

      </header>

    )
  }
}




export default Header;

