

export interface PostProps {
  tags:          Tag[];
  id:            number;
  title:         string;
  metaTitle:     null;
  author:        null;
  datePublished: null;
  dateUpdated:   null;
  dateCreated:   null;
  isPublished:   boolean;
  context:       string;
}

export interface Tag {
  id:      number;
  title:   string;
  meta:    null;
  content: null;
}


export default PostProps;