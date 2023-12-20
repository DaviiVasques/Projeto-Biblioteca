using System;
using Microsoft.EntityFrameworkCore;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LivroContext())
            {
                db.Livros.Add(new Livro { Titulo = "Princípios, Padrões e Práticas Ágeis em C#", Autor = " Robert C Martin", AnoPublicacao = 2011 });
                db.Livros.Add(new Livro { Titulo = "Use a Cabeça C#", Autor = "Andrew Stellman", AnoPublicacao = 2007 });
                db.SaveChanges();
                
                Console.WriteLine("------------------------ RESULTADO ------------------------");
                db.Livros.ForEachAsync(x => Console.WriteLine("Titulo: " + x.Titulo + " | Autor: " + x.Autor + " | Ano de Publicação: " +x.AnoPublicacao));

            }
        }
    }
}
