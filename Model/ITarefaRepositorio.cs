using DesafioKeevo.Entities;

namespace DesafioKeevo.Model
{
    public interface ITarefaRepositorio
    {
        void Add(Tarefa tarefa);

        List<Tarefa> Get();
    }
}
