
using Microsoft.EntityFrameworkCore;
using VAII.Models;

namespace VAII.Data
{
    public class VAIIDB : DbContext
    {
        public static VAIIDB DB { get; private set; }
        public VAIIDB(DbContextOptions<VAIIDB> options)
            : base(options)
        {
            DB = this;
        }

        public DbSet<AcountModel> Acounts { get; set; }
    }
}