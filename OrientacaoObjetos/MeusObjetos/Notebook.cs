using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos.MeusObjetos
{
    public class Notebook
    {
        public int QtdProcessadores { get; set; }
        public string Marca { get; set; }
        public string AnoDoNot { get; set; }
        public string Modelo { get; set; }

        public string Ligar()
        {
            return "Estou ligando";

        }
        public string Ligar(string voltagen)
        {
            return "Estou ligado em " + voltagen;
        }
    }
}
