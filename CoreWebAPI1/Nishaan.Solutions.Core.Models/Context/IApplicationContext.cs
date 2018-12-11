using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Nishaan.Solutions.Core.Models.Context
{
    public interface IApplicationContext
    {
        DbSet<User> UsersDB { get; set; }
        void SaveChanges();
    }
}