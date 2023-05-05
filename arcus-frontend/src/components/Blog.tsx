import { type } from '@testing-library/user-event/dist/type';
import React, { useEffect, useState } from 'react';

type Post = {
    id: number;
    title: string;
    metaTitle: string;
    author: string;
    isPublished: boolean;
    context: string;
}

    
function Blog() {
    const baseUrl = "https://localhost:44362/api/blog/"
    const [post, setPosts] = useState<Post[]>([]);
    let posts: Post[] = [];
    const GetPosts = async () => {
        const data = await fetch(baseUrl + "GetPosts", {
            method: "GET"
        });
        const jsonData = await data.json();
        console.log(jsonData);
        setPosts(jsonData);
    };

    useEffect(() => {
        
        GetPosts();
    }, []);

    return (
        <div>
            <ul>
                {post?.map((value) => {
                    return (
                        <li>
                            <p>{value.id}</p>
                            <p>{value.context}</p>
                        </li>
                    );
                })}
            </ul>
        </div>
    );
}

export default Blog;