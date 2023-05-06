import React from "react";
import logo from "./assets/svg/logo.svg";
import "./assets/css/App.css";
import Blog from "./components/Blog";
import "@fontsource/roboto/300.css";
import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";

function App() {
  return (
    <div className="App">
      <Blog />
    </div>
  );
}

export default App;
