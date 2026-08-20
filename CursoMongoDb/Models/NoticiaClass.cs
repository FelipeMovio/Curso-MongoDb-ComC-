using Newtonsoft.Json;

namespace CursoMongoDb.Models;

public class NoticiaClass
{
    public string Titulo { get; set; }
    public string Texto { get; set; }
    public DateTime DataPublicacao { get; set; }
    public List<string> Tags { get; set; }
    public List<JornalistaClass> Jornalistas { get; set; }
    public List<ComentarioClass> Comentarios { get; set; }
    public List<AnexoClass> Anexos { get; set; }
    public int Visualizacoes { get; set; }
    public int TotalComentarios { get; set; }
    public int Gostei { get; set; }
    public int NaoGostei { get; set; }
    public int TempoMedioLeitura { get; set; }


    public string ToJson()
    {
        return JsonConvert.SerializeObject(this,Formatting.Indented);
    }

}
