import React from "react";
import "./App.css";
import { Route, Redirect, Switch } from "react-router-dom";
import CampInfo from "./pages/camp/CampInfo";
import ChangeInfo from "./pages/change/ChangeInfo";
import Camp from "./pages/camp/Camp";
import FAQ from "./pages/FAQ/FAQ";
import Change from "./pages/change/Change";
import Menu from "./pages/change/menu/Menu";
import Move from "./pages/change/video/Video";
import Event from "./pages/change/events/Event";
class App extends React.Component {
  render() {
    return (
      <Switch>
        <Route exact path="/camp" component={Camp} />
        <Route exact path="/camp/info" component={CampInfo} />
        <Route exact path="/change/info" component={ChangeInfo} />
        <Route exact path="/change/info/menu" component={Menu} />
        <Route path="/FAQ" component={FAQ} />
        <Route exact path="/change" component={Change} />
        <Route exact path="/change/info/move" component={Move} />
        <Route exact path="/change/info/event" component={Event} />
        <Redirect to="/camp" />
      </Switch>
    );
  }
}

export default App;
