import React from "react";
import "./ChangeInfo.css";
import Header from "../../components/Header/Header";
import Info1 from "../../components/Info1/Info1";

class ChangeInfo extends React.Component {
  render() {
    return (
      <div className="info">
        <Header />
        <Info1
          h2="Cпортивная смена"
          p="Спорт – это целый мир, но к нему необходимо привить интерес! 
              И лучшим местом для этого может стать летний лагерь на море. 
              Расслабляющая обстановка юга, новые друзья, все возможности и развитая инфраструктура,
               опытные и профессиональные тренеры – вот залог успешного начала (или яркого продолжения)
                спортивного пути."
          src="https://avatars.mds.yandex.net/get-pdb/202366/5ac2f790-befa-4bae-b80c-f5a15b876b27/s1200?webp=false"
          data1="4 Июня 2019"
          data2="20 Июня 2019"
        />
      </div>
    );
  }
}

export default ChangeInfo;
