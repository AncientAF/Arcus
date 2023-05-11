

export interface PostProps {
  tags:          Tag[];
  id:            number;
  title:         string;
  metaTitle:     string;
  author:        string;
  datePublished: Date;
  dateUpdated:   Date;
  dateCreated:   Date;
  isPublished:   boolean;
  context:       string;
  imagePath:       string;
}

export interface Tag {
  id:      number;
  title:   string;
  meta:    null;
  content: null;
}


export default PostProps;