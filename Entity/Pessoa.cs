using System;

namespace EstudoLINQ.Entity
{
    public class Pessoa
    {
        /// <summary>
        /// Propriedades da Clase
        /// </summary>
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        /// <param name="id">Inteiro</param>
        /// <param name="nome">Stirng</param>
        /// <param name="dataNascimento">Datetime</param>
        public Pessoa(int id, string nome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        /// <summary>
        /// Sobrecarga do método ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID: " + Id.ToString() + " |Nome: " + Nome + " |Data Nascimento: " + DataNascimento.ToShortDateString();
        }
    }
}
