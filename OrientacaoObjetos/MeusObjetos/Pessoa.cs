using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos.MeusObjetos
{
    public class Pessoa
    {
        public Notebook MeuNoteBook { get; set; }
        public string Cabelo {get; set;}
        public string Olhos { get; set; }
        public string Naris { get; set; }
        public string Boca { get; set; }
        public string Orelha { get; set; }
        public string nome { get; set; }

        public int Idade { get; set; }
        public bool EhDeMaior { get; set; }

        public string Falar()
        {
            return "estou falando";
        } 

        public string Falar(string idioma)
        {
            return "estou falando em " + idioma;
        }

    }
}
