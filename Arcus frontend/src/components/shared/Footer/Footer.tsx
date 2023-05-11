import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import Typography from "@mui/material/Typography";
import Container from "@mui/material/Container";
import Button from "@mui/material/Button";
import { useNavigate } from "react-router-dom";
import { Grid } from "@mui/material";
import YouTubeIcon from "@mui/icons-material/YouTube";
import TwitterIcon from "@mui/icons-material/Twitter";
import EmailIcon from "@mui/icons-material/Email";
import * as styles from "./styles";
import { pages, name } from "../consts";

export function Footer() {
  const navigate = useNavigate();

  return (
    <Box sx={styles.footerBoxStyle}>
      <Container maxWidth="lg">
        <Grid container direction="row" alignItems="center">
          <Grid item xs={12}>
            <Typography color="text.primary" variant="h5">
              {name}
            </Typography>
          </Grid>
          <Grid item xs={6} sx={{ display: { xs: "none", md: "block" } }}>
            <Toolbar>
              <Box sx={styles.boxForButtons}>
                {pages.map((page) => (
                  <Button
                    key={page.id}
                    onClick={() => {
                      navigate(page.route);
                    }}
                    sx={styles.buttonStyle}
                  >
                    {page.label}
                  </Button>
                ))}
              </Box>
            </Toolbar>
          </Grid>
          <Grid item xs={12} md={6}>
            <Typography color="text.primary" variant="subtitle1">
              {`${new Date().getFullYear()} | Web-design | Blog`}
            </Typography>
            <YouTubeIcon sx={styles.iconStyle} />
            <TwitterIcon sx={styles.iconStyle} />
            <EmailIcon sx={styles.iconStyle} />
          </Grid>
        </Grid>
      </Container>
    </Box>
  );
}

export default Footer;
