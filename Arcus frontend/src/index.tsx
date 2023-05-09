import React from "react";
import ReactDOM from "react-dom/client";
import "./assets/css/index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Blog from "./pages/blog/Blog";
import PostPage from "./pages/blog/PostPage/PostPage";
import { ThemeProvider } from "@mui/material";
import { Theme } from "./theme";
const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      // {
      //   path: "Blog",
      //   element: <Blog />,
      // },
      {
        path: "",
        element: <Blog />,
      },
      {
        path: "Post/:id",
        element: <PostPage />,
      },
    ],
  },
]);

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);
root.render(
  <React.StrictMode>
    <ThemeProvider theme={Theme}>
      <RouterProvider router={router} />
    </ThemeProvider>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
