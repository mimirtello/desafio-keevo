using DesafioKeevo.Entities;
using DesafioKeevo.Model;
using DesafioKeevo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DesafioKeevo.Controllers
{
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefaRepository;
        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepository = tarefaRepositorio ?? throw new ArgumentNullException();

        }

        [HttpPost]
        public IActionResult Add(TarefaViewModel tarefaView)
        {
            var tarefa = new Tarefa(tarefaView.Titulo,tarefaView.Descricao, tarefaView.Status);
            _tarefaRepository.Add(tarefa);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var tarefas = _tarefaRepository.Get();
            return Ok(tarefas);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, TarefaViewModel tarefaView)
        {
            var tarefa = _tarefaRepository.GetById(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            tarefa.Titulo = tarefaView.Titulo;
            tarefa.Descricao = tarefaView.Descricao;
            tarefa.Status = tarefaView.Status;

            _tarefaRepository.Update(tarefa);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            var tarefa = _tarefaRepository.GetById(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            int taskId = tarefa.Id; 

            _tarefaRepository.Delete(taskId);

            return NoContent();
        }

    }
}
