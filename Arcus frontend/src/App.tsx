import "./assets/css/App.css";
import "@fontsource/roboto/300.css";
import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import Header from "./components/shared/Header/Header";
import Footer from "./components/shared/Footer/Footer";
import { Outlet } from "react-router-dom";
import { Box, Container } from "@mui/material";
import mainWave1 from "./assets/svg/mainWave1.svg";
import mainWave2 from "./assets/svg/mainWave2.svg";

function App({ children }: any) {
  return (
    <div className="App">
      <Header></Header>
      <Box
          style={{
            aspectRatio: "960/150",
            width: "100%",
            backgroundRepeat: "no-repeat",
            backgroundPosition: "center",
            backgroundSize: "cover",
            backgroundImage: `url(${mainWave1})`,
            pointerEvents: "none",
            // position: "absolute",
            // zIndex: "0",
            // top: "50px",
          }}
        ></Box>
      <Box sx={{ backgroundColor: "background.default", background: "linear-gradient(180deg, rgba(143,12,216,1) 0%, rgba(255,170,100,1) 100%)", paddingX: "10vw"}}>
        
        <Outlet />
      </Box>
      <Box
          style={{
            aspectRatio: "960/150",
            width: "100%",
            backgroundRepeat: "no-repeat",
            backgroundPosition: "center",
            backgroundSize: "cover",
            backgroundImage: `url(${mainWave2})`,
            pointerEvents: "none",
            // position: "absolute",
            // zIndex: "0",
            // top: "50px",
          }}
        ></Box>
      <Footer></Footer>
    </div>
  );
}

export default App;
