import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class TarefasService {
  private apiUrl = 'http://localhost:5000/api/tarefa';

  constructor(private http: HttpClient) { }

  // Método para adicionar uma nova tarefa
  addTarefa(tarefa: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, tarefa);
  }

  // Obter todas as tarefas
  getTarefas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  // Atualizar uma tarefa existente
  updateTarefas(tarefaId: number, tarefa: any): Observable<any> {
    const url = `${this.apiUrl}/${tarefaId}`;
    return this.http.put<any>(url, tarefa);
  }

  // Deletar uma tarefa
  deleteTask(tarefaId: number): Observable<any> {
    const url = `${this.apiUrl}/${tarefaId}`;
    return this.http.delete<any>(url);
  }
}
