using HRMS.Logic.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database
{
  public  class HRMSContext  : DbContext
    {
        public HRMSContext(DbContextOptions<HRMSContext> options) : base(options)
        {

        }
        public DbSet<BloodGroup> BloodGroup { get; set; }
    }
}
