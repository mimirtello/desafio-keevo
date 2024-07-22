using DesafioKeevo.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioKeevo.ListaTarefasContext
{
    public class TarefasContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        //public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql(
             "Server=localhost;" +
             "Port=5432;Database=ListaTarefas;" +
             "User Id=postgres;" +
             "Password=080591;");

    }
}
