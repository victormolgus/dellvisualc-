using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Oficina4._1
{
    class ClienteContext:DbContext
    {
        public ClienteContext():base("Oficina4.1")
        { }
        public DbSet<Cliente> Cliente { get; set; }


    }
}
