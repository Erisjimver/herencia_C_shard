using System;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Bebieca = new Caballo("Bebieca");
            Humano Israel = new Humano("Israel");
            Gorila Goku = new Gorila("Goku");
            Bebieca.getNombre();
            Israel.getNombre();
            Goku.getNombre();
        }
    }

    class Mamiferos
    {

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Puedo cuidar a mis crias");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: "+nombreSerVivo);
        }

        private string nombreSerVivo;
    }

    class Caballo:Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano:Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila:Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
