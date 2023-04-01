using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.entity
{
    public class CodefirstContext : DbContext
    {
        public CodefirstContext():base(@"Server=TRANNGOCTIE0BE7\SQLEXPRESS;Database=sinhvien;Trusted_Connection=true")
        { }
        public DbSet<student> Students { get; set; }
    }
}
