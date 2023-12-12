using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOCOMA_API_Service
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<ApplicationDbContex> options)
            : base(options)
        {

        }
    }
}