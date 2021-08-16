using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
        public string Saludo(ClsComputadora computadora)
        {
            return "Bienvenido querido usuario";
        }
        public string Reiniciar(ClsComputadora computadora)
        {
            return "Reiniciando computadora";
        }
        public string Apagar(ClsComputadora computadora)
        {
            return "Apagando computadora";
        }
        public string Encender(ClsComputadora computadora)
        {
            return "";
        }
    }
}
