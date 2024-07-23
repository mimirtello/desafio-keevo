using DesafioKeevo.Entities;

namespace DesafioKeevo.Model
{
    public interface ITarefaRepositorio
    {
        void Add(Tarefa tarefa);

        List<Tarefa> Get();

        bool Update(Tarefa tarefa);

        bool Delete(int id);

        Tarefa GetById(int Id);

    }
}
