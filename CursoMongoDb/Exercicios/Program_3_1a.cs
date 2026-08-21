using CursoMongoDb.Models;
using MongoDB.Driver;

namespace CursoMongoDb.Exercicios;

public class Program_3_1a
{
    public static void Executar()
    {
        var connectionString =
            "mongodb://dbFelipe:root@ac-vrrd4d4-shard-00-00.rxruqal.mongodb.net:27017,ac-vrrd4d4-shard-00-01.rxruqal.mongodb.net:27017,ac-vrrd4d4-shard-00-02.rxruqal.mongodb.net:27017/?ssl=true&replicaSet=atlas-hazes9-shard-0&authSource=admin&appName=MyCluster0";

        var client = new MongoClient(connectionString);

        var database = client.GetDatabase("NoticiasDB");

        var collection = database.GetCollection<dynamic>("noticias");

        database.CreateCollection("noticias");

        Console.WriteLine("Banco de dados Criados");
    }
    
}
