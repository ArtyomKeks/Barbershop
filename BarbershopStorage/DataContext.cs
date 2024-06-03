using BarbershopStorage.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopStorage
{
    public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        { }

        public virtual DbSet<Client> Clients { get; set; }
    }
}
