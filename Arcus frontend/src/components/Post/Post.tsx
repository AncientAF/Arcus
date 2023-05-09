import PostProps from "./PostProps";
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';
import { useNavigate } from "react-router-dom";
import { isExternalModuleNameRelative } from "typescript";
  
  //function Post(props: {postInfo:PostProps}) {
  function Post(props: {postInfo: PostProps}) {

    const navigate = useNavigate();
  
    return (
      <Card sx={{ maxWidth: 300, width: "80%" }} onClick={() => navigate("Post/" + props.postInfo.id)}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image="https://images2.minutemediacdn.com/image/upload/c_crop,w_2115,h_1189,x_0,y_217/c_fill,w_720,ar_16:9,f_auto,q_auto,g_auto/images/voltaxMediaLibrary/mmsport/mentalfloss/01gwscsvw2yrt73s9sqj.jpg"
          alt=""
          sx={{pointerEvents: "none",}}
        />
        <CardContent sx={{
          backgroundColor: "secondary.main"
        }}>
          {props.postInfo.tags?.map(tag => {
            return(
              <Typography  key={tag.id} sx={{
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
              }}>{tag.title}</Typography>
            );
          })}
          {/* Добавить сюда отображение тегов поста */}
          <Typography color="text.primary" gutterBottom variant="h5" component="div">
            {props.postInfo.title}
          </Typography>
        </CardContent>
      </CardActionArea>
    </Card>
    );
  }
  
  export default Post;
  