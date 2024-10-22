using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_de_objeto
{
    public class Produto //produto = Classe
    {

        //Public = Modificador de visibilidade
        public int id {get; set;} // get = permite criar regras p/ leitura do atributo || set = regras p/ atribuição de valores ao atributo.

        public string nome { get; set;} 

        public int quantidade { get; set;}

        public float valor { get; set;}

    }
}
