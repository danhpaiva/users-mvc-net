using Microsoft.EntityFrameworkCore;
using UsersMvcNet6.Models;

namespace UsersMvcNet6.Context
{
  public class ScheduleContext : DbContext
  {
    public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
    {

    }

    public DbSet<Contact> Contacts { get; set; }
  }
}