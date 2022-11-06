using Microsoft.EntityFrameworkCore;
using myProject.Model;

namespace myProject.Database
{
    public class UsuarioDbContext: DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext>
        options) : base(options) {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable("ususario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.DataNascimento).HasColumnName("data_nascimento");            
        }
    }
}