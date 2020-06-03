using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Gerenciador_de_Aniversarios
{
    class Dados
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        public static List<Pessoa> pessoasEncontradas = new List<Pessoa>();

        public static void Adicionar (Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public static void BuscarPessoas(string nome)
        {
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.GetNome().Contains(nome) || pessoa.GetSobreNome().Contains(nome))
                {
                    pessoasEncontradas.Add(pessoa);
                }
            }
            
        }
    }
}
