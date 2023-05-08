import Grid from "@mui/material/Grid";
import Post from "../../components/Post/Post";
import PostProps from "../../components/Post/PostProps";
import { useEffect, useState } from "react";


function Blog() {
  const baseUrl = "https://localhost:44362/api/Blog/";
  const [posts, setPosts] = useState<PostProps[]>([]);
  const GetPosts = async () => {
    const data = await fetch(baseUrl + "GetPosts", {
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
        spacing={{ xs: 2, md: 3 }}
        columns={{ xs: 4, sm: 8, md: 12 }}
        sx={{marginTop: "20px"}}
      >
        {posts.map((post: PostProps) => {
            if(post.id == 1)
            {
                return( //Сделать класс featured post чтобы какой-то пост показывался больше чем остальные
                    <Grid item xs={2} sm={4} md={4} key={post.id} sx={{
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                    }}>
                      <Post postInfo={post}></Post>
                    </Grid>
                );
            }
            else{
                return (

                    <Grid item xs={2} sm={4} md={4} key={post.id} sx={{
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center"
                    }}>
                      <Post postInfo={post}></Post>
                    </Grid>
                  );
            }
            
        })}
      </Grid>
  );
}

export default Blog;
