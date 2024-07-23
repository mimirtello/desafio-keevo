using DesafioKeevo.Entities;
using DesafioKeevo.ListaTarefasContext;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

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

        public Tarefa GetById(int id)
        {
            
            var tarefa = _connectionContext.Tarefas.Find(id);

            return tarefa;
        }

        public bool Update(Tarefa tarefa)
        {
          
            var existingTarefa = _connectionContext.Tarefas.Find(tarefa.Id);

            if (existingTarefa == null)
            {
                return false; 
            }

           
            existingTarefa.Titulo = tarefa.Titulo;
            existingTarefa.Descricao = tarefa.Descricao;
            existingTarefa.Status = tarefa.Status;

            _connectionContext.SaveChanges();
            return true;
           
        }

        public bool Delete(int id)
        {
            
            var tarefa = _connectionContext.Tarefas.Find(id);

            if (tarefa == null)
            {
                return false; 
            }

            _connectionContext.Tarefas.Remove(tarefa);
            _connectionContext.SaveChanges();
            return true; 
        }
    }
}

