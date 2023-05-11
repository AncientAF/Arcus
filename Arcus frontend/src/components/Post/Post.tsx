import PostProps from "./PostProps";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { Box } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Link } from "@mui/material";
import * as styles from "./styles";
const baseUrl = "https://localhost:44362/files/";

//function Post(props: {postInfo:PostProps}) {
function Post(props: { postInfo: PostProps }) {
  const navigate = useNavigate();

  return (
    <Card sx={styles.cardStyle}>
      <Box sx={{ overflow: "hidden" }}>
        <CardMedia
          component="img"
          height="150"
          width="100"
          image={
            props.postInfo.imagePath
              ? baseUrl + props.postInfo.imagePath
              : "https://images2.minutemediacdn.com/image/upload/c_crop,w_2115,h_1189,x_0,y_217/c_fill,w_720,ar_16:9,f_auto,q_auto,g_auto/images/voltaxMediaLibrary/mmsport/mentalfloss/01gwscsvw2yrt73s9sqj.jpg"
          }
          alt=""
          sx={styles.cardMediaStyle}
          onClick={() => navigate("Post/" + props.postInfo.id)}
        />
      </Box>

      <CardContent sx={styles.cardContentStyle}>
        <Box
          sx={{ display: "flex", flexDirection: "row", marginBottm: "10px" }}
        >
          {props.postInfo.tags?.map((tag) => {
            return (
              <Typography
                fontSize="14px"
                key={tag.id}
                sx={styles.postTypographyStyle}
              >
                {tag.title}
              </Typography>
            );
          })}
        </Box>

        <Link
          color="text.primary"
          variant="h5"
          fontWeight={500}
          component="div"
          underline="hover"
          onClick={() => navigate("Post/" + props.postInfo.id)}
          sx={{ cursor: "pointer", textAlign: "start" }}
        >
          {props.postInfo.title}
        </Link>
        <Typography textAlign={"left"}>
          {props.postInfo.context.substring(0, 30)}...
        </Typography>
        <Typography textAlign={"left"}>
          By 
          <Link
            onClick={() => navigate("Post/" + props.postInfo.id)}
            underline="hover"
            fontWeight={500}
          >
            {props.postInfo.author}
          </Link>
        </Typography>
      </CardContent>
    </Card>
  );
}

export default Post;
