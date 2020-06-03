using System;

namespace Gerenciador.Model
{
    class Pessoa
    {
        private string _nome;
        private string _sobreNome;
        public DateTime birth { get; private set; }

        public Pessoa()
        {
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

        public int calculaDias ()
        {
            
        }
    }
}
