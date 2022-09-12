﻿namespace BeenTogether.Models
{
    public class Love
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ApartDate { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string LastModify { get; set; }

        public virtual ICollection<Story> Stories { get; set; }

        public virtual ICollection<Hobby> Hobbies { get; set; }
    }
}