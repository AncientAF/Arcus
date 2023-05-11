import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import PostProps from "../../../components/Post/PostProps";
import Typography from "@mui/material/Typography/Typography";
import Box from "@mui/material/Box/Box";

export default function PostPage() {
  const params = useParams();
  const baseUrl = "https://localhost:44362/api/Blog/";
  const [post, setPost] = useState<PostProps>();
  const GetPosts = async () => {
    const data = await fetch(baseUrl + "GetPostWithTags/" + params.id, {
      method: "GET",
    });
    const jsonData = await data.json();
    console.log(jsonData);
    setPost(jsonData);
  };

  useEffect(() => {
    GetPosts();
  }, []);
  return (
    <Box
      sx={{
        display: "inline-flex",
        alignItems: "flex-start",
        flexDirection: "column",
        width: "90%",
      }}
    >
      <Typography
        variant="h2"
        sx={{
          display: "inline-flex",
          alignItems: "flex-start",
          color: "text.primary",
          fontWeight: "500",
        }}
      >
        {post?.title}
      </Typography>
      <Box sx={{
        color: "text.secondary",
        width: "90%",
        minHeight: "500px",
        padding: "10px",
        backgroundColor: "rgba(255, 255, 255, 0.8)",
        borderRadius: "5%",
        marginTop: "20px"
      }}>
      <Typography
        sx={{
          color: "text.secondary",
          textAlign: "start",
          marginX: "40px",
        }}
        variant="body1"
      >
        {post?.context}
      </Typography>
      </Box>
    </Box>
  );
}
