﻿using Microsoft.AspNetCore.Identity;

namespace RefreshTokenJwt.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
