import Grid from "@mui/material/Grid";
import Post from "../../components/Post/Post";
import PostProps from "../../components/Post/PostProps";
import FeaturedPost from "../../components/Post/FeaturedPost";
import { useEffect, useState } from "react";
const baseUrl = "https://localhost:44362/api/Blog/";

function Blog() {
  
  const [posts, setPosts] = useState<PostProps[]>([]);
  const GetPosts = async () => {
    const data = await fetch(baseUrl + "GetPostsWithTags", {
      method: "GET",
    });
    const jsonData = await data.json();
    console.log(jsonData);
    setPosts(jsonData);
  };

  useEffect(() => {
    GetPosts();
  }, []);
  return (
      <Grid
        container
        justifyContent="flex-start"
        alignItems="center"
        spacing={{ xs: 2, md: 4 }}
        columns={{ xs: 4, sm: 8, md: 12 }}
        sx={{paddingY: "20px"}}
      >
        {posts.map((post: PostProps) => {
                return (

                    <Grid item xs={2} sm={4} md={4} key={post.id} sx={{
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center"
                    }}>
                      <Post postInfo={post}></Post>
                    </Grid>
                  );
        })}
      </Grid>
  );
}

export default Blog;
