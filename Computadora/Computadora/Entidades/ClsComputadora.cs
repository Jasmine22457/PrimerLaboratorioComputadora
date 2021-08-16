using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private String targeta_madre;
        private int capacidad_ram;
        private String procesador;
        private int disco_duro;
        private String enfriamiento_liquido;
        private String monitor;
        private String mause;
        private String teclado;
        private String fuente_de_poder;
        private String ups;

        public string Targeta_madre { get => targeta_madre; set => targeta_madre = value; }
        public int Capacidad_ram { get => capacidad_ram; set => capacidad_ram = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public int Disco_duro { get => disco_duro; set => disco_duro = value; }
        public string Enfriamiento_liquido { get => enfriamiento_liquido; set => enfriamiento_liquido = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public string Mause { get => mause; set => mause = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Fuente_de_poder { get => fuente_de_poder; set => fuente_de_poder = value; }
        public string Ups { get => ups; set => ups = value; }
    }
}
