using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciador_de_Aniversarios
{
    class Pessoa
    {
        private string _nome;
        private string _sobreNome;
        public DateTime birth {get; private set;}

        public Pessoa()
        {
        }

        public Pessoa(String nome, String sobrenome, DateTime data)
        {
            _nome = nome;
            _sobreNome = sobrenome;
            birth = data;
        }

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public string GetSobreNome()
        {
            return _sobreNome;
        }
        public void SetSobreNome(string sobreNome)
        {
            if (sobreNome != null && sobreNome.Length > 1)
            {
                _sobreNome = sobreNome;
            }
        }
        public int QntosDiasFaltam()
        {
            DateTime today = DateTime.Today;
            DateTime niver = new DateTime(today.Year, birth.Month, birth.Day);

            if(niver < today)
            {
                niver = niver.AddYears(1);
            }

            int diasFaltantes = (niver - today).Days;
            return diasFaltantes;
        }
        public override string ToString()
        {
            return " Nome Completo: " + _nome + _sobreNome +
                   "\n Data do Aniversario: " + birth.Day + "/" + birth.Month + "/" + birth.Year
                   + "\n Faltam " + QntosDiasFaltam() + " dias para esse aniversario";
        }
    }
}
