using DesafioKeevo.Entities;
using DesafioKeevo.ListaTarefasContext;
using Microsoft.AspNetCore.Connections;

namespace DesafioKeevo.Model.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly TarefasContext _connectionContext = new TarefasContext();
        public void Add(Tarefa tarefa)
        {
            _connectionContext.Tarefas.Add(tarefa);
            _connectionContext.SaveChanges();
        }

        public List<Tarefa> Get()
        {
            return _connectionContext.Tarefas.ToList();
        }
    }
}
