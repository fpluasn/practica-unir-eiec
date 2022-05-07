using System;

namespace practica_unir_eiec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            metodo_GV();

            metodo_SG(); //Incluir llamada a metodo de Santiago G.
            metodo_DM(); //Llamada a metodo de Daniel Mejia

            //Agregar metodos adicionales debajo
        }

        public static void metodo_GV(){
            Console.WriteLine("Gustavo velasco.");
        }

        public static void metodo_SG(){
            Console.WriteLine("Santiago García");
        }

        public static void metodo_AA() {
             Console.WriteLine("Andrea Albuja");
        }


        public static void metodo_DM(){
            Console.WriteLine("Daniel Mejía Torres.");
        }
    }
}
