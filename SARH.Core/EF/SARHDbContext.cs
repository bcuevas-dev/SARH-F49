using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARH.Core.EF
{
    public partial class SARHDbContext:DbContext
    {
        public SARHDbContext()
            : base("name=SARHConnetions")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }


    }
}
