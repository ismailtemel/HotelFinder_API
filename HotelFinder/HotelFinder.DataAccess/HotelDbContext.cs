using HotelFinder.Entites;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-0P06I08\\SQLEXPRESS01; Database=HotelDb; uid=z29;pwd=11072010");
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
