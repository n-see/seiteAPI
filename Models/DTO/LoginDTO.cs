using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seiteAPI.Models.DTO;

public class LoginDTO
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
}