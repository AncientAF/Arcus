import React from "react";
import logo from "./assets/svg/logo.svg";
import "./assets/css/App.css";
import "@fontsource/roboto/300.css";
import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import Header from "./components/shared/Header/Header";
import Footer from "./components/shared/Footer/Footer";
import Wave from "react-wavify";
import { Outlet } from "react-router-dom";
import { relative } from "path";

function App({ children }: any) {
  return (
    <div className="App">
      <Header></Header>
      <div style={{ rotate: "180deg", marginTop: "-5px" }}>
        <Wave
          fill="#1976d2"
          paused={false}
          options={{
            height: 15,
            amplitude: 20,
            speed: 0.15,
            points: 3,
          }}
        />
      </div>
      <Outlet />
      <div style={{ marginBottom: "-5px" }}>
        <Wave
          fill="#1976d2"
          paused={false}
          options={{
            height: 15,
            amplitude: 20,
            speed: 0.15,
            points: 3,
          }}
        />
      </div>
      <Footer></Footer>
    </div>
  );
}

export default App;
