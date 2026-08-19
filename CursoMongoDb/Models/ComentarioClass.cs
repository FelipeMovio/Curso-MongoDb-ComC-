namespace CursoMongoDb.Models
{
    public class ComentarioClass
    {
        public string Comentario { get; set; }
        public int Curtidas { get; set; }
        public string Usuario { get; set; }
        public DateTime Data {  get; set; }
    }
}
