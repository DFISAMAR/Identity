﻿using Microsoft.AspNetCore.Identity;

namespace IdentityInMemory.Models
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
