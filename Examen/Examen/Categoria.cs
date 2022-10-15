using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Categoria
    {
        List<int> lista = new List<int>() {
    1, 2, 3
        };
        void promocion()
        {
            Console.WriteLine(  "Descuentos y promociones");
        }

        void Listacategoria()
        {

        }
        class Categoria1 : Categoria
        {
            public void promocion() { Console.WriteLine("Descuento del 15%"); }
        }

        class Categoria2 : Categoria
        {
            public void promocion() { Console.WriteLine("Promocion de 2 por 1"); }
        }
        class Categoria3 : Categoria
        {
            public void promocion() { Console.WriteLine("“Todo a mitad de precio"); }
        }

    }
    }

