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
            Ballena fliper = new Ballena("Fliper");
            Bebieca.getNombre();
            Israel.getNombre();
            Goku.getNombre();
            fliper.respirar();
            fliper.nadar();
            Console.WriteLine(Israel.deporte());
            Bebieca.numeroPatas();
            Bebieca.deporte();

            Mamiferos[] mamiferos = new Mamiferos[3];
            mamiferos[0] = Bebieca;
            mamiferos[1] = Israel;
            mamiferos[2] = Goku;

            mamiferos[1].getNombre();
            for (int i = 0; i < 3; i++)
            {
                mamiferos[i].pensar();
            }
            //Object miAnimal = new Caballo("Bucefalo");
            //Object miPersona = new Humano("Ernesto");
        }
    }

    class Mamiferos
    {

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public virtual void pensar()
        {
            Console.WriteLine("Soy capaz de pensar, intinstivo");
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

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

        public override void pensar()//pensamiento instintivo
        {
            Console.WriteLine("Soy capaz de pensar, como pez");
        }
    }



    class Caballo:Mamiferos,InterfaceMmiferosTerrestres,InterfaceAnimalesDeportes
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public string deporte()
        {
            return "Deporte de la saltacion"; 
        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int numeroPatas()
        {
            int numero = 4;
            return numero;

        }

        public bool olimpico()
        {
            return true;
        }
    }

    class Humano:Mamiferos,InterfaceAnimalesDeportes
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public string deporte()
        {
            return "hago el deporte de la pelotacion";
        }

        public bool olimpico()
        {
            return true;
        }

        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar, Avanzado");
        }
    }

    class Gorila:Mamiferos,InterfaceMmiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void pensar()//pensamiento instintivo
        {
            Console.WriteLine("Soy capaz de pensar, intermedio");
        }

        public int numeroPatas()
        {
            int numero = 2;
            return numero;

        }
    }

    interface InterfaceMmiferosTerrestres
    {
        int numeroPatas();
    }

    interface InterfaceAnimalesDeportes
    {
        string deporte();
        Boolean olimpico();
    }
}
