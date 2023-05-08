import React from "react";
import { useState, useEffect } from "react";
import PostProps from "./PostProps";
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';
import { title } from "process";

  
  //function Post(props: {postInfo:PostProps}) {
  function Post(props: {postInfo: PostProps}) {

    
  
    return (
      <Card sx={{ maxWidth: 345 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image="https://images2.minutemediacdn.com/image/upload/c_crop,w_2115,h_1189,x_0,y_217/c_fill,w_720,ar_16:9,f_auto,q_auto,g_auto/images/voltaxMediaLibrary/mmsport/mentalfloss/01gwscsvw2yrt73s9sqj.jpg"
          alt="green iguana"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {props.postInfo.title}
            {}
          </Typography>
          {/* <Typography variant="body2" color="text.secondary">
            {props.postInfo.context}
          </Typography> */}
        </CardContent>
      </CardActionArea>
    </Card>
    );
  }
  
  export default Post;
  