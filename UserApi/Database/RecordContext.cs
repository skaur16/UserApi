using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Database
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options) : base(options) { }

        public DbSet<Record> Records { get; set; } = null!;
    }
}
