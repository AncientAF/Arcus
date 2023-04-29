﻿namespace Arcus.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string RegisteredAt { get; set; }
        public string LastLogin { get; set; }
        public string ImagePath { get; set; }
        public string About { get; set; }
    }
}
