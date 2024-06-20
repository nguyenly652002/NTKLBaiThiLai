using Microsoft.EntityFrameworkCore;
using NTKL;
using NTKL.Models;

namespace NguyenThiKhanhLy424.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    }
}