using CursoMongoDb.Models;

namespace CursoMongoDb.Exercicios;

public class Program_2_5
{
    public static void Executar()
    {
        var noticia = new NoticiaClass
        {
            Titulo = "C# e MongoDB: aprendendo NoSQL",
            Texto = "Este é um exemplo de notícia utilizando C# com MongoDB.",
            DataPublicacao = DateTime.Now,

            Tags = new List<string>
    {
        "C#",
        ".NET",
        "MongoDB",
        "NoSQL"
    },

            Jornalistas = new List<JornalistaClass>
    {
        new JornalistaClass
        {
            Nome = "Felipe Movio"
        },
        new JornalistaClass
        {
            Nome = "João Silva"
        }
    },

            Comentarios = new List<ComentarioClass>
    {
        new ComentarioClass
        {
            Comentario = "Excelente notícia!",
            Curtidas = 15,
            Usuario = "Carlos",
            Data = DateTime.Now
        },
        new ComentarioClass
        {
            Comentario = "Gostei bastante do conteúdo.",
            Curtidas = 8,
            Usuario = "Maria",
            Data = DateTime.Now
        }
    },

            Anexos = new List<AnexoClass>
    {
        new AnexoClass
        {
            NomeArquivo = "mongodb.pdf",
            Url = "https://exemplo.com/mongodb.pdf",
            Tamanho = 2048,
            Tipo = "PDF",
            CLiques = 10
        },
        new AnexoClass
        {
            NomeArquivo = "imagem.png",
            Url = "https://exemplo.com/imagem.png",
            Tamanho = 1024,
            Tipo = "Imagem",
            CLiques = 25
        }
    },

            Visualizacoes = 1500,
            TotalComentarios = 2,
            Gostei = 120,
            NaoGostei = 5,
            TempoMedioLeitura = 6
        };

        Console.WriteLine("Noticia no formato JSON:");
        Console.WriteLine(noticia.ToJson());
    }
    
}
