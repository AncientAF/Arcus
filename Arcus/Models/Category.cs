﻿namespace Arcus.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Meta { get; set; }
        public string Context { get; set; }
    }
}
