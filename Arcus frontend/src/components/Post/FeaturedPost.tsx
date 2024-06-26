import PostProps from "./PostProps";
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { Button, CardActionArea } from '@mui/material';
import * as styles from "./styles"

  //function Post(props: {postInfo:PostProps}) {
  function FeaturedPost(props: {postInfo: PostProps}) {

    
  
    return (
      <Card sx={{ maxWidth: 900, width: "80%" }}>
      <CardActionArea >
        <CardMedia
          component="img"
          height="300"
          image="https://images2.minutemediacdn.com/image/upload/c_crop,w_2115,h_1189,x_0,y_217/c_fill,w_720,ar_16:9,f_auto,q_auto,g_auto/images/voltaxMediaLibrary/mmsport/mentalfloss/01gwscsvw2yrt73s9sqj.jpg"
          alt=""
          sx={{pointerEvents: "none",}}
        />
        <CardContent sx={{backgroundColor: "secondary.main"}}>
          {props.postInfo.tags?.map(tag => {
            return(
              <Typography  key={tag.id} sx={styles.featuredPostTypography}>{tag.title}</Typography>
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
  
  export default FeaturedPost;
  