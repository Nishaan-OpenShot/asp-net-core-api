using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nishaan.Solutions.Core.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}