using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class IdeaContext : DbContext
    {
        public IdeaContext() : base("IdeaContext")
        {

        }
        public DbSet<Usuario> Usuario { get; set;}
    }
}
