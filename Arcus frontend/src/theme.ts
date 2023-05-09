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
            main: "#C8FFD4",
        },
        secondary: {
            main: "#B1AFFF"
        },
        text: {
            primary: "#000",
            secondary: "#B8E8FC" 
        },
        background: {
            default: "#FDFDBD"
        }
    }
});

export {}