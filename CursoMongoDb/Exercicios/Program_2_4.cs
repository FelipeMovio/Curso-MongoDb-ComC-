using CursoMongoDb.Models;

namespace CursoMongoDb.Exercicios;

public class Program_2_4
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

        Console.WriteLine($"Título: {noticia.Titulo}");
        Console.WriteLine($"Texto: {noticia.Texto}");
        Console.WriteLine($"Data de publicação: {noticia.DataPublicacao}");

        Console.WriteLine("\n--- Tags ---");
        foreach (var tag in noticia.Tags)
        {
            Console.WriteLine($"Tag: {tag}");
        }

        Console.WriteLine("\n--- Jornalistas ---");
        foreach (var jornalista in noticia.Jornalistas)
        {
            Console.WriteLine($"Nome: {jornalista.Nome}");
        }

        Console.WriteLine("\n--- Comentários ---");
        foreach (var comentario in noticia.Comentarios)
        {
            Console.WriteLine($"Comentário: {comentario.Comentario}");
            Console.WriteLine($"Curtidas: {comentario.Curtidas}");
            Console.WriteLine($"Usuário: {comentario.Usuario}");
            Console.WriteLine($"Data: {comentario.Data}");
            Console.WriteLine();
        }

        Console.WriteLine("\n--- Anexos ---");
        foreach (var anexo in noticia.Anexos)
        {
            Console.WriteLine($"Nome: {anexo.NomeArquivo}");
            Console.WriteLine($"URL: {anexo.Url}");
            Console.WriteLine($"Tamanho: {anexo.Tamanho}");
            Console.WriteLine($"Tipo: {anexo.Tipo}");
            Console.WriteLine($"Cliques: {anexo.CLiques}");
            Console.WriteLine();
        }

        Console.WriteLine("\n--- Estatísticas ---");
        Console.WriteLine($"Visualizações: {noticia.Visualizacoes}");
        Console.WriteLine($"Total de comentários: {noticia.TotalComentarios}");
        Console.WriteLine($"Gostei: {noticia.Gostei}");
        Console.WriteLine($"Não gostei: {noticia.NaoGostei}");
        Console.WriteLine($"Tempo médio de leitura: {noticia.TempoMedioLeitura} minutos");
    }
}
