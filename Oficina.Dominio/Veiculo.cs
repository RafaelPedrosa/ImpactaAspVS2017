using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Veiculo
    {   
        //Definição das Propiedades do  Objeto
        public int id { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }

        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }

        public Combustivel Combustivel { get; set; }//Enum é do tipo enumerador
        public Cambio Cambio { get; set; }



    }
}
