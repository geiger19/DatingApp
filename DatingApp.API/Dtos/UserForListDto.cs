using System;
using System.Collections.Generic;

namespace DatingApp.API.Dtos
{
    public class UserForListDto
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
    }
}