﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw8.DTOs.Requests
{
    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
