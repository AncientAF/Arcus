export const featuredPostTypography = {
    fontWeight: "700",
    display: "inline-flex",
    justifyContent: "flex-start",
    alignItems: "flex-start",
    marginRight: "5px",
    border: "2px solid black",
    padding: "2px",
    borderRadius: "20%",
    color: "white",
    backgroundColor: "black"
  };

  export const cardStyle = {
    minWidth: 150,
    maxWidth: 270,
    backgroundColor: "rgba(255, 255, 255, 0.2)",
    boxShadow: "0 4px 30px rgba(0, 0, 0, 0.1)",
    backdropFilter: "blur(5px)",
    WebkitBackdropFilter: "blue(5px)",
    border: "1px solid rgba(255, 255, 255, 0.3)",
    borderRadius: "16px",
    "&:hover div img": {
      transform: "scale(1.5)",
      height: "150",
    },
  };

  export const cardMediaStyle = {
    cursor: "pointer",
    borderRadius: "16px",
    transition: "0.5s all ease-in-out",
    minHeight: "150px",
    minWidth: "270px",
  };

  export const cardContentStyle = {
    display: "flex",
    justifyContent: "flex-start",
    flexDirection: "column",
  };

  export const postTypographyStyle = {
    fontWeight: "700",
    display: "inline-flex",
    justifyContent: "flex-start",
    alignItems: "flex-start",
    marginRight: "5px",
    padding: "2px",
    borderRadius: "20%",
    color: "white",
    backgroundColor: "black",
    cursor: "pointer",
    transition: "0.2s all ease-in-out",
    "&:hover": {
      backgroundColor: "white",
      color: "text.secondary",
    },
  };

  export {}