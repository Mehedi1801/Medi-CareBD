
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medi_CareBDAPI.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

using medi_CareBDAPI.Controllers;
using medi_CareBDAPI.Models;

namespace madicare.Data
{
    public class medicareDBContext : DbContext
    {
        public medicareDBContext(DbContextOptions<medicareDBContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> admin { get; set; }
        public DbSet<AdminMediCare> admin_medi_care { get; set; }

        public DbSet<Doctor> doctors { get; set; }

        public DbSet<Patient> patient { get; set; }

   
        public DbSet<test> tests { get; set; }
        public DbSet<medicine> medicines { get; set; }


    }
}
