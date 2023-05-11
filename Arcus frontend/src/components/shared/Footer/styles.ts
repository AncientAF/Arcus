export const iconStyle = {
  color: "#fff",
  "&:hover": {
    backgroundColor: "white",
    color: "text.secondary",
  },
  borderRadius: "20%",
  mr: "1px",
};

export const buttonStyle = {
  color: "text.primary",
  display: "flex",
  fontSize: 12,
  width: "100px",
  "&:hover": {
    backgroundColor: "white",
    color: "text.secondary",
  },
};

export const footerBoxStyle = {
  width: "100%",
  height: "auto",
  backgroundColor: "primary.main",
  paddingTop: "1rem",
  paddingBottom: "1rem",
};

export const boxForButtons = {
  flexGrow: 1,
  display: { xs: "none", md: "flex" },
  flexDirection: "column",
  alignItems: "center",
};

export {}