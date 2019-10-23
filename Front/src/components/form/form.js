import React from "react";
import "./form.css";
import { Link } from "react-router-dom";

class Form extends React.Component {
  render() {
    return (
      <div>
        <div id="envelope" class="envelope">
          <form method="post" action="">
            <div class="FormHeader">
              <a href="">
                <div class="FormButtonLeft">ЛЬГОТЫ </div>
              </a>
              <a href="">
                <div class="FormButtonRight">БЕЗ ЛЬГОТ </div>
              </a>
            </div>
            <div class="form-group ">
              <i class="fa fa-envelope-o" aria-hidden="true"></i>

              <input type="email" name="email" placeholder="Почта" />
            </div>
            <div class="form-group ">
              <i class="fa fa-key" aria-hidden="true"></i>
              <input type="password" name="password" placeholder="Пароль" />
            </div>
            <div class="form-group ">
              <i class="fa fa-key" aria-hidden="true"></i>
              <input
                type="password"
                name="password"
                placeholder="Повторите пароль"
              />
            </div>
            <div class="form-group ">
              <i class="fa fa-user-circle-o" aria-hidden="true"></i>

              <input name="surname" placeholder="Фамилия" />
            </div>
            <div class="form-group ">
              <i class="fa fa-user-circle-o" aria-hidden="true"></i>

              <input name="name" placeholder="Имя" />
            </div>
            <div class="form-group ">
              <i class="fa fa-user-circle-o" aria-hidden="true"></i>

              <input name="midlle_name" placeholder="Отчетсво" />
            </div>
            <div class="form-group ">
              <i class="fa fa-mobile" aria-hidden="true"></i>

              <input type="tel" name="phone" placeholder="Телефон" />
            </div>
            <div class="r">
              {" "}
              <input type="checkbox" name="consent" class="consent" />
              <label class="consent" id="consent">
                Я согласен с <a href="">политикой конфиденциальности </a>
              </label>
            </div>

            <input id="btn" type="submit" value="Зарегистрироваться" />
          </form>
        </div>
        <div id="fade" class="black_overlay"></div>
      </div>
    );
  }
}

export default Form;
