using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAPI.Models;

namespace PruebaTecnicaAPI.Context
{
	public class ApplicationDbContext: DbContext
	{
		public DbSet<Rol> Roles { get; set; }

		public DbSet<Usuario> Usuarios { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
		}
	}
}
