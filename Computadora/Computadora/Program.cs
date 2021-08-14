using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();
            clscomputadora.Targeta_madre = "asus b216";
            clscomputadora.Capacidad_ram = 16;
            clscomputadora.Procesador = "i5 th10 generacion";
            clscomputadora.Disco_duro = 250;
            clscomputadora.Enfriamiento_liquido = "cool master " ;
            clscomputadora.Monitor = "asus ";
            clscomputadora.Mause = "hp";
            clscomputadora.Teclado = "redragon";
            clscomputadora.Fuente_de_poder =  "generica" ;
            clscomputadora.Ups = "toymachin";

            //Console.WriteLine
            Console.WriteLine(nclscomputadora.Saludo(clscomputadora));
            Console.WriteLine(nclscomputadora.Reiniciar(clscomputadora));
            Console.WriteLine(nclscomputadora.Apagar(clscomputadora));
            Console.WriteLine(nclscomputadora.Encender(clscomputadora));
            Console.ReadLine();


        }
    }
}
