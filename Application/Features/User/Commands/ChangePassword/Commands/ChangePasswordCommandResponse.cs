﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.ChangePassword.Commands
{
    public class ChangePasswordCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}