import { createTheme} from "@mui/material";
import { green } from "@mui/material/colors";
import { light } from "@mui/material/styles/createPalette";

export const Theme = createTheme({
    palette: {
        // primary: {
        //     main: "#394867",
        // },
        // secondary: {
        //     main: "#9BA4B5"
        // },
        // text: {
        //     primary: "#fff"
        // }
        primary: {
            main: "#7a2ffb", //Цвет footer и header
        },
        secondary: {
            main: "#7a2ffb" //Цвет постов
        },
        text: {
            primary: "#fff", //Цвет текста
            secondary: "#000" //Цвет текста когда наводишься
        },
        background: {
            default: "#ffaa64" //Основной цвет фона
        }
    }
});

export {}