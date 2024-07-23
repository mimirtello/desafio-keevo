namespace DesafioKeevo.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        

        //public Tarefa() { }
        public Tarefa(string titulo, string descricao, string status)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Status = status;
        }
    }
}
