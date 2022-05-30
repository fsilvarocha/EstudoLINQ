using EstudoLINQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudoLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new List<Pessoa>
            {
                new Pessoa(5,"Fabricio Silva da Rocha", new DateTime(1982,5,22)),
                new Pessoa(20,"Cinthya Pernes dos Santos", new DateTime(1986,6,5)),
                new Pessoa(10,"Bernardo dos Santos Rocha", new DateTime(2015,10,21)),
                new Pessoa(2,"Max",new DateTime(2022,03,01))
            };

            Console.WriteLine("Pessoas com Id >= 6");

            List<Pessoa> listaPessoa = pessoa.Where(p => p.Id >= 6)
                .OrderBy(p => p.Nome)
                .ToList();
            listaPessoa.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Primeira Pessoa onde o ano de nascimento é menor que o ano corrente");

            var pessoas = pessoa.First(p => p.DataNascimento.Year < DateTime.Now.Year);

            Console.WriteLine(pessoas.ToString());

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Trazer os 3 últimos registros cadastrados");

            var pess = pessoa
                .OrderByDescending(pessoa => pessoa.Id)
                .Take(3)
                .ToList();

            pess.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
