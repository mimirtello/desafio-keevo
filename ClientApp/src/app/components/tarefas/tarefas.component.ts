import { Component, Input, OnInit } from '@angular/core';

interface Tarefa {
  id?: number;
  titulo?: string;
  descricao?: string;
  status?: string; // 'pendente' | 'em andamento' | 'concluída'
}

@Component({
  selector: 'app-tarefas',
  templateUrl: './tarefas.component.html',
  styleUrls: ['./tarefas.component.css']
})
export class TarefasComponent implements OnInit{

  tarefaParaEditar: Tarefa | null = null;
  editando = false;

  tarefas: Tarefa[] = []; 

  novaTarefaTitulo: string = ''; 
  novaTarefaDescricao: string = ''; 
  novaTarefaStatus: string = 'pendente'; 

  constructor() { }

  ngOnInit(): void {
  }

  generateTaskId(): number {
 //gerador de Id
    return this.tarefas.length + 1;
  }

  addTarefa(): void {
    const newTarefa: Tarefa = {
      id: this.generateTaskId(),
      titulo: this.novaTarefaTitulo,
      descricao: this.novaTarefaDescricao,
      status: this.novaTarefaStatus
    };

    this.tarefas.push(newTarefa);

    // Limpa os campos do formulário após adicionar a tarefa
    this.novaTarefaTitulo = '';
    this.novaTarefaDescricao = '';
    this.novaTarefaStatus = 'pendente';
  }

  editarTarefa(tarefa: Tarefa): void {
    if (tarefa) {
      this.tarefaParaEditar = tarefa;
      this.editando = true;
    }
    else
    {
      console.log("Nenhuma tarefa selecionada para editar.")
    }
   
  }

  salvarTarefa(tarefa: Tarefa): void {
    // Atualizar a tarefa no array de tarefas
    const tarefaIndex = this.tarefas.findIndex(t => t.id === tarefa.id);
    this.tarefas[tarefaIndex] = tarefa;

    // Limpar os campos do formulário de edição
    this.tarefaParaEditar = null;
    this.editando = false;
  }

  excluirTarefa(tarefaId: number | null): void {
    this.tarefas = this.tarefas.filter(tarefa => tarefa.id !== tarefaId);
  }

 

}
